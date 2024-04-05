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

namespace Elastic.Clients.Elasticsearch.MachineLearning;

[JsonConverter(typeof(DataframeAnalysisFeatureProcessorConverter))]
public sealed partial class DataframeAnalysisFeatureProcessor
{
	internal DataframeAnalysisFeatureProcessor(string variantName, object variant)
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

	public static DataframeAnalysisFeatureProcessor FrequencyEncoding(Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorFrequencyEncoding dataframeAnalysisFeatureProcessorFrequencyEncoding) => new DataframeAnalysisFeatureProcessor("frequency_encoding", dataframeAnalysisFeatureProcessorFrequencyEncoding);
	public static DataframeAnalysisFeatureProcessor MultiEncoding(Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorMultiEncoding dataframeAnalysisFeatureProcessorMultiEncoding) => new DataframeAnalysisFeatureProcessor("multi_encoding", dataframeAnalysisFeatureProcessorMultiEncoding);
	public static DataframeAnalysisFeatureProcessor NGramEncoding(Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorNGramEncoding dataframeAnalysisFeatureProcessorNGramEncoding) => new DataframeAnalysisFeatureProcessor("n_gram_encoding", dataframeAnalysisFeatureProcessorNGramEncoding);
	public static DataframeAnalysisFeatureProcessor OneHotEncoding(Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorOneHotEncoding dataframeAnalysisFeatureProcessorOneHotEncoding) => new DataframeAnalysisFeatureProcessor("one_hot_encoding", dataframeAnalysisFeatureProcessorOneHotEncoding);
	public static DataframeAnalysisFeatureProcessor TargetMeanEncoding(Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorTargetMeanEncoding dataframeAnalysisFeatureProcessorTargetMeanEncoding) => new DataframeAnalysisFeatureProcessor("target_mean_encoding", dataframeAnalysisFeatureProcessorTargetMeanEncoding);

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

internal sealed partial class DataframeAnalysisFeatureProcessorConverter : JsonConverter<DataframeAnalysisFeatureProcessor>
{
	public override DataframeAnalysisFeatureProcessor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException("Expected start token.");
		}

		object? variantValue = default;
		string? variantNameValue = default;
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
			if (propertyName == "frequency_encoding")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorFrequencyEncoding?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "multi_encoding")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorMultiEncoding?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "n_gram_encoding")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorNGramEncoding?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "one_hot_encoding")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorOneHotEncoding?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "target_mean_encoding")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorTargetMeanEncoding?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			throw new JsonException($"Unknown property name '{propertyName}' received while deserializing the 'DataframeAnalysisFeatureProcessor' from the response.");
		}

		var result = new DataframeAnalysisFeatureProcessor(variantNameValue, variantValue);
		return result;
	}

	public override void Write(Utf8JsonWriter writer, DataframeAnalysisFeatureProcessor value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (value.VariantName is not null && value.Variant is not null)
		{
			writer.WritePropertyName(value.VariantName);
			switch (value.VariantName)
			{
				case "frequency_encoding":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorFrequencyEncoding>(writer, (Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorFrequencyEncoding)value.Variant, options);
					break;
				case "multi_encoding":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorMultiEncoding>(writer, (Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorMultiEncoding)value.Variant, options);
					break;
				case "n_gram_encoding":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorNGramEncoding>(writer, (Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorNGramEncoding)value.Variant, options);
					break;
				case "one_hot_encoding":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorOneHotEncoding>(writer, (Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorOneHotEncoding)value.Variant, options);
					break;
				case "target_mean_encoding":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorTargetMeanEncoding>(writer, (Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorTargetMeanEncoding)value.Variant, options);
					break;
			}
		}

		writer.WriteEndObject();
	}
}

