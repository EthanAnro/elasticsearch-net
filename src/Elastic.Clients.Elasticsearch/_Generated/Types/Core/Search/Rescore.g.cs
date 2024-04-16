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

#nullable restore

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Core.Search;

[JsonConverter(typeof(RescoreConverter))]
public sealed partial class Rescore
{
	internal Rescore(string variantName, object variant)
	{
		if (variantName is null)
			throw new ArgumentNullException(nameof(variantName));
		if (variant is null)
			throw new ArgumentNullException(nameof(variant));
		if (string.IsNullOrWhiteSpace(variantName))
			throw new ArgumentException("Variant name must not be empty or whitespace.");
		VariantName = variantName;
		Variant = variant;
	}

	internal object Variant { get; }
	internal string VariantName { get; }

	public static Rescore LearningToRank(Elastic.Clients.Elasticsearch.Core.Search.LearningToRank learningToRank) => new Rescore("learning_to_rank", learningToRank);
	public static Rescore Query(Elastic.Clients.Elasticsearch.Core.Search.RescoreQuery rescoreQuery) => new Rescore("query", rescoreQuery);

	[JsonInclude, JsonPropertyName("window_size")]
	public int? WindowSize { get; set; }

	public bool TryGet<T>([NotNullWhen(true)] out T? result) where T : class
	{
		result = default;
		if (Variant is T variant)
		{
			result = variant;
			return true;
		}

		return false;
	}
}

internal sealed partial class RescoreConverter : JsonConverter<Rescore>
{
	public override Rescore Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException("Expected start token.");
		}

		object? variantValue = default;
		string? variantNameValue = default;
		int? windowSizeValue = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException("Expected a property name token.");
			}

			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException("Expected a property name token representing the name of an Elasticsearch field.");
			}

			var propertyName = reader.GetString();
			reader.Read();
			if (propertyName == "window_size")
			{
				windowSizeValue = JsonSerializer.Deserialize<int?>(ref reader, options);
				continue;
			}

			if (propertyName == "learning_to_rank")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Core.Search.LearningToRank?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "query")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Core.Search.RescoreQuery?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			throw new JsonException($"Unknown property name '{propertyName}' received while deserializing the 'Rescore' from the response.");
		}

		var result = new Rescore(variantNameValue, variantValue);
		result.WindowSize = windowSizeValue;
		return result;
	}

	public override void Write(Utf8JsonWriter writer, Rescore value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (value.WindowSize.HasValue)
		{
			writer.WritePropertyName("window_size");
			writer.WriteNumberValue(value.WindowSize.Value);
		}

		if (value.VariantName is not null && value.Variant is not null)
		{
			writer.WritePropertyName(value.VariantName);
			switch (value.VariantName)
			{
				case "learning_to_rank":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Core.Search.LearningToRank>(writer, (Elastic.Clients.Elasticsearch.Core.Search.LearningToRank)value.Variant, options);
					break;
				case "query":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.Core.Search.RescoreQuery>(writer, (Elastic.Clients.Elasticsearch.Core.Search.RescoreQuery)value.Variant, options);
					break;
			}
		}

		writer.WriteEndObject();
	}
}

public sealed partial class RescoreDescriptor<TDocument> : SerializableDescriptor<RescoreDescriptor<TDocument>>
{
	internal RescoreDescriptor(Action<RescoreDescriptor<TDocument>> configure) => configure.Invoke(this);

	public RescoreDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private RescoreDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private RescoreDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	private int? WindowSizeValue { get; set; }

	public RescoreDescriptor<TDocument> WindowSize(int? windowSize)
	{
		WindowSizeValue = windowSize;
		return Self;
	}

	public RescoreDescriptor<TDocument> LearningToRank(Elastic.Clients.Elasticsearch.Core.Search.LearningToRank learningToRank) => Set(learningToRank, "learning_to_rank");
	public RescoreDescriptor<TDocument> LearningToRank(Action<Elastic.Clients.Elasticsearch.Core.Search.LearningToRankDescriptor> configure) => Set(configure, "learning_to_rank");
	public RescoreDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.Core.Search.RescoreQuery rescoreQuery) => Set(rescoreQuery, "query");
	public RescoreDescriptor<TDocument> Query(Action<Elastic.Clients.Elasticsearch.Core.Search.RescoreQueryDescriptor<TDocument>> configure) => Set(configure, "query");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (WindowSizeValue.HasValue)
		{
			writer.WritePropertyName("window_size");
			writer.WriteNumberValue(WindowSizeValue.Value);
		}

		if (!string.IsNullOrEmpty(ContainedVariantName))
		{
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
				writer.WriteEndObject();
				return;
			}

			JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class RescoreDescriptor : SerializableDescriptor<RescoreDescriptor>
{
	internal RescoreDescriptor(Action<RescoreDescriptor> configure) => configure.Invoke(this);

	public RescoreDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private RescoreDescriptor Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private RescoreDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	private int? WindowSizeValue { get; set; }

	public RescoreDescriptor WindowSize(int? windowSize)
	{
		WindowSizeValue = windowSize;
		return Self;
	}

	public RescoreDescriptor LearningToRank(Elastic.Clients.Elasticsearch.Core.Search.LearningToRank learningToRank) => Set(learningToRank, "learning_to_rank");
	public RescoreDescriptor LearningToRank(Action<Elastic.Clients.Elasticsearch.Core.Search.LearningToRankDescriptor> configure) => Set(configure, "learning_to_rank");
	public RescoreDescriptor Query(Elastic.Clients.Elasticsearch.Core.Search.RescoreQuery rescoreQuery) => Set(rescoreQuery, "query");
	public RescoreDescriptor Query<TDocument>(Action<Elastic.Clients.Elasticsearch.Core.Search.RescoreQueryDescriptor> configure) => Set(configure, "query");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (WindowSizeValue.HasValue)
		{
			writer.WritePropertyName("window_size");
			writer.WriteNumberValue(WindowSizeValue.Value);
		}

		if (!string.IsNullOrEmpty(ContainedVariantName))
		{
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
				writer.WriteEndObject();
				return;
			}

			JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		}

		writer.WriteEndObject();
	}
}