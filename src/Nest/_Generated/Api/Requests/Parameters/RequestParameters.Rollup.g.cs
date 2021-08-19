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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest.Rollup
{
	public class DeleteJobRequestParameters : RequestParameters<DeleteJobRequestParameters>
	{
	}

	public class GetJobsRequestParameters : RequestParameters<GetJobsRequestParameters>
	{
	}

	public class GetRollupCapsRequestParameters : RequestParameters<GetRollupCapsRequestParameters>
	{
	}

	public class GetRollupIndexCapsRequestParameters : RequestParameters<GetRollupIndexCapsRequestParameters>
	{
	}

	public class PutJobRequestParameters : RequestParameters<PutJobRequestParameters>
	{
	}

	public class RollupRequestParameters : RequestParameters<RollupRequestParameters>
	{
		[JsonIgnore]
		public int Stuba { get => Q<int>("stuba"); set => Q("stuba", value); }
	}

	public class RollupSearchRequestParameters : RequestParameters<RollupSearchRequestParameters>
	{
		[JsonIgnore]
		public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

		[JsonIgnore]
		public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }
	}

	public class StartJobRequestParameters : RequestParameters<StartJobRequestParameters>
	{
	}

	public class StopJobRequestParameters : RequestParameters<StopJobRequestParameters>
	{
		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	}
}