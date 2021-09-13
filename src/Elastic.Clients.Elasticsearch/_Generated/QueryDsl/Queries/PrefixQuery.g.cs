// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using Elastic.Transport;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	[ConvertAs(typeof(PrefixQuery))]
	public partial interface IPrefixQuery : IFieldNameQuery
	{
		Elastic.Clients.Elasticsearch.MultiTermQueryRewrite? Rewrite { get; set; }

		string Value { get; set; }

		bool? CaseInsensitive { get; set; }
	}

	public partial class PrefixQuery : FieldNameQueryBase, IPrefixQuery
	{
		[JsonInclude]
		[JsonPropertyName("rewrite")]
		public Elastic.Clients.Elasticsearch.MultiTermQueryRewrite? Rewrite { get; set; }

		[JsonInclude]
		[JsonPropertyName("value")]
		public string Value { get; set; }

		[JsonInclude]
		[JsonPropertyName("case_insensitive")]
		public bool? CaseInsensitive { get; set; }
	}

	public partial class PrefixQueryDescriptor : IPrefixQuery
	{
		Elastic.Clients.Elasticsearch.MultiTermQueryRewrite? IPrefixQuery.Rewrite { get; set; }

		string IPrefixQuery.Value { get; set; }

		bool? IPrefixQuery.CaseInsensitive { get; set; }
	}
}