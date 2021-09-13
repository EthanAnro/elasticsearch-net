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
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	[ConvertAs(typeof(SpanWithinQuery))]
	public partial interface ISpanWithinQuery : IQuery
	{
		Elastic.Clients.Elasticsearch.QueryDsl.ISpanQuery Big { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.ISpanQuery Little { get; set; }
	}

	public partial class SpanWithinQuery : QueryBase, ISpanWithinQuery
	{
		[JsonInclude]
		[JsonPropertyName("big")]
		public Elastic.Clients.Elasticsearch.QueryDsl.ISpanQuery Big { get; set; }

		[JsonInclude]
		[JsonPropertyName("little")]
		public Elastic.Clients.Elasticsearch.QueryDsl.ISpanQuery Little { get; set; }
	}

	public partial class SpanWithinQueryDescriptor : QueryDescriptorBase<SpanWithinQueryDescriptor, ISpanWithinQuery>, ISpanWithinQuery
	{
		Elastic.Clients.Elasticsearch.QueryDsl.ISpanQuery ISpanWithinQuery.Big { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.ISpanQuery ISpanWithinQuery.Little { get; set; }
	}
}