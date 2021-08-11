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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using Nest.Types.Cluster;
using Nest.Types.Core;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest
{
	public partial class ClusterAllocationExplainResponse : ResponseBase
	{
		[JsonPropertyName("allocate_explanation")]
		public string? AllocateExplanation
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("allocation_delay")]
		public string? AllocationDelay
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("allocation_delay_in_millis")]
		public long? AllocationDelayInMillis
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("can_allocate")]
		public Types.Cluster.Decision? CanAllocate
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("can_move_to_other_node")]
		public Types.Cluster.Decision? CanMoveToOtherNode
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("can_rebalance_cluster")]
		public Types.Cluster.Decision? CanRebalanceCluster
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("can_rebalance_cluster_decisions")]
		public IReadOnlyCollection<AllocationDecision>? CanRebalanceClusterDecisions
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("can_rebalance_to_other_node")]
		public Types.Cluster.Decision? CanRebalanceToOtherNode
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("can_remain_decisions")]
		public IReadOnlyCollection<AllocationDecision>? CanRemainDecisions
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("can_remain_on_current_node")]
		public Types.Cluster.Decision? CanRemainOnCurrentNode
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("cluster_info")]
		public Types.Cluster.ClusterInfo? ClusterInfo
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("configured_delay")]
		public string? ConfiguredDelay
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("configured_delay_in_millis")]
		public long? ConfiguredDelayInMillis
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("current_node")]
		public Types.Cluster.CurrentNode? CurrentNode
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("current_state")]
		public string CurrentState
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("index")]
		public Types.Core.IndexName Index
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("move_explanation")]
		public string? MoveExplanation
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("node_allocation_decisions")]
		public IReadOnlyCollection<NodeAllocationExplanation>? NodeAllocationDecisions
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("primary")]
		public bool Primary
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("rebalance_explanation")]
		public string? RebalanceExplanation
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("remaining_delay")]
		public string? RemainingDelay
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("remaining_delay_in_millis")]
		public long? RemainingDelayInMillis
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("shard")]
		public int Shard
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("unassigned_info")]
		public Types.Cluster.UnassignedInformation? UnassignedInfo
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterDeleteComponentTemplateResponse : AcknowledgedResponseBase
	{
	}

	public partial class ClusterDeleteVotingConfigExclusionsResponse : ResponseBase
	{
		[JsonPropertyName("stub")]
		public int Stub
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterGetComponentTemplateResponse : ResponseBase
	{
		[JsonPropertyName("component_templates")]
		public IReadOnlyCollection<ComponentTemplate> ComponentTemplates
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterGetSettingsResponse : ResponseBase
	{
		[JsonPropertyName("defaults")]
		public Dictionary<string, object>? Defaults
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("persistent")]
		public Dictionary<string, object> Persistent
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("transient")]
		public Dictionary<string, object> Transient
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterHealthResponse : ResponseBase
	{
		[JsonPropertyName("active_primary_shards")]
		public int ActivePrimaryShards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("active_shards")]
		public int ActiveShards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("active_shards_percent_as_number")]
		public Types.Core.Percentage ActiveShardsPercentAsNumber
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("cluster_name")]
		public string ClusterName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("delayed_unassigned_shards")]
		public int DelayedUnassignedShards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("indices")]
		public Dictionary<IndexName, IndexHealthStats>? Indices
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("initializing_shards")]
		public int InitializingShards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("number_of_data_nodes")]
		public int NumberOfDataNodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("number_of_in_flight_fetch")]
		public int NumberOfInFlightFetch
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("number_of_nodes")]
		public int NumberOfNodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("number_of_pending_tasks")]
		public int NumberOfPendingTasks
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("relocating_shards")]
		public int RelocatingShards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("status")]
		public Types.Core.Health Status
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("task_max_waiting_in_queue_millis")]
		public Types.Core.EpochMillis TaskMaxWaitingInQueueMillis
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("timed_out")]
		public bool TimedOut
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("unassigned_shards")]
		public int UnassignedShards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterPendingTasksResponse : ResponseBase
	{
		[JsonPropertyName("tasks")]
		public IReadOnlyCollection<PendingTask> Tasks
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterPutVotingConfigExclusionsResponse : ResponseBase
	{
		[JsonPropertyName("stub")]
		public int Stub
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterPutComponentTemplateResponse : AcknowledgedResponseBase
	{
	}

	public partial class ClusterPutSettingsResponse : ResponseBase
	{
		[JsonPropertyName("acknowledged")]
		public bool Acknowledged
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("persistent")]
		public Dictionary<string, object> Persistent
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("transient")]
		public Dictionary<string, object> Transient
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterRemoteInfoResponse : DictionaryResponseBase<string, ClusterRemoteInfo>
	{
	}

	public partial class ClusterRerouteResponse : AcknowledgedResponseBase
	{
		[JsonPropertyName("explanations")]
		public IReadOnlyCollection<RerouteExplanation>? Explanations
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("state")]
		public Types.Cluster.RerouteState State
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterStateResponse : ResponseBase
	{
		[JsonPropertyName("blocks")]
		public Types.Cluster.ClusterStateBlocks? Blocks
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("cluster_name")]
		public Types.Core.Name ClusterName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("cluster_uuid")]
		public Types.Core.Uuid ClusterUuid
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("master_node")]
		public string? MasterNode
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("metadata")]
		public Types.Cluster.ClusterStateMetadata? Metadata
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Dictionary<NodeName, NodeAttributes>? Nodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("routing_nodes")]
		public Types.Cluster.ClusterStateRoutingNodes? RoutingNodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("routing_table")]
		public Dictionary<string, EmptyObject>? RoutingTable
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("snapshot_deletions")]
		public Types.Cluster.ClusterStateDeletedSnapshots? SnapshotDeletions
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("snapshots")]
		public Types.Cluster.ClusterStateSnapshots? Snapshots
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("state")]
		public IReadOnlyCollection<string>? State
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("state_uuid")]
		public Types.Core.Uuid? StateUuid
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("version")]
		public Types.Core.VersionNumber? Version
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterStatsResponse : NodesResponseBase
	{
		[JsonPropertyName("cluster_name")]
		public Types.Core.Name ClusterName
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("cluster_uuid")]
		public Types.Core.Uuid ClusterUuid
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("indices")]
		public Types.Cluster.ClusterIndices Indices
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("nodes")]
		public Types.Cluster.ClusterNodes Nodes
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("status")]
		public Types.Cluster.ClusterStatus Status
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("timestamp")]
		public long Timestamp
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}
}