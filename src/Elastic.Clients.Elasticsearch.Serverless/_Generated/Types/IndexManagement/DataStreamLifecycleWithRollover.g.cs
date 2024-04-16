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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

/// <summary>
/// <para>Data lifecycle with rollover can be used to display the configuration including the default rollover conditions,<br/>if asked.</para>
/// </summary>
public sealed partial class DataStreamLifecycleWithRollover
{
	/// <summary>
	/// <para>If defined, every document added to this data stream will be stored at least for this time frame.<br/>Any time after this duration the document could be deleted.<br/>When empty, every document in this data stream will be stored indefinitely.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("data_retention")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? DataRetention { get; init; }

	/// <summary>
	/// <para>The downsampling configuration to execute for the managed backing index after rollover.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("downsampling")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycleDownsampling? Downsampling { get; init; }

	/// <summary>
	/// <para>The conditions which will trigger the rollover of a backing index as configured by the cluster setting `cluster.lifecycle.default.rollover`.<br/>This property is an implementation detail and it will only be retrieved when the query param `include_defaults` is set to true.<br/>The contents of this field are subject to change.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("rollover")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycleRolloverConditions? Rollover { get; init; }
}