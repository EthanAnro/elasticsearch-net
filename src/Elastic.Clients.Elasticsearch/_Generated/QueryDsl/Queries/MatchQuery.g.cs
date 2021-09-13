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
	[ConvertAs(typeof(MatchQuery))]
	public partial interface IMatchQuery : IFieldNameQuery
	{
		string? Analyzer { get; set; }

		bool? AutoGenerateSynonymsPhraseQuery { get; set; }

		double? CutoffFrequency { get; set; }

		Elastic.Clients.Elasticsearch.Fuzziness? Fuzziness { get; set; }

		Elastic.Clients.Elasticsearch.MultiTermQueryRewrite? FuzzyRewrite { get; set; }

		bool? FuzzyTranspositions { get; set; }

		bool? Lenient { get; set; }

		int? MaxExpansions { get; set; }

		Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.Operator? Operator { get; set; }

		int? PrefixLength { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? ZeroTermsQuery { get; set; }
	}

	public partial class MatchQuery : FieldNameQueryBase, IMatchQuery
	{
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("auto_generate_synonyms_phrase_query")]
		public bool? AutoGenerateSynonymsPhraseQuery { get; set; }

		[JsonInclude]
		[JsonPropertyName("cutoff_frequency")]
		public double? CutoffFrequency { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzziness")]
		public Elastic.Clients.Elasticsearch.Fuzziness? Fuzziness { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_rewrite")]
		public Elastic.Clients.Elasticsearch.MultiTermQueryRewrite? FuzzyRewrite { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_transpositions")]
		public bool? FuzzyTranspositions { get; set; }

		[JsonInclude]
		[JsonPropertyName("lenient")]
		public bool? Lenient { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_expansions")]
		public int? MaxExpansions { get; set; }

		[JsonInclude]
		[JsonPropertyName("minimum_should_match")]
		public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

		[JsonInclude]
		[JsonPropertyName("operator")]
		public Elastic.Clients.Elasticsearch.QueryDsl.Operator? Operator { get; set; }

		[JsonInclude]
		[JsonPropertyName("prefix_length")]
		public int? PrefixLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public OneOf<string, float, bool> Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("zero_terms_query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? ZeroTermsQuery { get; set; }
	}

	public partial class MatchQueryDescriptor : IMatchQuery
	{
		string? IMatchQuery.Analyzer { get; set; }

		bool? IMatchQuery.AutoGenerateSynonymsPhraseQuery { get; set; }

		double? IMatchQuery.CutoffFrequency { get; set; }

		Elastic.Clients.Elasticsearch.Fuzziness? IMatchQuery.Fuzziness { get; set; }

		Elastic.Clients.Elasticsearch.MultiTermQueryRewrite? IMatchQuery.FuzzyRewrite { get; set; }

		bool? IMatchQuery.FuzzyTranspositions { get; set; }

		bool? IMatchQuery.Lenient { get; set; }

		int? IMatchQuery.MaxExpansions { get; set; }

		Elastic.Clients.Elasticsearch.MinimumShouldMatch? IMatchQuery.MinimumShouldMatch { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.Operator? IMatchQuery.Operator { get; set; }

		int? IMatchQuery.PrefixLength { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? IMatchQuery.ZeroTermsQuery { get; set; }
	}
}