public sealed partial class DataframeAnalysisFeatureProcessorDescriptor<TDocument> : SerializableDescriptor<DataframeAnalysisFeatureProcessorDescriptor<TDocument>>
{
	internal DataframeAnalysisFeatureProcessorDescriptor(Action<DataframeAnalysisFeatureProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DataframeAnalysisFeatureProcessorDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private DataframeAnalysisFeatureProcessorDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private DataframeAnalysisFeatureProcessorDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public DataframeAnalysisFeatureProcessorDescriptor<TDocument> FrequencyEncoding(Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorFrequencyEncoding dataframeAnalysisFeatureProcessorFrequencyEncoding) => Set(dataframeAnalysisFeatureProcessorFrequencyEncoding, "frequency_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor<TDocument> FrequencyEncoding(Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorFrequencyEncodingDescriptor<TDocument>> configure) => Set(configure, "frequency_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor<TDocument> MultiEncoding(Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorMultiEncoding dataframeAnalysisFeatureProcessorMultiEncoding) => Set(dataframeAnalysisFeatureProcessorMultiEncoding, "multi_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor<TDocument> MultiEncoding(Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorMultiEncodingDescriptor> configure) => Set(configure, "multi_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor<TDocument> NGramEncoding(Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorNGramEncoding dataframeAnalysisFeatureProcessorNGramEncoding) => Set(dataframeAnalysisFeatureProcessorNGramEncoding, "n_gram_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor<TDocument> NGramEncoding(Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorNGramEncodingDescriptor<TDocument>> configure) => Set(configure, "n_gram_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor<TDocument> OneHotEncoding(Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorOneHotEncoding dataframeAnalysisFeatureProcessorOneHotEncoding) => Set(dataframeAnalysisFeatureProcessorOneHotEncoding, "one_hot_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor<TDocument> OneHotEncoding(Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor<TDocument>> configure) => Set(configure, "one_hot_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor<TDocument> TargetMeanEncoding(Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorTargetMeanEncoding dataframeAnalysisFeatureProcessorTargetMeanEncoding) => Set(dataframeAnalysisFeatureProcessorTargetMeanEncoding, "target_mean_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor<TDocument> TargetMeanEncoding(Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor<TDocument>> configure) => Set(configure, "target_mean_encoding");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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

public sealed partial class DataframeAnalysisFeatureProcessorDescriptor : SerializableDescriptor<DataframeAnalysisFeatureProcessorDescriptor>
{
	internal DataframeAnalysisFeatureProcessorDescriptor(Action<DataframeAnalysisFeatureProcessorDescriptor> configure) => configure.Invoke(this);

	public DataframeAnalysisFeatureProcessorDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private DataframeAnalysisFeatureProcessorDescriptor Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private DataframeAnalysisFeatureProcessorDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public DataframeAnalysisFeatureProcessorDescriptor FrequencyEncoding(Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorFrequencyEncoding dataframeAnalysisFeatureProcessorFrequencyEncoding) => Set(dataframeAnalysisFeatureProcessorFrequencyEncoding, "frequency_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor FrequencyEncoding<TDocument>(Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorFrequencyEncodingDescriptor> configure) => Set(configure, "frequency_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor MultiEncoding(Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorMultiEncoding dataframeAnalysisFeatureProcessorMultiEncoding) => Set(dataframeAnalysisFeatureProcessorMultiEncoding, "multi_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor MultiEncoding(Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorMultiEncodingDescriptor> configure) => Set(configure, "multi_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor NGramEncoding(Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorNGramEncoding dataframeAnalysisFeatureProcessorNGramEncoding) => Set(dataframeAnalysisFeatureProcessorNGramEncoding, "n_gram_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor NGramEncoding<TDocument>(Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorNGramEncodingDescriptor> configure) => Set(configure, "n_gram_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor OneHotEncoding(Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorOneHotEncoding dataframeAnalysisFeatureProcessorOneHotEncoding) => Set(dataframeAnalysisFeatureProcessorOneHotEncoding, "one_hot_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor OneHotEncoding<TDocument>(Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorOneHotEncodingDescriptor> configure) => Set(configure, "one_hot_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor TargetMeanEncoding(Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorTargetMeanEncoding dataframeAnalysisFeatureProcessorTargetMeanEncoding) => Set(dataframeAnalysisFeatureProcessorTargetMeanEncoding, "target_mean_encoding");
	public DataframeAnalysisFeatureProcessorDescriptor TargetMeanEncoding<TDocument>(Action<Elastic.Clients.Elasticsearch.MachineLearning.DataframeAnalysisFeatureProcessorTargetMeanEncodingDescriptor> configure) => Set(configure, "target_mean_encoding");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
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