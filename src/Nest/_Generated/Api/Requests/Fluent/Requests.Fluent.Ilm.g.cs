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

#nullable restore
namespace Nest.Ilm
{
	public partial class DeleteLifecycleDescriptor : RequestDescriptorBase<DeleteLifecycleDescriptor, DeleteLifecycleRequestParameters, IDeleteLifecycleRequest>, IDeleteLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementDeleteLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_ilm/policy/{policy}</summary>
        public DeleteLifecycleDescriptor(Nest.Name? policy) : base(r => r.Optional("policy", policy))
		{
		}
	}

	public partial class ExplainLifecycleDescriptor : RequestDescriptorBase<ExplainLifecycleDescriptor, ExplainLifecycleRequestParameters, IExplainLifecycleRequest>, IExplainLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementExplainLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_ilm/explain</summary>
        public ExplainLifecycleDescriptor(Nest.IndexName index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class GetLifecycleDescriptor : RequestDescriptorBase<GetLifecycleDescriptor, GetLifecycleRequestParameters, IGetLifecycleRequest>, IGetLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementGetLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_ilm/policy/{policy}</summary>
        public GetLifecycleDescriptor(Nest.Name? policy) : base(r => r.Optional("policy", policy))
		{
		}

		///<summary>/_ilm/policy</summary>
        public GetLifecycleDescriptor() : base()
		{
		}
	}

	public partial class GetStatusDescriptor : RequestDescriptorBase<GetStatusDescriptor, GetStatusRequestParameters, IGetStatusRequest>, IGetStatusRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementGetStatus;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_ilm/status</summary>
        public GetStatusDescriptor() : base()
		{
		}
	}

	public partial class MoveToStepDescriptor : RequestDescriptorBase<MoveToStepDescriptor, MoveToStepRequestParameters, IMoveToStepRequest>, IMoveToStepRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementMoveToStep;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_ilm/move/{index}</summary>
        public MoveToStepDescriptor(Nest.IndexName index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class PutLifecycleDescriptor : RequestDescriptorBase<PutLifecycleDescriptor, PutLifecycleRequestParameters, IPutLifecycleRequest>, IPutLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementPutLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_ilm/policy/{policy}</summary>
        public PutLifecycleDescriptor(Nest.Name? policy) : base(r => r.Optional("policy", policy))
		{
		}
	}

	public partial class RemovePolicyDescriptor : RequestDescriptorBase<RemovePolicyDescriptor, RemovePolicyRequestParameters, IRemovePolicyRequest>, IRemovePolicyRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementRemovePolicy;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_ilm/remove</summary>
        public RemovePolicyDescriptor(Nest.IndexName index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class RetryDescriptor : RequestDescriptorBase<RetryDescriptor, RetryRequestParameters, IRetryRequest>, IRetryRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementRetry;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_ilm/retry</summary>
        public RetryDescriptor(Nest.IndexName index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class StartDescriptor : RequestDescriptorBase<StartDescriptor, StartRequestParameters, IStartRequest>, IStartRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementStart;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_ilm/start</summary>
        public StartDescriptor() : base()
		{
		}
	}

	public partial class StopDescriptor : RequestDescriptorBase<StopDescriptor, StopRequestParameters, IStopRequest>, IStopRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementStop;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_ilm/stop</summary>
        public StopDescriptor() : base()
		{
		}
	}
}