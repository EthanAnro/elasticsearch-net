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
using System.Collections.Generic;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Watcher
{
	public partial class AckWatchDescriptor : RequestDescriptorBase<AckWatchDescriptor, AckWatchRequestParameters, IAckWatchRequest>, IAckWatchRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherAckWatch;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/watch/{watch_id}/_ack</summary>
        public AckWatchDescriptor(Elastic.Clients.Elasticsearch.Name watch_id) : base(r => r.Required("watch_id", watch_id))
		{
		}

		///<summary>/_watcher/watch/{watch_id}/_ack/{action_id}</summary>
        public AckWatchDescriptor(Elastic.Clients.Elasticsearch.Name watch_id, Elastic.Clients.Elasticsearch.Names? action_id) : base(r => r.Required("watch_id", watch_id).Optional("action_id", action_id))
		{
		}
	}

	public partial class ActivateWatchDescriptor : RequestDescriptorBase<ActivateWatchDescriptor, ActivateWatchRequestParameters, IActivateWatchRequest>, IActivateWatchRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherActivateWatch;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/watch/{watch_id}/_activate</summary>
        public ActivateWatchDescriptor(Elastic.Clients.Elasticsearch.Name watch_id) : base(r => r.Required("watch_id", watch_id))
		{
		}
	}

	public partial class DeactivateWatchDescriptor : RequestDescriptorBase<DeactivateWatchDescriptor, DeactivateWatchRequestParameters, IDeactivateWatchRequest>, IDeactivateWatchRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherDeactivateWatch;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/watch/{watch_id}/_deactivate</summary>
        public DeactivateWatchDescriptor(Elastic.Clients.Elasticsearch.Name watch_id) : base(r => r.Required("watch_id", watch_id))
		{
		}
	}

	public partial class DeleteWatchDescriptor : RequestDescriptorBase<DeleteWatchDescriptor, DeleteWatchRequestParameters, IDeleteWatchRequest>, IDeleteWatchRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherDeleteWatch;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/watch/{id}</summary>
        public DeleteWatchDescriptor(Elastic.Clients.Elasticsearch.Name id) : base(r => r.Required("id", id))
		{
		}
	}

	public partial class ExecuteWatchDescriptor : RequestDescriptorBase<ExecuteWatchDescriptor, ExecuteWatchRequestParameters, IExecuteWatchRequest>, IExecuteWatchRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherExecuteWatch;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/watch/{id}/_execute</summary>
        public ExecuteWatchDescriptor(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
		{
		}

		///<summary>/_watcher/watch/_execute</summary>
        public ExecuteWatchDescriptor() : base()
		{
		}

		Dictionary<string, Elastic.Clients.Elasticsearch.Watcher.ActionExecutionMode>? IExecuteWatchRequest.ActionModes { get; set; }

		Dictionary<string, object>? IExecuteWatchRequest.AlternativeInput { get; set; }

		bool? IExecuteWatchRequest.IgnoreCondition { get; set; }

		bool? IExecuteWatchRequest.RecordExecution { get; set; }

		Elastic.Clients.Elasticsearch.Watcher.SimulatedActions? IExecuteWatchRequest.SimulatedActions { get; set; }

		Elastic.Clients.Elasticsearch.Watcher.ScheduleTriggerEvent? IExecuteWatchRequest.TriggerData { get; set; }

		Elastic.Clients.Elasticsearch.Watcher.Watch? IExecuteWatchRequest.Watch { get; set; }

		public ExecuteWatchDescriptor Debug(bool? debug = true) => Qs("debug", debug);
		public ExecuteWatchDescriptor ActionModes(Dictionary<string, Elastic.Clients.Elasticsearch.Watcher.ActionExecutionMode>? actionModes) => Assign(actionModes, (a, v) => a.ActionModes = v);
		public ExecuteWatchDescriptor AlternativeInput(Dictionary<string, object>? alternativeInput) => Assign(alternativeInput, (a, v) => a.AlternativeInput = v);
		public ExecuteWatchDescriptor IgnoreCondition(bool? ignoreCondition = true) => Assign(ignoreCondition, (a, v) => a.IgnoreCondition = v);
		public ExecuteWatchDescriptor RecordExecution(bool? recordExecution = true) => Assign(recordExecution, (a, v) => a.RecordExecution = v);
		public ExecuteWatchDescriptor SimulatedActions(Elastic.Clients.Elasticsearch.Watcher.SimulatedActions? simulatedActions) => Assign(simulatedActions, (a, v) => a.SimulatedActions = v);
		public ExecuteWatchDescriptor TriggerData(Elastic.Clients.Elasticsearch.Watcher.ScheduleTriggerEvent? triggerData) => Assign(triggerData, (a, v) => a.TriggerData = v);
		public ExecuteWatchDescriptor Watch(Elastic.Clients.Elasticsearch.Watcher.Watch? watch) => Assign(watch, (a, v) => a.Watch = v);
	}

	public partial class GetWatchDescriptor : RequestDescriptorBase<GetWatchDescriptor, GetWatchRequestParameters, IGetWatchRequest>, IGetWatchRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherGetWatch;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/watch/{id}</summary>
        public GetWatchDescriptor(Elastic.Clients.Elasticsearch.Name id) : base(r => r.Required("id", id))
		{
		}
	}

	public partial class PutWatchDescriptor : RequestDescriptorBase<PutWatchDescriptor, PutWatchRequestParameters, IPutWatchRequest>, IPutWatchRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherPutWatch;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/watch/{id}</summary>
        public PutWatchDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		Dictionary<string, Elastic.Clients.Elasticsearch.Watcher.Action>? IPutWatchRequest.Actions { get; set; }

		Elastic.Clients.Elasticsearch.Watcher.ConditionContainer? IPutWatchRequest.Condition { get; set; }

		Elastic.Clients.Elasticsearch.Watcher.InputContainer? IPutWatchRequest.Input { get; set; }

		Elastic.Clients.Elasticsearch.Metadata? IPutWatchRequest.Metadata { get; set; }

		string? IPutWatchRequest.ThrottlePeriod { get; set; }

		Elastic.Clients.Elasticsearch.TransformContainer? IPutWatchRequest.Transform { get; set; }

		Elastic.Clients.Elasticsearch.Watcher.TriggerContainer? IPutWatchRequest.Trigger { get; set; }

		public PutWatchDescriptor Active(bool? active = true) => Qs("active", active);
		public PutWatchDescriptor IfPrimaryTerm(long? ifPrimaryTerm) => Qs("if_primary_term", ifPrimaryTerm);
		public PutWatchDescriptor IfSequenceNumber(long? ifSequenceNumber) => Qs("if_sequence_number", ifSequenceNumber);
		public PutWatchDescriptor Version(Elastic.Clients.Elasticsearch.VersionNumber? version) => Qs("version", version);
		public PutWatchDescriptor Actions(Dictionary<string, Elastic.Clients.Elasticsearch.Watcher.Action>? actions) => Assign(actions, (a, v) => a.Actions = v);
		public PutWatchDescriptor Condition(Elastic.Clients.Elasticsearch.Watcher.ConditionContainer? condition) => Assign(condition, (a, v) => a.Condition = v);
		public PutWatchDescriptor Input(Elastic.Clients.Elasticsearch.Watcher.InputContainer? input) => Assign(input, (a, v) => a.Input = v);
		public PutWatchDescriptor Metadata(Elastic.Clients.Elasticsearch.Metadata? metadata) => Assign(metadata, (a, v) => a.Metadata = v);
		public PutWatchDescriptor ThrottlePeriod(string? throttlePeriod) => Assign(throttlePeriod, (a, v) => a.ThrottlePeriod = v);
		public PutWatchDescriptor Transform(Elastic.Clients.Elasticsearch.TransformContainer? transform) => Assign(transform, (a, v) => a.Transform = v);
		public PutWatchDescriptor Trigger(Elastic.Clients.Elasticsearch.Watcher.TriggerContainer? trigger) => Assign(trigger, (a, v) => a.Trigger = v);
	}

	public partial class QueryWatchesDescriptor : RequestDescriptorBase<QueryWatchesDescriptor, QueryWatchesRequestParameters, IQueryWatchesRequest>, IQueryWatchesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherQueryWatches;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/_query/watches</summary>
        public QueryWatchesDescriptor() : base()
		{
		}

		int? IQueryWatchesRequest.From { get; set; }

		int? IQueryWatchesRequest.Size { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.IQueryContainer? IQueryWatchesRequest.Query { get; set; }

		Elastic.Clients.Elasticsearch.Global.Search.Sort? IQueryWatchesRequest.Sort { get; set; }

		Elastic.Clients.Elasticsearch.Global.Search.SortResults? IQueryWatchesRequest.SearchAfter { get; set; }

		public QueryWatchesDescriptor From(int? from) => Assign(from, (a, v) => a.From = v);
		public QueryWatchesDescriptor Size(int? size) => Assign(size, (a, v) => a.Size = v);
		public QueryWatchesDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.IQueryContainer? query) => Assign(query, (a, v) => a.Query = v);
		public QueryWatchesDescriptor Sort(Elastic.Clients.Elasticsearch.Global.Search.Sort? sort) => Assign(sort, (a, v) => a.Sort = v);
		public QueryWatchesDescriptor SearchAfter(Elastic.Clients.Elasticsearch.Global.Search.SortResults? searchAfter) => Assign(searchAfter, (a, v) => a.SearchAfter = v);
	}

	public partial class StartDescriptor : RequestDescriptorBase<StartDescriptor, StartRequestParameters, IStartRequest>, IStartRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherStart;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/_start</summary>
        public StartDescriptor() : base()
		{
		}
	}

	public partial class StatsDescriptor : RequestDescriptorBase<StatsDescriptor, StatsRequestParameters, IStatsRequest>, IStatsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/stats</summary>
        public StatsDescriptor() : base()
		{
		}

		public StatsDescriptor EmitStacktraces(bool? emitStacktraces = true) => Qs("emit_stacktraces", emitStacktraces);
	}

	public partial class StopDescriptor : RequestDescriptorBase<StopDescriptor, StopRequestParameters, IStopRequest>, IStopRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherStop;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_watcher/_stop</summary>
        public StopDescriptor() : base()
		{
		}
	}
}