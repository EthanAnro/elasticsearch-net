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
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest.Watcher
{
	public class WatcherNamespace : NamespacedClientProxy
	{
		internal WatcherNamespace(ElasticClient client) : base(client)
		{
		}

		public AckWatchResponse AckWatch(IAckWatchRequest request)
		{
			return DoRequest<IAckWatchRequest, AckWatchResponse>(request, request.RequestParameters);
		}

		public Task<AckWatchResponse> AckWatchAsync(IAckWatchRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IAckWatchRequest, AckWatchResponse>(request, request.RequestParameters, cancellationToken);
		}

		public AckWatchResponse AckWatch(Nest.Name watch_id, Func<AckWatchDescriptor, IAckWatchRequest> selector = null)
		{
			return AckWatch(selector.InvokeOrDefault(new AckWatchDescriptor(watch_id)));
		}

		public Task<AckWatchResponse> AckWatchAsync(Nest.Name watch_id, Func<AckWatchDescriptor, IAckWatchRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return AckWatchAsync(selector.InvokeOrDefault(new AckWatchDescriptor(watch_id)), cancellationToken);
		}

		public ActivateWatchResponse ActivateWatch(IActivateWatchRequest request)
		{
			return DoRequest<IActivateWatchRequest, ActivateWatchResponse>(request, request.RequestParameters);
		}

		public Task<ActivateWatchResponse> ActivateWatchAsync(IActivateWatchRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IActivateWatchRequest, ActivateWatchResponse>(request, request.RequestParameters, cancellationToken);
		}

		public ActivateWatchResponse ActivateWatch(Nest.Name watch_id, Func<ActivateWatchDescriptor, IActivateWatchRequest> selector = null)
		{
			return ActivateWatch(selector.InvokeOrDefault(new ActivateWatchDescriptor(watch_id)));
		}

		public Task<ActivateWatchResponse> ActivateWatchAsync(Nest.Name watch_id, Func<ActivateWatchDescriptor, IActivateWatchRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return ActivateWatchAsync(selector.InvokeOrDefault(new ActivateWatchDescriptor(watch_id)), cancellationToken);
		}

		public DeactivateWatchResponse DeactivateWatch(IDeactivateWatchRequest request)
		{
			return DoRequest<IDeactivateWatchRequest, DeactivateWatchResponse>(request, request.RequestParameters);
		}

		public Task<DeactivateWatchResponse> DeactivateWatchAsync(IDeactivateWatchRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IDeactivateWatchRequest, DeactivateWatchResponse>(request, request.RequestParameters, cancellationToken);
		}

		public DeactivateWatchResponse DeactivateWatch(Nest.Name watch_id, Func<DeactivateWatchDescriptor, IDeactivateWatchRequest> selector = null)
		{
			return DeactivateWatch(selector.InvokeOrDefault(new DeactivateWatchDescriptor(watch_id)));
		}

		public Task<DeactivateWatchResponse> DeactivateWatchAsync(Nest.Name watch_id, Func<DeactivateWatchDescriptor, IDeactivateWatchRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return DeactivateWatchAsync(selector.InvokeOrDefault(new DeactivateWatchDescriptor(watch_id)), cancellationToken);
		}

		public DeleteWatchResponse DeleteWatch(IDeleteWatchRequest request)
		{
			return DoRequest<IDeleteWatchRequest, DeleteWatchResponse>(request, request.RequestParameters);
		}

		public Task<DeleteWatchResponse> DeleteWatchAsync(IDeleteWatchRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IDeleteWatchRequest, DeleteWatchResponse>(request, request.RequestParameters, cancellationToken);
		}

		public DeleteWatchResponse DeleteWatch(Nest.Name id, Func<DeleteWatchDescriptor, IDeleteWatchRequest> selector = null)
		{
			return DeleteWatch(selector.InvokeOrDefault(new DeleteWatchDescriptor(id)));
		}

		public Task<DeleteWatchResponse> DeleteWatchAsync(Nest.Name id, Func<DeleteWatchDescriptor, IDeleteWatchRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return DeleteWatchAsync(selector.InvokeOrDefault(new DeleteWatchDescriptor(id)), cancellationToken);
		}

		public ExecuteWatchResponse ExecuteWatch(IExecuteWatchRequest request)
		{
			return DoRequest<IExecuteWatchRequest, ExecuteWatchResponse>(request, request.RequestParameters);
		}

		public Task<ExecuteWatchResponse> ExecuteWatchAsync(IExecuteWatchRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IExecuteWatchRequest, ExecuteWatchResponse>(request, request.RequestParameters, cancellationToken);
		}

		public ExecuteWatchResponse ExecuteWatch(Func<ExecuteWatchDescriptor, IExecuteWatchRequest> selector = null)
		{
			return ExecuteWatch(selector.InvokeOrDefault(new ExecuteWatchDescriptor()));
		}

		public Task<ExecuteWatchResponse> ExecuteWatchAsync(Func<ExecuteWatchDescriptor, IExecuteWatchRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return ExecuteWatchAsync(selector.InvokeOrDefault(new ExecuteWatchDescriptor()), cancellationToken);
		}

		public GetWatchResponse GetWatch(IGetWatchRequest request)
		{
			return DoRequest<IGetWatchRequest, GetWatchResponse>(request, request.RequestParameters);
		}

		public Task<GetWatchResponse> GetWatchAsync(IGetWatchRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IGetWatchRequest, GetWatchResponse>(request, request.RequestParameters, cancellationToken);
		}

		public GetWatchResponse GetWatch(Nest.Name id, Func<GetWatchDescriptor, IGetWatchRequest> selector = null)
		{
			return GetWatch(selector.InvokeOrDefault(new GetWatchDescriptor(id)));
		}

		public Task<GetWatchResponse> GetWatchAsync(Nest.Name id, Func<GetWatchDescriptor, IGetWatchRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return GetWatchAsync(selector.InvokeOrDefault(new GetWatchDescriptor(id)), cancellationToken);
		}

		public PutWatchResponse PutWatch(IPutWatchRequest request)
		{
			return DoRequest<IPutWatchRequest, PutWatchResponse>(request, request.RequestParameters);
		}

		public Task<PutWatchResponse> PutWatchAsync(IPutWatchRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IPutWatchRequest, PutWatchResponse>(request, request.RequestParameters, cancellationToken);
		}

		public PutWatchResponse PutWatch(Nest.Id id, Func<PutWatchDescriptor, IPutWatchRequest> selector = null)
		{
			return PutWatch(selector.InvokeOrDefault(new PutWatchDescriptor(id)));
		}

		public Task<PutWatchResponse> PutWatchAsync(Nest.Id id, Func<PutWatchDescriptor, IPutWatchRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return PutWatchAsync(selector.InvokeOrDefault(new PutWatchDescriptor(id)), cancellationToken);
		}

		public StartResponse Start(IStartRequest request)
		{
			return DoRequest<IStartRequest, StartResponse>(request, request.RequestParameters);
		}

		public Task<StartResponse> StartAsync(IStartRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IStartRequest, StartResponse>(request, request.RequestParameters, cancellationToken);
		}

		public StartResponse Start(Func<StartDescriptor, IStartRequest> selector = null)
		{
			return Start(selector.InvokeOrDefault(new StartDescriptor()));
		}

		public Task<StartResponse> StartAsync(Func<StartDescriptor, IStartRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return StartAsync(selector.InvokeOrDefault(new StartDescriptor()), cancellationToken);
		}

		public StatsResponse Stats(IStatsRequest request)
		{
			return DoRequest<IStatsRequest, StatsResponse>(request, request.RequestParameters);
		}

		public Task<StatsResponse> StatsAsync(IStatsRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IStatsRequest, StatsResponse>(request, request.RequestParameters, cancellationToken);
		}

		public StatsResponse Stats(Func<StatsDescriptor, IStatsRequest> selector = null)
		{
			return Stats(selector.InvokeOrDefault(new StatsDescriptor()));
		}

		public Task<StatsResponse> StatsAsync(Func<StatsDescriptor, IStatsRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return StatsAsync(selector.InvokeOrDefault(new StatsDescriptor()), cancellationToken);
		}

		public StopResponse Stop(IStopRequest request)
		{
			return DoRequest<IStopRequest, StopResponse>(request, request.RequestParameters);
		}

		public Task<StopResponse> StopAsync(IStopRequest request, CancellationToken cancellationToken = default)
		{
			return DoRequestAsync<IStopRequest, StopResponse>(request, request.RequestParameters, cancellationToken);
		}

		public StopResponse Stop(Func<StopDescriptor, IStopRequest> selector = null)
		{
			return Stop(selector.InvokeOrDefault(new StopDescriptor()));
		}

		public Task<StopResponse> StopAsync(Func<StopDescriptor, IStopRequest> selector = null, CancellationToken cancellationToken = default)
		{
			return StopAsync(selector.InvokeOrDefault(new StopDescriptor()), cancellationToken);
		}
	}
}