﻿
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Nest;

// TODO: Need to figure out a better way to incorporate these tests into the normal test suite workflow.

// Purposely outside of the Nest namespace in order to bypass test setup.
namespace Tests.Security.BasicAuthTests
{
	[TestFixture]
	// Ignore these tests by default and run manually (for now) by commenting out the [Ignore] attribute.
	// A considerable amount of setup is required to run them, which will also cause the rest of the test
	// suite to fail.
	[Ignore]
	public class BasicAuthorizationTests
	{
		[Test]
		public void No_Credentials_Result_In_401()
		{
			var settings = new ConnectionSettings(new Uri("http://localhost:9200"));
			var client = new ElasticClient(settings);
			var response = client.RootNodeInfo();
			response.IsValid.Should().BeFalse();
			response.ConnectionStatus.HttpStatusCode.Should().Be(401);
		}

		[Test]
		public void Invalid_Credentials_Result_In_401()
		{
			var settings = new ConnectionSettings(new Uri("http://localhost:9200"))
				.SetBasicAuthorization("nestuser", "incorrectpassword");
			var client = new ElasticClient(settings);
			var response = client.RootNodeInfo();
			response.IsValid.Should().BeFalse();
			response.ConnectionStatus.HttpStatusCode.Should().Be(401);
		}

		[Test]
		public void Valid_Credentials_Result_In_200()
		{
			var settings = new ConnectionSettings(new Uri("http://localhost:9200"))
				.SetBasicAuthorization("nestuser", "elastic");
			var client = new ElasticClient(settings);
			var response = client.RootNodeInfo();
			response.IsValid.Should().BeTrue();
		}

		[Test]
		public void Credentials_On_URI_Result_In_200()
		{
			var settings = new ConnectionSettings(new Uri("http://nestuser:elastic@localhost:9200"));
			var client = new ElasticClient(settings);
			var response = client.RootNodeInfo();
			response.IsValid.Should().BeTrue();
		}

		[Test]
		public void ConnectionSettings_Overrides_URI()
		{
			var settings = new ConnectionSettings(new Uri("http://invalid:user@localhost:9200"))
				.SetBasicAuthorization("nestuser", "elastic");
			var client = new ElasticClient(settings);
			var response = client.RootNodeInfo();
			response.IsValid.Should().BeTrue();
		}

		[Test]
		public void RequestConfiguration_Overrides_ConnectionSettings()
		{
			var settings = new ConnectionSettings(new Uri("http://localhost:9200"))
				.SetBasicAuthorization("invalid", "user");
			var client = new ElasticClient(settings);
			var response = client.RootNodeInfo(c => c
				.RequestConfiguration(rc => rc
					.BasicAuthorization("nestuser", "elastic")
				)
			);
			response.IsValid.Should().BeTrue();
		}
	}
}
