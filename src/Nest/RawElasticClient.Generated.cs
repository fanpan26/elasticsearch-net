using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Generated File Please Do Not Edit Manually
	
namespace Nest
{
	///<summary>
	///Raw operations with elasticsearch
	///</summary>
	public partial class RawElasticClient : IRawElasticClient
	{
		///<summary>POST /_bulk
	    ///<pre>http://elasticsearch.org/guide/reference/api/bulk/</pre>	
	    ///</summary>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		public ConnectionStatus BulkPost(object body, Func<BulkPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_bulk".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new BulkPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /_bulk
	    ///<pre>http://elasticsearch.org/guide/reference/api/bulk/</pre>	
	    ///</summary>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		public Task<ConnectionStatus> BulkPostAsync(object body, Func<BulkPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_bulk".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new BulkPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/_bulk
	    ///<pre>http://elasticsearch.org/guide/reference/api/bulk/</pre>	
	    ///</summary>
		///<param name="index">Default index for items which don&#39;t provide one</param>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		public ConnectionStatus BulkPost(string index, object body, Func<BulkPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_bulk".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new BulkPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/_bulk
	    ///<pre>http://elasticsearch.org/guide/reference/api/bulk/</pre>	
	    ///</summary>
		///<param name="index">Default index for items which don&#39;t provide one</param>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		public Task<ConnectionStatus> BulkPostAsync(string index, object body, Func<BulkPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_bulk".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new BulkPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/_bulk
	    ///<pre>http://elasticsearch.org/guide/reference/api/bulk/</pre>	
	    ///</summary>
		///<param name="index">Default index for items which don&#39;t provide one</param>
		///<param name="type">Default document type for items which don&#39;t provide one</param>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		public ConnectionStatus BulkPost(string index, string type, object body, Func<BulkPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_bulk".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new BulkPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/_bulk
	    ///<pre>http://elasticsearch.org/guide/reference/api/bulk/</pre>	
	    ///</summary>
		///<param name="index">Default index for items which don&#39;t provide one</param>
		///<param name="type">Default document type for items which don&#39;t provide one</param>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		public Task<ConnectionStatus> BulkPostAsync(string index, string type, object body, Func<BulkPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_bulk".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new BulkPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>PUT /_bulk
	    ///<pre>http://elasticsearch.org/guide/reference/api/bulk/</pre>	
	    ///</summary>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		public ConnectionStatus BulkPut(object body, Func<BulkPutQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_bulk".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new BulkPutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /_bulk
	    ///<pre>http://elasticsearch.org/guide/reference/api/bulk/</pre>	
	    ///</summary>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		public Task<ConnectionStatus> BulkPutAsync(object body, Func<BulkPutQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_bulk".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new BulkPutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/_bulk
	    ///<pre>http://elasticsearch.org/guide/reference/api/bulk/</pre>	
	    ///</summary>
		///<param name="index">Default index for items which don&#39;t provide one</param>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		public ConnectionStatus BulkPut(string index, object body, Func<BulkPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_bulk".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new BulkPutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/_bulk
	    ///<pre>http://elasticsearch.org/guide/reference/api/bulk/</pre>	
	    ///</summary>
		///<param name="index">Default index for items which don&#39;t provide one</param>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		public Task<ConnectionStatus> BulkPutAsync(string index, object body, Func<BulkPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_bulk".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new BulkPutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/{type}/_bulk
	    ///<pre>http://elasticsearch.org/guide/reference/api/bulk/</pre>	
	    ///</summary>
		///<param name="index">Default index for items which don&#39;t provide one</param>
		///<param name="type">Default document type for items which don&#39;t provide one</param>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		public ConnectionStatus BulkPut(string index, string type, object body, Func<BulkPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_bulk".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new BulkPutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/{type}/_bulk
	    ///<pre>http://elasticsearch.org/guide/reference/api/bulk/</pre>	
	    ///</summary>
		///<param name="index">Default index for items which don&#39;t provide one</param>
		///<param name="type">Default document type for items which don&#39;t provide one</param>
		///<param name="body">The operation definition and data (action-data pairs), separated by newlines</param>
		public Task<ConnectionStatus> BulkPutAsync(string index, string type, object body, Func<BulkPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_bulk".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new BulkPutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>DELETE /_search/scroll/{scroll_id}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/scroll/</pre>	
	    ///</summary>
		///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
		public ConnectionStatus ClearScrollDelete(string scroll_id, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			scroll_id.ThrowIfNull("scroll_id");
			var url = "/_search/scroll/{scroll_id}".Inject(new { scroll_id = scroll_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequest("DELETE", url, nv);
		}
		
		///<summary>DELETE /_search/scroll/{scroll_id}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/scroll/</pre>	
	    ///</summary>
		///<param name="scroll_id">A comma-separated list of scroll IDs to clear</param>
		public Task<ConnectionStatus> ClearScrollDeleteAsync(string scroll_id, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			scroll_id.ThrowIfNull("scroll_id");
			var url = "/_search/scroll/{scroll_id}".Inject(new { scroll_id = scroll_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequestAsync("DELETE", url, nv);
		}
		
		///<summary>GET /_cluster/settings
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-update-settings/</pre>	
	    ///</summary>
		public ConnectionStatus ClusterGetSettingsGet(Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cluster/settings";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_cluster/settings
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-update-settings/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> ClusterGetSettingsGetAsync(Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cluster/settings";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_cluster/health
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-health/</pre>	
	    ///</summary>
		public ConnectionStatus ClusterHealthGet(Func<ClusterHealthGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cluster/health";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterHealthGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_cluster/health
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-health/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> ClusterHealthGetAsync(Func<ClusterHealthGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cluster/health";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterHealthGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_cluster/health/{index}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-health/</pre>	
	    ///</summary>
		///<param name="index">Limit the information returned to a specific index</param>
		public ConnectionStatus ClusterHealthGet(string index, Func<ClusterHealthGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/_cluster/health/{index}".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterHealthGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_cluster/health/{index}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-health/</pre>	
	    ///</summary>
		///<param name="index">Limit the information returned to a specific index</param>
		public Task<ConnectionStatus> ClusterHealthGetAsync(string index, Func<ClusterHealthGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/_cluster/health/{index}".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterHealthGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_cluster/nodes/hotthreads
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-cluster-nodes-hot-threads/</pre>	
	    ///</summary>
		public ConnectionStatus ClusterNodeHotThreadsGet(Func<ClusterNodeHotThreadsGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cluster/nodes/hotthreads";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeHotThreadsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_cluster/nodes/hotthreads
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-cluster-nodes-hot-threads/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> ClusterNodeHotThreadsGetAsync(Func<ClusterNodeHotThreadsGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cluster/nodes/hotthreads";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeHotThreadsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_cluster/nodes/{node_id}/hotthreads
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-cluster-nodes-hot-threads/</pre>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		public ConnectionStatus ClusterNodeHotThreadsGet(string node_id, Func<ClusterNodeHotThreadsGetQueryString, NameValueCollection> queryString = null)
		{
			node_id.ThrowIfNull("node_id");
			var url = "/_cluster/nodes/{node_id}/hotthreads".Inject(new { node_id = node_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeHotThreadsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_cluster/nodes/{node_id}/hotthreads
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-cluster-nodes-hot-threads/</pre>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		public Task<ConnectionStatus> ClusterNodeHotThreadsGetAsync(string node_id, Func<ClusterNodeHotThreadsGetQueryString, NameValueCollection> queryString = null)
		{
			node_id.ThrowIfNull("node_id");
			var url = "/_cluster/nodes/{node_id}/hotthreads".Inject(new { node_id = node_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeHotThreadsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_cluster/nodes
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-info/</pre>	
	    ///</summary>
		public ConnectionStatus ClusterNodeInfoGet(Func<ClusterNodeInfoGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cluster/nodes";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeInfoGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_cluster/nodes
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-info/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> ClusterNodeInfoGetAsync(Func<ClusterNodeInfoGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cluster/nodes";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeInfoGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_cluster/nodes/{node_id}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-info/</pre>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		public ConnectionStatus ClusterNodeInfoGet(string node_id, Func<ClusterNodeInfoGetQueryString, NameValueCollection> queryString = null)
		{
			node_id.ThrowIfNull("node_id");
			var url = "/_cluster/nodes/{node_id}".Inject(new { node_id = node_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeInfoGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_cluster/nodes/{node_id}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-info/</pre>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		public Task<ConnectionStatus> ClusterNodeInfoGetAsync(string node_id, Func<ClusterNodeInfoGetQueryString, NameValueCollection> queryString = null)
		{
			node_id.ThrowIfNull("node_id");
			var url = "/_cluster/nodes/{node_id}".Inject(new { node_id = node_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeInfoGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>POST /_shutdown
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-shutdown/</pre>	
	    ///</summary>
		public ConnectionStatus ClusterNodeShutdownPost(Func<ClusterNodeShutdownPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_shutdown";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeShutdownPostQueryString());

			return this.DoRequest("POST", url, nv);
		}
		
		///<summary>POST /_shutdown
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-shutdown/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> ClusterNodeShutdownPostAsync(Func<ClusterNodeShutdownPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_shutdown";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeShutdownPostQueryString());

			return this.DoRequestAsync("POST", url, nv);
		}
		
		///<summary>POST /_cluster/nodes/{node_id}/_shutdown
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-shutdown/</pre>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to perform the operation on; use `_local` to perform the operation on the node you&#39;re connected to, leave empty to perform the operation on all nodes</param>
		public ConnectionStatus ClusterNodeShutdownPost(string node_id, Func<ClusterNodeShutdownPostQueryString, NameValueCollection> queryString = null)
		{
			node_id.ThrowIfNull("node_id");
			var url = "/_cluster/nodes/{node_id}/_shutdown".Inject(new { node_id = node_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeShutdownPostQueryString());

			return this.DoRequest("POST", url, nv);
		}
		
		///<summary>POST /_cluster/nodes/{node_id}/_shutdown
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-shutdown/</pre>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to perform the operation on; use `_local` to perform the operation on the node you&#39;re connected to, leave empty to perform the operation on all nodes</param>
		public Task<ConnectionStatus> ClusterNodeShutdownPostAsync(string node_id, Func<ClusterNodeShutdownPostQueryString, NameValueCollection> queryString = null)
		{
			node_id.ThrowIfNull("node_id");
			var url = "/_cluster/nodes/{node_id}/_shutdown".Inject(new { node_id = node_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeShutdownPostQueryString());

			return this.DoRequestAsync("POST", url, nv);
		}
		
		///<summary>GET /_cluster/nodes/stats
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-stats/</pre>	
	    ///</summary>
		public ConnectionStatus ClusterNodeStatsGet(Func<ClusterNodeStatsGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cluster/nodes/stats";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeStatsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_cluster/nodes/stats
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-stats/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> ClusterNodeStatsGetAsync(Func<ClusterNodeStatsGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cluster/nodes/stats";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeStatsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_cluster/nodes/{node_id}/stats
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-stats/</pre>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		public ConnectionStatus ClusterNodeStatsGet(string node_id, Func<ClusterNodeStatsGetQueryString, NameValueCollection> queryString = null)
		{
			node_id.ThrowIfNull("node_id");
			var url = "/_cluster/nodes/{node_id}/stats".Inject(new { node_id = node_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeStatsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_cluster/nodes/{node_id}/stats
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-stats/</pre>	
	    ///</summary>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		public Task<ConnectionStatus> ClusterNodeStatsGetAsync(string node_id, Func<ClusterNodeStatsGetQueryString, NameValueCollection> queryString = null)
		{
			node_id.ThrowIfNull("node_id");
			var url = "/_cluster/nodes/{node_id}/stats".Inject(new { node_id = node_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeStatsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_nodes/stats/{metric_family}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-stats/</pre>	
	    ///</summary>
		///<param name="metric_family">Limit the information returned to a certain metric family</param>
		public ConnectionStatus ClusterNodeStatsGet(MetricFamilyOptions metric_family, Func<ClusterNodeStatsGetQueryString, NameValueCollection> queryString = null)
		{
			metric_family.ThrowIfNull("metric_family");
			var url = "/_nodes/stats/{metric_family}".Inject(new { metric_family = metric_family });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeStatsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_nodes/stats/{metric_family}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-stats/</pre>	
	    ///</summary>
		///<param name="metric_family">Limit the information returned to a certain metric family</param>
		public Task<ConnectionStatus> ClusterNodeStatsGetAsync(MetricFamilyOptions metric_family, Func<ClusterNodeStatsGetQueryString, NameValueCollection> queryString = null)
		{
			metric_family.ThrowIfNull("metric_family");
			var url = "/_nodes/stats/{metric_family}".Inject(new { metric_family = metric_family });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeStatsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_nodes/{node_id}/stats/{metric_family}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-stats/</pre>	
	    ///</summary>
		///<param name="metric_family">Limit the information returned to a certain metric family</param>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		public ConnectionStatus ClusterNodeStatsGet(MetricFamilyOptions metric_family, string node_id, Func<ClusterNodeStatsGetQueryString, NameValueCollection> queryString = null)
		{
			metric_family.ThrowIfNull("metric_family");
			node_id.ThrowIfNull("node_id");
			var url = "/_nodes/{node_id}/stats/{metric_family}".Inject(new { metric_family = metric_family, node_id = node_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeStatsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_nodes/{node_id}/stats/{metric_family}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-stats/</pre>	
	    ///</summary>
		///<param name="metric_family">Limit the information returned to a certain metric family</param>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		public Task<ConnectionStatus> ClusterNodeStatsGetAsync(MetricFamilyOptions metric_family, string node_id, Func<ClusterNodeStatsGetQueryString, NameValueCollection> queryString = null)
		{
			metric_family.ThrowIfNull("metric_family");
			node_id.ThrowIfNull("node_id");
			var url = "/_nodes/{node_id}/stats/{metric_family}".Inject(new { metric_family = metric_family, node_id = node_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeStatsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_nodes/stats/indices/{metric}/{fields}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-stats/</pre>	
	    ///</summary>
		///<param name="fields">A comma-separated list of fields to return detailed information for, when returning the `indices` metric family (supports wildcards)</param>
		///<param name="metric">Limit the information returned for `indices` family to a specific metric</param>
		public ConnectionStatus ClusterNodeStatsGet(string fields, MetricOptions metric, Func<ClusterNodeStatsGetQueryString, NameValueCollection> queryString = null)
		{
			fields.ThrowIfNull("fields");
			metric.ThrowIfNull("metric");
			var url = "/_nodes/stats/indices/{metric}/{fields}".Inject(new { fields = fields, metric = metric });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeStatsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_nodes/stats/indices/{metric}/{fields}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-stats/</pre>	
	    ///</summary>
		///<param name="fields">A comma-separated list of fields to return detailed information for, when returning the `indices` metric family (supports wildcards)</param>
		///<param name="metric">Limit the information returned for `indices` family to a specific metric</param>
		public Task<ConnectionStatus> ClusterNodeStatsGetAsync(string fields, MetricOptions metric, Func<ClusterNodeStatsGetQueryString, NameValueCollection> queryString = null)
		{
			fields.ThrowIfNull("fields");
			metric.ThrowIfNull("metric");
			var url = "/_nodes/stats/indices/{metric}/{fields}".Inject(new { fields = fields, metric = metric });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeStatsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_nodes/{node_id}/stats/indices/{metric}/{fields}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-stats/</pre>	
	    ///</summary>
		///<param name="fields">A comma-separated list of fields to return detailed information for, when returning the `indices` metric family (supports wildcards)</param>
		///<param name="metric">Limit the information returned for `indices` family to a specific metric</param>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		public ConnectionStatus ClusterNodeStatsGet(string fields, MetricOptions metric, string node_id, Func<ClusterNodeStatsGetQueryString, NameValueCollection> queryString = null)
		{
			fields.ThrowIfNull("fields");
			metric.ThrowIfNull("metric");
			node_id.ThrowIfNull("node_id");
			var url = "/_nodes/{node_id}/stats/indices/{metric}/{fields}".Inject(new { fields = fields, metric = metric, node_id = node_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeStatsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_nodes/{node_id}/stats/indices/{metric}/{fields}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-nodes-stats/</pre>	
	    ///</summary>
		///<param name="fields">A comma-separated list of fields to return detailed information for, when returning the `indices` metric family (supports wildcards)</param>
		///<param name="metric">Limit the information returned for `indices` family to a specific metric</param>
		///<param name="node_id">A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you&#39;re connecting to, leave empty to get information from all nodes</param>
		public Task<ConnectionStatus> ClusterNodeStatsGetAsync(string fields, MetricOptions metric, string node_id, Func<ClusterNodeStatsGetQueryString, NameValueCollection> queryString = null)
		{
			fields.ThrowIfNull("fields");
			metric.ThrowIfNull("metric");
			node_id.ThrowIfNull("node_id");
			var url = "/_nodes/{node_id}/stats/indices/{metric}/{fields}".Inject(new { fields = fields, metric = metric, node_id = node_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterNodeStatsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>PUT /_cluster/settings
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-update-settings/</pre>	
	    ///</summary>
		///<param name="body">The settings to be updated. Can be either `transient` or `persistent` (survives cluster restart).</param>
		public ConnectionStatus ClusterPutSettingsPut(object body, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cluster/settings".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /_cluster/settings
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-update-settings/</pre>	
	    ///</summary>
		///<param name="body">The settings to be updated. Can be either `transient` or `persistent` (survives cluster restart).</param>
		public Task<ConnectionStatus> ClusterPutSettingsPutAsync(object body, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cluster/settings".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>POST /_cluster/reroute
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-reroute/</pre>	
	    ///</summary>
		///<param name="body">The definition of `commands` to perform (`move`, `cancel`, `allocate`)</param>
		public ConnectionStatus ClusterReroutePost(object body, Func<ClusterReroutePostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cluster/reroute".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterReroutePostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /_cluster/reroute
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-reroute/</pre>	
	    ///</summary>
		///<param name="body">The definition of `commands` to perform (`move`, `cancel`, `allocate`)</param>
		public Task<ConnectionStatus> ClusterReroutePostAsync(object body, Func<ClusterReroutePostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cluster/reroute".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterReroutePostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>GET /_cluster/state
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-state/</pre>	
	    ///</summary>
		public ConnectionStatus ClusterStateGet(Func<ClusterStateGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cluster/state";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterStateGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_cluster/state
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-cluster-state/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> ClusterStateGetAsync(Func<ClusterStateGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cluster/state";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ClusterStateGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>POST /_count
	    ///<pre>http://elasticsearch.org/guide/reference/api/count/</pre>	
	    ///</summary>
		///<param name="body">A query to restrict the results (optional)</param>
		public ConnectionStatus CountPost(object body, Func<CountPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_count".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CountPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /_count
	    ///<pre>http://elasticsearch.org/guide/reference/api/count/</pre>	
	    ///</summary>
		///<param name="body">A query to restrict the results (optional)</param>
		public Task<ConnectionStatus> CountPostAsync(object body, Func<CountPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_count".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CountPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/_count
	    ///<pre>http://elasticsearch.org/guide/reference/api/count/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="body">A query to restrict the results (optional)</param>
		public ConnectionStatus CountPost(string index, object body, Func<CountPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_count".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CountPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/_count
	    ///<pre>http://elasticsearch.org/guide/reference/api/count/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="body">A query to restrict the results (optional)</param>
		public Task<ConnectionStatus> CountPostAsync(string index, object body, Func<CountPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_count".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CountPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/_count
	    ///<pre>http://elasticsearch.org/guide/reference/api/count/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="type">A comma-separated list of types to restrict the results</param>
		///<param name="body">A query to restrict the results (optional)</param>
		public ConnectionStatus CountPost(string index, string type, object body, Func<CountPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_count".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CountPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/_count
	    ///<pre>http://elasticsearch.org/guide/reference/api/count/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="type">A comma-separated list of types to restrict the results</param>
		///<param name="body">A query to restrict the results (optional)</param>
		public Task<ConnectionStatus> CountPostAsync(string index, string type, object body, Func<CountPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_count".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CountPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>GET /_count
	    ///<pre>http://elasticsearch.org/guide/reference/api/count/</pre>	
	    ///</summary>
		///<param name="body">A query to restrict the results (optional)</param>
		public ConnectionStatus CountGet(object body, Func<CountGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_count".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CountGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /_count
	    ///<pre>http://elasticsearch.org/guide/reference/api/count/</pre>	
	    ///</summary>
		///<param name="body">A query to restrict the results (optional)</param>
		public Task<ConnectionStatus> CountGetAsync(object body, Func<CountGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_count".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CountGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/_count
	    ///<pre>http://elasticsearch.org/guide/reference/api/count/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="body">A query to restrict the results (optional)</param>
		public ConnectionStatus CountGet(string index, object body, Func<CountGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_count".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CountGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/_count
	    ///<pre>http://elasticsearch.org/guide/reference/api/count/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="body">A query to restrict the results (optional)</param>
		public Task<ConnectionStatus> CountGetAsync(string index, object body, Func<CountGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_count".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CountGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/{type}/_count
	    ///<pre>http://elasticsearch.org/guide/reference/api/count/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="type">A comma-separated list of types to restrict the results</param>
		///<param name="body">A query to restrict the results (optional)</param>
		public ConnectionStatus CountGet(string index, string type, object body, Func<CountGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_count".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CountGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/{type}/_count
	    ///<pre>http://elasticsearch.org/guide/reference/api/count/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the results</param>
		///<param name="type">A comma-separated list of types to restrict the results</param>
		///<param name="body">A query to restrict the results (optional)</param>
		public Task<ConnectionStatus> CountGetAsync(string index, string type, object body, Func<CountGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_count".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CountGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}
	    ///<pre>http://elasticsearch.org/guide/reference/api/index_/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		public ConnectionStatus CreatePost(string index, string type, object body, Func<CreatePostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CreatePostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}
	    ///<pre>http://elasticsearch.org/guide/reference/api/index_/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		public Task<ConnectionStatus> CreatePostAsync(string index, string type, object body, Func<CreatePostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CreatePostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/{id}/_create
	    ///<pre>http://elasticsearch.org/guide/reference/api/index_/</pre>	
	    ///</summary>
		///<param name="id">Document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		public ConnectionStatus CreatePost(string id, string index, string type, object body, Func<CreatePostQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}/_create".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CreatePostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/{id}/_create
	    ///<pre>http://elasticsearch.org/guide/reference/api/index_/</pre>	
	    ///</summary>
		///<param name="id">Document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		public Task<ConnectionStatus> CreatePostAsync(string id, string index, string type, object body, Func<CreatePostQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}/_create".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CreatePostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>PUT /{index}/{type}
	    ///<pre>http://elasticsearch.org/guide/reference/api/index_/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		public ConnectionStatus CreatePut(string index, string type, object body, Func<CreatePutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CreatePutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/{type}
	    ///<pre>http://elasticsearch.org/guide/reference/api/index_/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		public Task<ConnectionStatus> CreatePutAsync(string index, string type, object body, Func<CreatePutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CreatePutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/{type}/{id}/_create
	    ///<pre>http://elasticsearch.org/guide/reference/api/index_/</pre>	
	    ///</summary>
		///<param name="id">Document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		public ConnectionStatus CreatePut(string id, string index, string type, object body, Func<CreatePutQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}/_create".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CreatePutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/{type}/{id}/_create
	    ///<pre>http://elasticsearch.org/guide/reference/api/index_/</pre>	
	    ///</summary>
		///<param name="id">Document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		public Task<ConnectionStatus> CreatePutAsync(string id, string index, string type, object body, Func<CreatePutQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}/_create".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new CreatePutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>DELETE /{index}/{type}/{id}
	    ///<pre>http://elasticsearch.org/guide/reference/api/delete/</pre>	
	    ///</summary>
		///<param name="id">The document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		public ConnectionStatus DeleteDelete(string id, string index, string type, Func<DeleteDeleteQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new DeleteDeleteQueryString());

			return this.DoRequest("DELETE", url, nv);
		}
		
		///<summary>DELETE /{index}/{type}/{id}
	    ///<pre>http://elasticsearch.org/guide/reference/api/delete/</pre>	
	    ///</summary>
		///<param name="id">The document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		public Task<ConnectionStatus> DeleteDeleteAsync(string id, string index, string type, Func<DeleteDeleteQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new DeleteDeleteQueryString());

			return this.DoRequestAsync("DELETE", url, nv);
		}
		
		///<summary>DELETE /{index}/_query
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/delete-by-query/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="body">A query to restrict the operation</param>
		public ConnectionStatus DeleteByQueryDelete(string index, object body, Func<DeleteByQueryDeleteQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_query".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new DeleteByQueryDeleteQueryString());

			return this.DoRequest("DELETE", url, body, nv);
		}
		
		///<summary>DELETE /{index}/_query
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/delete-by-query/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="body">A query to restrict the operation</param>
		public Task<ConnectionStatus> DeleteByQueryDeleteAsync(string index, object body, Func<DeleteByQueryDeleteQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_query".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new DeleteByQueryDeleteQueryString());

			return this.DoRequestAsync("DELETE", url, body, nv);
		}
		
		///<summary>DELETE /{index}/{type}/_query
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/delete-by-query/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of types to restrict the operation</param>
		///<param name="body">A query to restrict the operation</param>
		public ConnectionStatus DeleteByQueryDelete(string index, string type, object body, Func<DeleteByQueryDeleteQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_query".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new DeleteByQueryDeleteQueryString());

			return this.DoRequest("DELETE", url, body, nv);
		}
		
		///<summary>DELETE /{index}/{type}/_query
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/delete-by-query/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of types to restrict the operation</param>
		///<param name="body">A query to restrict the operation</param>
		public Task<ConnectionStatus> DeleteByQueryDeleteAsync(string index, string type, object body, Func<DeleteByQueryDeleteQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_query".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new DeleteByQueryDeleteQueryString());

			return this.DoRequestAsync("DELETE", url, body, nv);
		}
		
		///<summary>HEAD /{index}/{type}/{id}
	    ///<pre>http://elasticsearch.org/guide/reference/api/get/</pre>	
	    ///</summary>
		///<param name="id">The document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document (use `_all` to fetch the first document matching the ID across all types)</param>
		public ConnectionStatus ExistsHead(string id, string index, string type, Func<ExistsHeadQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ExistsHeadQueryString());

			return this.DoRequest("HEAD", url, nv);
		}
		
		///<summary>HEAD /{index}/{type}/{id}
	    ///<pre>http://elasticsearch.org/guide/reference/api/get/</pre>	
	    ///</summary>
		///<param name="id">The document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document (use `_all` to fetch the first document matching the ID across all types)</param>
		public Task<ConnectionStatus> ExistsHeadAsync(string id, string index, string type, Func<ExistsHeadQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ExistsHeadQueryString());

			return this.DoRequestAsync("HEAD", url, nv);
		}
		
		///<summary>GET /{index}/{type}/{id}/_explain
	    ///<pre>http://elasticsearch.org/guide/reference/api/explain/</pre>	
	    ///</summary>
		///<param name="id">The document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The query definition using the Query DSL</param>
		public ConnectionStatus ExplainGet(string id, string index, string type, object body, Func<ExplainGetQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}/_explain".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ExplainGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/{type}/{id}/_explain
	    ///<pre>http://elasticsearch.org/guide/reference/api/explain/</pre>	
	    ///</summary>
		///<param name="id">The document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The query definition using the Query DSL</param>
		public Task<ConnectionStatus> ExplainGetAsync(string id, string index, string type, object body, Func<ExplainGetQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}/_explain".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ExplainGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/{id}/_explain
	    ///<pre>http://elasticsearch.org/guide/reference/api/explain/</pre>	
	    ///</summary>
		///<param name="id">The document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The query definition using the Query DSL</param>
		public ConnectionStatus ExplainPost(string id, string index, string type, object body, Func<ExplainPostQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}/_explain".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ExplainPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/{id}/_explain
	    ///<pre>http://elasticsearch.org/guide/reference/api/explain/</pre>	
	    ///</summary>
		///<param name="id">The document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The query definition using the Query DSL</param>
		public Task<ConnectionStatus> ExplainPostAsync(string id, string index, string type, object body, Func<ExplainPostQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}/_explain".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ExplainPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>GET /{index}/{type}/{id}
	    ///<pre>http://elasticsearch.org/guide/reference/api/get/</pre>	
	    ///</summary>
		///<param name="id">The document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document (use `_all` to fetch the first document matching the ID across all types)</param>
		public ConnectionStatus GetGet(string id, string index, string type, Func<GetGetQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new GetGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/{type}/{id}
	    ///<pre>http://elasticsearch.org/guide/reference/api/get/</pre>	
	    ///</summary>
		///<param name="id">The document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document (use `_all` to fetch the first document matching the ID across all types)</param>
		public Task<ConnectionStatus> GetGetAsync(string id, string index, string type, Func<GetGetQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new GetGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/{type}/{id}/_source
	    ///<pre>http://elasticsearch.org/guide/reference/api/get/</pre>	
	    ///</summary>
		///<param name="id">The document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document; use `_all` to fetch the first document matching the ID across all types</param>
		public ConnectionStatus GetSourceGet(string id, string index, string type, Func<GetSourceGetQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}/_source".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new GetSourceGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/{type}/{id}/_source
	    ///<pre>http://elasticsearch.org/guide/reference/api/get/</pre>	
	    ///</summary>
		///<param name="id">The document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document; use `_all` to fetch the first document matching the ID across all types</param>
		public Task<ConnectionStatus> GetSourceGetAsync(string id, string index, string type, Func<GetSourceGetQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}/_source".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new GetSourceGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>POST /{index}/{type}
	    ///<pre>http://elasticsearch.org/guide/reference/api/index_/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		public ConnectionStatus IndexPost(string index, string type, object body, Func<IndexPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndexPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}
	    ///<pre>http://elasticsearch.org/guide/reference/api/index_/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		public Task<ConnectionStatus> IndexPostAsync(string index, string type, object body, Func<IndexPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndexPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/{id}
	    ///<pre>http://elasticsearch.org/guide/reference/api/index_/</pre>	
	    ///</summary>
		///<param name="id">Document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		public ConnectionStatus IndexPost(string id, string index, string type, object body, Func<IndexPostQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndexPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/{id}
	    ///<pre>http://elasticsearch.org/guide/reference/api/index_/</pre>	
	    ///</summary>
		///<param name="id">Document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		public Task<ConnectionStatus> IndexPostAsync(string id, string index, string type, object body, Func<IndexPostQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndexPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>PUT /{index}/{type}
	    ///<pre>http://elasticsearch.org/guide/reference/api/index_/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		public ConnectionStatus IndexPut(string index, string type, object body, Func<IndexPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndexPutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/{type}
	    ///<pre>http://elasticsearch.org/guide/reference/api/index_/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		public Task<ConnectionStatus> IndexPutAsync(string index, string type, object body, Func<IndexPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndexPutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/{type}/{id}
	    ///<pre>http://elasticsearch.org/guide/reference/api/index_/</pre>	
	    ///</summary>
		///<param name="id">Document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		public ConnectionStatus IndexPut(string id, string index, string type, object body, Func<IndexPutQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndexPutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/{type}/{id}
	    ///<pre>http://elasticsearch.org/guide/reference/api/index_/</pre>	
	    ///</summary>
		///<param name="id">Document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The document</param>
		public Task<ConnectionStatus> IndexPutAsync(string id, string index, string type, object body, Func<IndexPutQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndexPutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>GET /_analyze
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-analyze/</pre>	
	    ///</summary>
		///<param name="body">The text on which the analysis should be performed</param>
		public ConnectionStatus IndicesAnalyzeGet(object body, Func<IndicesAnalyzeGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_analyze".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesAnalyzeGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /_analyze
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-analyze/</pre>	
	    ///</summary>
		///<param name="body">The text on which the analysis should be performed</param>
		public Task<ConnectionStatus> IndicesAnalyzeGetAsync(object body, Func<IndicesAnalyzeGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_analyze".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesAnalyzeGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/_analyze
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-analyze/</pre>	
	    ///</summary>
		///<param name="index">The name of the index to scope the operation</param>
		///<param name="body">The text on which the analysis should be performed</param>
		public ConnectionStatus IndicesAnalyzeGet(string index, object body, Func<IndicesAnalyzeGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_analyze".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesAnalyzeGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/_analyze
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-analyze/</pre>	
	    ///</summary>
		///<param name="index">The name of the index to scope the operation</param>
		///<param name="body">The text on which the analysis should be performed</param>
		public Task<ConnectionStatus> IndicesAnalyzeGetAsync(string index, object body, Func<IndicesAnalyzeGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_analyze".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesAnalyzeGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>POST /_analyze
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-analyze/</pre>	
	    ///</summary>
		///<param name="body">The text on which the analysis should be performed</param>
		public ConnectionStatus IndicesAnalyzePost(object body, Func<IndicesAnalyzePostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_analyze".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesAnalyzePostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /_analyze
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-analyze/</pre>	
	    ///</summary>
		///<param name="body">The text on which the analysis should be performed</param>
		public Task<ConnectionStatus> IndicesAnalyzePostAsync(object body, Func<IndicesAnalyzePostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_analyze".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesAnalyzePostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/_analyze
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-analyze/</pre>	
	    ///</summary>
		///<param name="index">The name of the index to scope the operation</param>
		///<param name="body">The text on which the analysis should be performed</param>
		public ConnectionStatus IndicesAnalyzePost(string index, object body, Func<IndicesAnalyzePostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_analyze".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesAnalyzePostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/_analyze
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-analyze/</pre>	
	    ///</summary>
		///<param name="index">The name of the index to scope the operation</param>
		///<param name="body">The text on which the analysis should be performed</param>
		public Task<ConnectionStatus> IndicesAnalyzePostAsync(string index, object body, Func<IndicesAnalyzePostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_analyze".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesAnalyzePostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /_cache/clear
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-clearcache/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesClearCachePost(Func<IndicesClearCachePostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cache/clear";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesClearCachePostQueryString());

			return this.DoRequest("POST", url, nv);
		}
		
		///<summary>POST /_cache/clear
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-clearcache/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesClearCachePostAsync(Func<IndicesClearCachePostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cache/clear";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesClearCachePostQueryString());

			return this.DoRequestAsync("POST", url, nv);
		}
		
		///<summary>POST /{index}/_cache/clear
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-clearcache/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index name to limit the operation</param>
		public ConnectionStatus IndicesClearCachePost(string index, Func<IndicesClearCachePostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_cache/clear".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesClearCachePostQueryString());

			return this.DoRequest("POST", url, nv);
		}
		
		///<summary>POST /{index}/_cache/clear
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-clearcache/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index name to limit the operation</param>
		public Task<ConnectionStatus> IndicesClearCachePostAsync(string index, Func<IndicesClearCachePostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_cache/clear".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesClearCachePostQueryString());

			return this.DoRequestAsync("POST", url, nv);
		}
		
		///<summary>GET /_cache/clear
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-clearcache/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesClearCacheGet(Func<IndicesClearCacheGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cache/clear";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesClearCacheGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_cache/clear
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-clearcache/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesClearCacheGetAsync(Func<IndicesClearCacheGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_cache/clear";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesClearCacheGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_cache/clear
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-clearcache/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index name to limit the operation</param>
		public ConnectionStatus IndicesClearCacheGet(string index, Func<IndicesClearCacheGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_cache/clear".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesClearCacheGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_cache/clear
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-clearcache/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index name to limit the operation</param>
		public Task<ConnectionStatus> IndicesClearCacheGetAsync(string index, Func<IndicesClearCacheGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_cache/clear".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesClearCacheGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>POST /{index}/_close
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-open-close/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		public ConnectionStatus IndicesClosePost(string index, Func<IndicesClosePostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_close".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesClosePostQueryString());

			return this.DoRequest("POST", url, nv);
		}
		
		///<summary>POST /{index}/_close
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-open-close/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		public Task<ConnectionStatus> IndicesClosePostAsync(string index, Func<IndicesClosePostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_close".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesClosePostQueryString());

			return this.DoRequestAsync("POST", url, nv);
		}
		
		///<summary>PUT /{index}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-create-index/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
		public ConnectionStatus IndicesCreatePut(string index, object body, Func<IndicesCreatePutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesCreatePutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-create-index/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
		public Task<ConnectionStatus> IndicesCreatePutAsync(string index, object body, Func<IndicesCreatePutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesCreatePutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>POST /{index}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-create-index/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
		public ConnectionStatus IndicesCreatePost(string index, object body, Func<IndicesCreatePostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesCreatePostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-create-index/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="body">The configuration for the index (`settings` and `mappings`)</param>
		public Task<ConnectionStatus> IndicesCreatePostAsync(string index, object body, Func<IndicesCreatePostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesCreatePostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>DELETE /
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-delete-index/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesDeleteDelete(Func<IndicesDeleteDeleteQueryString, NameValueCollection> queryString = null)
		{
			var url = "/";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesDeleteDeleteQueryString());

			return this.DoRequest("DELETE", url, nv);
		}
		
		///<summary>DELETE /
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-delete-index/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesDeleteDeleteAsync(Func<IndicesDeleteDeleteQueryString, NameValueCollection> queryString = null)
		{
			var url = "/";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesDeleteDeleteQueryString());

			return this.DoRequestAsync("DELETE", url, nv);
		}
		
		///<summary>DELETE /{index}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-delete-index/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to delete; use `_all` or empty string to delete all indices</param>
		public ConnectionStatus IndicesDeleteDelete(string index, Func<IndicesDeleteDeleteQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesDeleteDeleteQueryString());

			return this.DoRequest("DELETE", url, nv);
		}
		
		///<summary>DELETE /{index}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-delete-index/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to delete; use `_all` or empty string to delete all indices</param>
		public Task<ConnectionStatus> IndicesDeleteDeleteAsync(string index, Func<IndicesDeleteDeleteQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesDeleteDeleteQueryString());

			return this.DoRequestAsync("DELETE", url, nv);
		}
		
		///<summary>DELETE /{index}/_alias/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="index">The name of the index with an alias</param>
		///<param name="name">The name of the alias to be deleted</param>
		public ConnectionStatus IndicesDeleteAliasDelete(string index, string name, Func<IndicesDeleteAliasDeleteQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			var url = "/{index}/_alias/{name}".Inject(new { index = index, name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesDeleteAliasDeleteQueryString());

			return this.DoRequest("DELETE", url, nv);
		}
		
		///<summary>DELETE /{index}/_alias/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="index">The name of the index with an alias</param>
		///<param name="name">The name of the alias to be deleted</param>
		public Task<ConnectionStatus> IndicesDeleteAliasDeleteAsync(string index, string name, Func<IndicesDeleteAliasDeleteQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			var url = "/{index}/_alias/{name}".Inject(new { index = index, name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesDeleteAliasDeleteQueryString());

			return this.DoRequestAsync("DELETE", url, nv);
		}
		
		///<summary>DELETE /{index}/{type}/_mapping
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-delete-mapping/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` for all indices</param>
		///<param name="type">The name of the document type to delete</param>
		public ConnectionStatus IndicesDeleteMappingDelete(string index, string type, Func<IndicesDeleteMappingDeleteQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_mapping".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesDeleteMappingDeleteQueryString());

			return this.DoRequest("DELETE", url, nv);
		}
		
		///<summary>DELETE /{index}/{type}/_mapping
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-delete-mapping/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` for all indices</param>
		///<param name="type">The name of the document type to delete</param>
		public Task<ConnectionStatus> IndicesDeleteMappingDeleteAsync(string index, string type, Func<IndicesDeleteMappingDeleteQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_mapping".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesDeleteMappingDeleteQueryString());

			return this.DoRequestAsync("DELETE", url, nv);
		}
		
		///<summary>DELETE /_template/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-templates/</pre>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		public ConnectionStatus IndicesDeleteTemplateDelete(string name, Func<IndicesDeleteTemplateDeleteQueryString, NameValueCollection> queryString = null)
		{
			name.ThrowIfNull("name");
			var url = "/_template/{name}".Inject(new { name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesDeleteTemplateDeleteQueryString());

			return this.DoRequest("DELETE", url, nv);
		}
		
		///<summary>DELETE /_template/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-templates/</pre>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		public Task<ConnectionStatus> IndicesDeleteTemplateDeleteAsync(string name, Func<IndicesDeleteTemplateDeleteQueryString, NameValueCollection> queryString = null)
		{
			name.ThrowIfNull("name");
			var url = "/_template/{name}".Inject(new { name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesDeleteTemplateDeleteQueryString());

			return this.DoRequestAsync("DELETE", url, nv);
		}
		
		///<summary>DELETE /{index}/_warmer
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-warmers/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register warmer for; use `_all` or empty string to perform the operation on all indices</param>
		public ConnectionStatus IndicesDeleteWarmerDelete(string index, Func<IndicesDeleteWarmerDeleteQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_warmer".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesDeleteWarmerDeleteQueryString());

			return this.DoRequest("DELETE", url, nv);
		}
		
		///<summary>DELETE /{index}/_warmer
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-warmers/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register warmer for; use `_all` or empty string to perform the operation on all indices</param>
		public Task<ConnectionStatus> IndicesDeleteWarmerDeleteAsync(string index, Func<IndicesDeleteWarmerDeleteQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_warmer".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesDeleteWarmerDeleteQueryString());

			return this.DoRequestAsync("DELETE", url, nv);
		}
		
		///<summary>DELETE /{index}/_warmer/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-warmers/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register warmer for; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="name">The name of the warmer (supports wildcards); leave empty to delete all warmers</param>
		public ConnectionStatus IndicesDeleteWarmerDelete(string index, string name, Func<IndicesDeleteWarmerDeleteQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			var url = "/{index}/_warmer/{name}".Inject(new { index = index, name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesDeleteWarmerDeleteQueryString());

			return this.DoRequest("DELETE", url, nv);
		}
		
		///<summary>DELETE /{index}/_warmer/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-warmers/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register warmer for; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="name">The name of the warmer (supports wildcards); leave empty to delete all warmers</param>
		public Task<ConnectionStatus> IndicesDeleteWarmerDeleteAsync(string index, string name, Func<IndicesDeleteWarmerDeleteQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			var url = "/{index}/_warmer/{name}".Inject(new { index = index, name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesDeleteWarmerDeleteQueryString());

			return this.DoRequestAsync("DELETE", url, nv);
		}
		
		///<summary>DELETE /{index}/{type}/_warmer/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-warmers/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register warmer for; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="name">The name of the warmer (supports wildcards); leave empty to delete all warmers</param>
		///<param name="type">A comma-separated list of document types to register warmer for; use `_all` or empty string to perform the operation on all types</param>
		public ConnectionStatus IndicesDeleteWarmerDelete(string index, string name, string type, Func<IndicesDeleteWarmerDeleteQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_warmer/{name}".Inject(new { index = index, name = name, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesDeleteWarmerDeleteQueryString());

			return this.DoRequest("DELETE", url, nv);
		}
		
		///<summary>DELETE /{index}/{type}/_warmer/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-warmers/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register warmer for; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="name">The name of the warmer (supports wildcards); leave empty to delete all warmers</param>
		///<param name="type">A comma-separated list of document types to register warmer for; use `_all` or empty string to perform the operation on all types</param>
		public Task<ConnectionStatus> IndicesDeleteWarmerDeleteAsync(string index, string name, string type, Func<IndicesDeleteWarmerDeleteQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_warmer/{name}".Inject(new { index = index, name = name, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesDeleteWarmerDeleteQueryString());

			return this.DoRequestAsync("DELETE", url, nv);
		}
		
		///<summary>HEAD /{index}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-indices-exists/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to check</param>
		public ConnectionStatus IndicesExistsHead(string index, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequest("HEAD", url, nv);
		}
		
		///<summary>HEAD /{index}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-indices-exists/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of indices to check</param>
		public Task<ConnectionStatus> IndicesExistsHeadAsync(string index, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequestAsync("HEAD", url, nv);
		}
		
		///<summary>HEAD /_alias/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="name">A comma-separated list of alias names to return</param>
		public ConnectionStatus IndicesExistsAliasHead(string name, Func<IndicesExistsAliasHeadQueryString, NameValueCollection> queryString = null)
		{
			name.ThrowIfNull("name");
			var url = "/_alias/{name}".Inject(new { name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesExistsAliasHeadQueryString());

			return this.DoRequest("HEAD", url, nv);
		}
		
		///<summary>HEAD /_alias/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="name">A comma-separated list of alias names to return</param>
		public Task<ConnectionStatus> IndicesExistsAliasHeadAsync(string name, Func<IndicesExistsAliasHeadQueryString, NameValueCollection> queryString = null)
		{
			name.ThrowIfNull("name");
			var url = "/_alias/{name}".Inject(new { name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesExistsAliasHeadQueryString());

			return this.DoRequestAsync("HEAD", url, nv);
		}
		
		///<summary>HEAD /{index}/_alias/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		///<param name="name">A comma-separated list of alias names to return</param>
		public ConnectionStatus IndicesExistsAliasHead(string index, string name, Func<IndicesExistsAliasHeadQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			var url = "/{index}/_alias/{name}".Inject(new { index = index, name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesExistsAliasHeadQueryString());

			return this.DoRequest("HEAD", url, nv);
		}
		
		///<summary>HEAD /{index}/_alias/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		///<param name="name">A comma-separated list of alias names to return</param>
		public Task<ConnectionStatus> IndicesExistsAliasHeadAsync(string index, string name, Func<IndicesExistsAliasHeadQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			var url = "/{index}/_alias/{name}".Inject(new { index = index, name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesExistsAliasHeadQueryString());

			return this.DoRequestAsync("HEAD", url, nv);
		}
		
		///<summary>HEAD /{index}/{type}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-types-exists/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` to check the types across all indices</param>
		///<param name="type">A comma-separated list of document types to check</param>
		public ConnectionStatus IndicesExistsTypeHead(string index, string type, Func<IndicesExistsTypeHeadQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesExistsTypeHeadQueryString());

			return this.DoRequest("HEAD", url, nv);
		}
		
		///<summary>HEAD /{index}/{type}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-types-exists/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` to check the types across all indices</param>
		///<param name="type">A comma-separated list of document types to check</param>
		public Task<ConnectionStatus> IndicesExistsTypeHeadAsync(string index, string type, Func<IndicesExistsTypeHeadQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesExistsTypeHeadQueryString());

			return this.DoRequestAsync("HEAD", url, nv);
		}
		
		///<summary>POST /_flush
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-flush/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesFlushPost(Func<IndicesFlushPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_flush";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesFlushPostQueryString());

			return this.DoRequest("POST", url, nv);
		}
		
		///<summary>POST /_flush
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-flush/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesFlushPostAsync(Func<IndicesFlushPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_flush";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesFlushPostQueryString());

			return this.DoRequestAsync("POST", url, nv);
		}
		
		///<summary>POST /{index}/_flush
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-flush/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
		public ConnectionStatus IndicesFlushPost(string index, Func<IndicesFlushPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_flush".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesFlushPostQueryString());

			return this.DoRequest("POST", url, nv);
		}
		
		///<summary>POST /{index}/_flush
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-flush/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
		public Task<ConnectionStatus> IndicesFlushPostAsync(string index, Func<IndicesFlushPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_flush".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesFlushPostQueryString());

			return this.DoRequestAsync("POST", url, nv);
		}
		
		///<summary>GET /_flush
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-flush/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesFlushGet(Func<IndicesFlushGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_flush";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesFlushGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_flush
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-flush/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesFlushGetAsync(Func<IndicesFlushGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_flush";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesFlushGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_flush
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-flush/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
		public ConnectionStatus IndicesFlushGet(string index, Func<IndicesFlushGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_flush".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesFlushGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_flush
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-flush/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
		public Task<ConnectionStatus> IndicesFlushGetAsync(string index, Func<IndicesFlushGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_flush".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesFlushGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_alias/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="name">A comma-separated list of alias names to return</param>
		public ConnectionStatus IndicesGetAliasGet(string name, Func<IndicesGetAliasGetQueryString, NameValueCollection> queryString = null)
		{
			name.ThrowIfNull("name");
			var url = "/_alias/{name}".Inject(new { name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesGetAliasGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_alias/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="name">A comma-separated list of alias names to return</param>
		public Task<ConnectionStatus> IndicesGetAliasGetAsync(string name, Func<IndicesGetAliasGetQueryString, NameValueCollection> queryString = null)
		{
			name.ThrowIfNull("name");
			var url = "/_alias/{name}".Inject(new { name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesGetAliasGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_alias/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		///<param name="name">A comma-separated list of alias names to return</param>
		public ConnectionStatus IndicesGetAliasGet(string index, string name, Func<IndicesGetAliasGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			var url = "/{index}/_alias/{name}".Inject(new { index = index, name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesGetAliasGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_alias/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		///<param name="name">A comma-separated list of alias names to return</param>
		public Task<ConnectionStatus> IndicesGetAliasGetAsync(string index, string name, Func<IndicesGetAliasGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			var url = "/{index}/_alias/{name}".Inject(new { index = index, name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesGetAliasGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_aliases
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesGetAliasesGet(Func<IndicesGetAliasesGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_aliases";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesGetAliasesGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_aliases
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesGetAliasesGetAsync(Func<IndicesGetAliasesGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_aliases";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesGetAliasesGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_aliases
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		public ConnectionStatus IndicesGetAliasesGet(string index, Func<IndicesGetAliasesGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_aliases".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesGetAliasesGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_aliases
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to filter aliases</param>
		public Task<ConnectionStatus> IndicesGetAliasesGetAsync(string index, Func<IndicesGetAliasesGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_aliases".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesGetAliasesGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_mapping/field/{field}
	    ///<pre>http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/indices-get-field-mapping.html</pre>	
	    ///</summary>
		///<param name="field">A comma-separated list of fields</param>
		public ConnectionStatus IndicesGetFieldMappingGet(string field, Func<IndicesGetFieldMappingGetQueryString, NameValueCollection> queryString = null)
		{
			field.ThrowIfNull("field");
			var url = "/_mapping/field/{field}".Inject(new { field = field });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesGetFieldMappingGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_mapping/field/{field}
	    ///<pre>http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/indices-get-field-mapping.html</pre>	
	    ///</summary>
		///<param name="field">A comma-separated list of fields</param>
		public Task<ConnectionStatus> IndicesGetFieldMappingGetAsync(string field, Func<IndicesGetFieldMappingGetQueryString, NameValueCollection> queryString = null)
		{
			field.ThrowIfNull("field");
			var url = "/_mapping/field/{field}".Inject(new { field = field });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesGetFieldMappingGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_mapping/field/{field}
	    ///<pre>http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/indices-get-field-mapping.html</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="field">A comma-separated list of fields</param>
		public ConnectionStatus IndicesGetFieldMappingGet(string index, string field, Func<IndicesGetFieldMappingGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			field.ThrowIfNull("field");
			var url = "/{index}/_mapping/field/{field}".Inject(new { index = index, field = field });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesGetFieldMappingGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_mapping/field/{field}
	    ///<pre>http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/indices-get-field-mapping.html</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="field">A comma-separated list of fields</param>
		public Task<ConnectionStatus> IndicesGetFieldMappingGetAsync(string index, string field, Func<IndicesGetFieldMappingGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			field.ThrowIfNull("field");
			var url = "/{index}/_mapping/field/{field}".Inject(new { index = index, field = field });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesGetFieldMappingGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/{type}/_mapping/field/{field}
	    ///<pre>http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/indices-get-field-mapping.html</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="type">A comma-separated list of document types</param>
		///<param name="field">A comma-separated list of fields</param>
		public ConnectionStatus IndicesGetFieldMappingGet(string index, string type, string field, Func<IndicesGetFieldMappingGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			field.ThrowIfNull("field");
			var url = "/{index}/{type}/_mapping/field/{field}".Inject(new { index = index, type = type, field = field });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesGetFieldMappingGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/{type}/_mapping/field/{field}
	    ///<pre>http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/indices-get-field-mapping.html</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="type">A comma-separated list of document types</param>
		///<param name="field">A comma-separated list of fields</param>
		public Task<ConnectionStatus> IndicesGetFieldMappingGetAsync(string index, string type, string field, Func<IndicesGetFieldMappingGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			field.ThrowIfNull("field");
			var url = "/{index}/{type}/_mapping/field/{field}".Inject(new { index = index, type = type, field = field });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesGetFieldMappingGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_mapping
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-get-mapping/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesGetMappingGet(Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_mapping";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_mapping
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-get-mapping/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesGetMappingGetAsync(Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_mapping";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_mapping
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-get-mapping/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		public ConnectionStatus IndicesGetMappingGet(string index, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_mapping".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_mapping
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-get-mapping/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		public Task<ConnectionStatus> IndicesGetMappingGetAsync(string index, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_mapping".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/{type}/_mapping
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-get-mapping/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="type">A comma-separated list of document types</param>
		public ConnectionStatus IndicesGetMappingGet(string index, string type, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_mapping".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/{type}/_mapping
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-get-mapping/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names</param>
		///<param name="type">A comma-separated list of document types</param>
		public Task<ConnectionStatus> IndicesGetMappingGetAsync(string index, string type, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_mapping".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_settings
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-get-settings/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesGetSettingsGet(Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_settings";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_settings
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-get-settings/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesGetSettingsGetAsync(Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_settings";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_settings
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-get-settings/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public ConnectionStatus IndicesGetSettingsGet(string index, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_settings".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_settings
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-get-settings/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public Task<ConnectionStatus> IndicesGetSettingsGetAsync(string index, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_settings".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_template
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-templates/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesGetTemplateGet(Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_template";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_template
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-templates/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesGetTemplateGetAsync(Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_template";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_template/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-templates/</pre>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		public ConnectionStatus IndicesGetTemplateGet(string name, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			name.ThrowIfNull("name");
			var url = "/_template/{name}".Inject(new { name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_template/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-templates/</pre>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		public Task<ConnectionStatus> IndicesGetTemplateGetAsync(string name, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			name.ThrowIfNull("name");
			var url = "/_template/{name}".Inject(new { name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_warmer
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-warmers/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
		public ConnectionStatus IndicesGetWarmerGet(string index, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_warmer".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_warmer
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-warmers/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
		public Task<ConnectionStatus> IndicesGetWarmerGetAsync(string index, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_warmer".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_warmer/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-warmers/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
		public ConnectionStatus IndicesGetWarmerGet(string index, string name, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			var url = "/{index}/_warmer/{name}".Inject(new { index = index, name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_warmer/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-warmers/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
		public Task<ConnectionStatus> IndicesGetWarmerGetAsync(string index, string name, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			var url = "/{index}/_warmer/{name}".Inject(new { index = index, name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/{type}/_warmer/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-warmers/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
		///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
		public ConnectionStatus IndicesGetWarmerGet(string index, string name, string type, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_warmer/{name}".Inject(new { index = index, name = name, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/{type}/_warmer/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-warmers/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` to perform the operation on all indices</param>
		///<param name="name">The name of the warmer (supports wildcards); leave empty to get all warmers</param>
		///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
		public Task<ConnectionStatus> IndicesGetWarmerGetAsync(string index, string name, string type, Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_warmer/{name}".Inject(new { index = index, name = name, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>POST /{index}/_open
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-open-close/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		public ConnectionStatus IndicesOpenPost(string index, Func<IndicesOpenPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_open".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesOpenPostQueryString());

			return this.DoRequest("POST", url, nv);
		}
		
		///<summary>POST /{index}/_open
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-open-close/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		public Task<ConnectionStatus> IndicesOpenPostAsync(string index, Func<IndicesOpenPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_open".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesOpenPostQueryString());

			return this.DoRequestAsync("POST", url, nv);
		}
		
		///<summary>POST /_optimize
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-optimize/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesOptimizePost(Func<IndicesOptimizePostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_optimize";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesOptimizePostQueryString());

			return this.DoRequest("POST", url, nv);
		}
		
		///<summary>POST /_optimize
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-optimize/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesOptimizePostAsync(Func<IndicesOptimizePostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_optimize";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesOptimizePostQueryString());

			return this.DoRequestAsync("POST", url, nv);
		}
		
		///<summary>POST /{index}/_optimize
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-optimize/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public ConnectionStatus IndicesOptimizePost(string index, Func<IndicesOptimizePostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_optimize".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesOptimizePostQueryString());

			return this.DoRequest("POST", url, nv);
		}
		
		///<summary>POST /{index}/_optimize
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-optimize/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public Task<ConnectionStatus> IndicesOptimizePostAsync(string index, Func<IndicesOptimizePostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_optimize".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesOptimizePostQueryString());

			return this.DoRequestAsync("POST", url, nv);
		}
		
		///<summary>GET /_optimize
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-optimize/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesOptimizeGet(Func<IndicesOptimizeGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_optimize";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesOptimizeGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_optimize
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-optimize/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesOptimizeGetAsync(Func<IndicesOptimizeGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_optimize";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesOptimizeGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_optimize
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-optimize/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public ConnectionStatus IndicesOptimizeGet(string index, Func<IndicesOptimizeGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_optimize".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesOptimizeGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_optimize
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-optimize/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public Task<ConnectionStatus> IndicesOptimizeGetAsync(string index, Func<IndicesOptimizeGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_optimize".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesOptimizeGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>PUT /{index}/_alias/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="index">The name of the index with an alias</param>
		///<param name="name">The name of the alias to be created or updated</param>
		///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
		public ConnectionStatus IndexPutAliasPut(string index, string name, object body, Func<IndicesPutAliasPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			var url = "/{index}/_alias/{name}".Inject(new { index = index, name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutAliasPutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/_alias/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="index">The name of the index with an alias</param>
		///<param name="name">The name of the alias to be created or updated</param>
		///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
		public Task<ConnectionStatus> IndexPutAliasPutAsync(string index, string name, object body, Func<IndicesPutAliasPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			var url = "/{index}/_alias/{name}".Inject(new { index = index, name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutAliasPutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>PUT /_alias/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="name">The name of the alias to be created or updated</param>
		///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
		public ConnectionStatus IndicesPutAliasPut(string name, object body, Func<IndicesPutAliasPutQueryString, NameValueCollection> queryString = null)
		{
			name.ThrowIfNull("name");
			var url = "/_alias/{name}".Inject(new { name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutAliasPutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /_alias/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="name">The name of the alias to be created or updated</param>
		///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
		public Task<ConnectionStatus> IndicesPutAliasPutAsync(string name, object body, Func<IndicesPutAliasPutQueryString, NameValueCollection> queryString = null)
		{
			name.ThrowIfNull("name");
			var url = "/_alias/{name}".Inject(new { name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutAliasPutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/_alias
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="index">The name of the index with an alias</param>
		///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
		public ConnectionStatus IndexPutAliasPut(string index, object body, Func<IndicesPutAliasPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_alias".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutAliasPutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/_alias
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="index">The name of the index with an alias</param>
		///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
		public Task<ConnectionStatus> IndexPutAliasPutAsync(string index, object body, Func<IndicesPutAliasPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_alias".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutAliasPutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>PUT /_alias
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
		public ConnectionStatus IndicesPutAliasPut(object body, Func<IndicesPutAliasPutQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_alias".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutAliasPutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /_alias
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="body">The settings for the alias, such as `routing` or `filter`</param>
		public Task<ConnectionStatus> IndicesPutAliasPutAsync(object body, Func<IndicesPutAliasPutQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_alias".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutAliasPutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/{type}/_mapping
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-put-mapping/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` to perform the operation on all indices</param>
		///<param name="type">The name of the document type</param>
		///<param name="body">The mapping definition</param>
		public ConnectionStatus IndicesPutMappingPut(string index, string type, object body, Func<IndicesPutMappingPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_mapping".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutMappingPutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/{type}/_mapping
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-put-mapping/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` to perform the operation on all indices</param>
		///<param name="type">The name of the document type</param>
		///<param name="body">The mapping definition</param>
		public Task<ConnectionStatus> IndicesPutMappingPutAsync(string index, string type, object body, Func<IndicesPutMappingPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_mapping".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutMappingPutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/_mapping
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-put-mapping/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` to perform the operation on all indices</param>
		///<param name="type">The name of the document type</param>
		///<param name="body">The mapping definition</param>
		public ConnectionStatus IndicesPutMappingPost(string index, string type, object body, Func<IndicesPutMappingPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_mapping".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutMappingPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/_mapping
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-put-mapping/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` to perform the operation on all indices</param>
		///<param name="type">The name of the document type</param>
		///<param name="body">The mapping definition</param>
		public Task<ConnectionStatus> IndicesPutMappingPostAsync(string index, string type, object body, Func<IndicesPutMappingPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_mapping".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutMappingPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>PUT /_settings
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-update-settings/</pre>	
	    ///</summary>
		///<param name="body">The index settings to be updated</param>
		public ConnectionStatus IndicesPutSettingsPut(object body, Func<IndicesPutSettingsPutQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_settings".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutSettingsPutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /_settings
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-update-settings/</pre>	
	    ///</summary>
		///<param name="body">The index settings to be updated</param>
		public Task<ConnectionStatus> IndicesPutSettingsPutAsync(object body, Func<IndicesPutSettingsPutQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_settings".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutSettingsPutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/_settings
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-update-settings/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The index settings to be updated</param>
		public ConnectionStatus IndicesPutSettingsPut(string index, object body, Func<IndicesPutSettingsPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_settings".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutSettingsPutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/_settings
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-update-settings/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The index settings to be updated</param>
		public Task<ConnectionStatus> IndicesPutSettingsPutAsync(string index, object body, Func<IndicesPutSettingsPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_settings".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutSettingsPutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>PUT /_template/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-templates/</pre>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		///<param name="body">The template definition</param>
		public ConnectionStatus IndicesPutTemplatePut(string name, object body, Func<IndicesPutTemplatePutQueryString, NameValueCollection> queryString = null)
		{
			name.ThrowIfNull("name");
			var url = "/_template/{name}".Inject(new { name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutTemplatePutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /_template/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-templates/</pre>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		///<param name="body">The template definition</param>
		public Task<ConnectionStatus> IndicesPutTemplatePutAsync(string name, object body, Func<IndicesPutTemplatePutQueryString, NameValueCollection> queryString = null)
		{
			name.ThrowIfNull("name");
			var url = "/_template/{name}".Inject(new { name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutTemplatePutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>POST /_template/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-templates/</pre>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		///<param name="body">The template definition</param>
		public ConnectionStatus IndicesPutTemplatePost(string name, object body, Func<IndicesPutTemplatePostQueryString, NameValueCollection> queryString = null)
		{
			name.ThrowIfNull("name");
			var url = "/_template/{name}".Inject(new { name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutTemplatePostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /_template/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-templates/</pre>	
	    ///</summary>
		///<param name="name">The name of the template</param>
		///<param name="body">The template definition</param>
		public Task<ConnectionStatus> IndicesPutTemplatePostAsync(string name, object body, Func<IndicesPutTemplatePostQueryString, NameValueCollection> queryString = null)
		{
			name.ThrowIfNull("name");
			var url = "/_template/{name}".Inject(new { name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutTemplatePostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>PUT /{index}/_warmer/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-warmers/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="name">The name of the warmer</param>
		///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
		public ConnectionStatus IndicesPutWarmerPut(string index, string name, object body, Func<IndicesPutWarmerPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			var url = "/{index}/_warmer/{name}".Inject(new { index = index, name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutWarmerPutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/_warmer/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-warmers/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="name">The name of the warmer</param>
		///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
		public Task<ConnectionStatus> IndicesPutWarmerPutAsync(string index, string name, object body, Func<IndicesPutWarmerPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			var url = "/{index}/_warmer/{name}".Inject(new { index = index, name = name });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutWarmerPutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/{type}/_warmer/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-warmers/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="name">The name of the warmer</param>
		///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
		///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
		public ConnectionStatus IndicesPutWarmerPut(string index, string name, string type, object body, Func<IndicesPutWarmerPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_warmer/{name}".Inject(new { index = index, name = name, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutWarmerPutQueryString());

			return this.DoRequest("PUT", url, body, nv);
		}
		
		///<summary>PUT /{index}/{type}/_warmer/{name}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-warmers/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to register the warmer for; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="name">The name of the warmer</param>
		///<param name="type">A comma-separated list of document types to register the warmer for; leave empty to perform the operation on all types</param>
		///<param name="body">The search request definition for the warmer (query, filters, facets, sorting, etc)</param>
		public Task<ConnectionStatus> IndicesPutWarmerPutAsync(string index, string name, string type, object body, Func<IndicesPutWarmerPutQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			name.ThrowIfNull("name");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_warmer/{name}".Inject(new { index = index, name = name, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesPutWarmerPutQueryString());

			return this.DoRequestAsync("PUT", url, body, nv);
		}
		
		///<summary>POST /_refresh
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-refresh/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesRefreshPost(Func<IndicesRefreshPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_refresh";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesRefreshPostQueryString());

			return this.DoRequest("POST", url, nv);
		}
		
		///<summary>POST /_refresh
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-refresh/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesRefreshPostAsync(Func<IndicesRefreshPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_refresh";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesRefreshPostQueryString());

			return this.DoRequestAsync("POST", url, nv);
		}
		
		///<summary>POST /{index}/_refresh
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-refresh/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public ConnectionStatus IndicesRefreshPost(string index, Func<IndicesRefreshPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_refresh".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesRefreshPostQueryString());

			return this.DoRequest("POST", url, nv);
		}
		
		///<summary>POST /{index}/_refresh
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-refresh/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public Task<ConnectionStatus> IndicesRefreshPostAsync(string index, Func<IndicesRefreshPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_refresh".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesRefreshPostQueryString());

			return this.DoRequestAsync("POST", url, nv);
		}
		
		///<summary>GET /_refresh
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-refresh/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesRefreshGet(Func<IndicesRefreshGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_refresh";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesRefreshGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_refresh
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-refresh/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesRefreshGetAsync(Func<IndicesRefreshGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_refresh";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesRefreshGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_refresh
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-refresh/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public ConnectionStatus IndicesRefreshGet(string index, Func<IndicesRefreshGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_refresh".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesRefreshGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_refresh
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-refresh/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public Task<ConnectionStatus> IndicesRefreshGetAsync(string index, Func<IndicesRefreshGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_refresh".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesRefreshGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_segments
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-segments/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesSegmentsGet(Func<IndicesSegmentsGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_segments";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesSegmentsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_segments
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-segments/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesSegmentsGetAsync(Func<IndicesSegmentsGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_segments";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesSegmentsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_segments
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-segments/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public ConnectionStatus IndicesSegmentsGet(string index, Func<IndicesSegmentsGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_segments".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesSegmentsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_segments
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-segments/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public Task<ConnectionStatus> IndicesSegmentsGetAsync(string index, Func<IndicesSegmentsGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_segments".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesSegmentsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>POST /_gateway/snapshot
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-gateway-snapshot/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesSnapshotIndexPost(Func<IndicesSnapshotIndexPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_gateway/snapshot";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesSnapshotIndexPostQueryString());

			return this.DoRequest("POST", url, nv);
		}
		
		///<summary>POST /_gateway/snapshot
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-gateway-snapshot/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesSnapshotIndexPostAsync(Func<IndicesSnapshotIndexPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_gateway/snapshot";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesSnapshotIndexPostQueryString());

			return this.DoRequestAsync("POST", url, nv);
		}
		
		///<summary>POST /{index}/_gateway/snapshot
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-gateway-snapshot/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
		public ConnectionStatus IndicesSnapshotIndexPost(string index, Func<IndicesSnapshotIndexPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_gateway/snapshot".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesSnapshotIndexPostQueryString());

			return this.DoRequest("POST", url, nv);
		}
		
		///<summary>POST /{index}/_gateway/snapshot
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-gateway-snapshot/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string for all indices</param>
		public Task<ConnectionStatus> IndicesSnapshotIndexPostAsync(string index, Func<IndicesSnapshotIndexPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_gateway/snapshot".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesSnapshotIndexPostQueryString());

			return this.DoRequestAsync("POST", url, nv);
		}
		
		///<summary>GET /_stats
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesStatsGet(Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_stats";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_stats
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesStatsGetAsync(Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_stats";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_stats
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public ConnectionStatus IndexStatsGet(string index, Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_stats".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_stats
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public Task<ConnectionStatus> IndexStatsGetAsync(string index, Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_stats".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET _stats/{metric_family}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		///<param name="metric_family">Limit the information returned to a specific metric</param>
		public ConnectionStatus IndicesStatsGet(MetricFamilyOptions metric_family, Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			metric_family.ThrowIfNull("metric_family");
			var url = "_stats/{metric_family}".Inject(new { metric_family = metric_family });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET _stats/{metric_family}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		///<param name="metric_family">Limit the information returned to a specific metric</param>
		public Task<ConnectionStatus> IndicesStatsGetAsync(MetricFamilyOptions metric_family, Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			metric_family.ThrowIfNull("metric_family");
			var url = "_stats/{metric_family}".Inject(new { metric_family = metric_family });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_stats/{metric_family}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="metric_family">Limit the information returned to a specific metric</param>
		public ConnectionStatus IndexStatsGet(string index, MetricFamilyOptions metric_family, Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			metric_family.ThrowIfNull("metric_family");
			var url = "/{index}/_stats/{metric_family}".Inject(new { index = index, metric_family = metric_family });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_stats/{metric_family}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="metric_family">Limit the information returned to a specific metric</param>
		public Task<ConnectionStatus> IndexStatsGetAsync(string index, MetricFamilyOptions metric_family, Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			metric_family.ThrowIfNull("metric_family");
			var url = "/{index}/_stats/{metric_family}".Inject(new { index = index, metric_family = metric_family });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_stats/indexing/{indexing_types}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		///<param name="indexing_types">A comma-separated list of document types to include in the `indexing` statistics</param>
		public ConnectionStatus IndicesIndexingStatsGet(string indexing_types, Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			indexing_types.ThrowIfNull("indexing_types");
			var url = "/_stats/indexing/{indexing_types}".Inject(new { indexing_types = indexing_types });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_stats/indexing/{indexing_types}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		///<param name="indexing_types">A comma-separated list of document types to include in the `indexing` statistics</param>
		public Task<ConnectionStatus> IndicesIndexingStatsGetAsync(string indexing_types, Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			indexing_types.ThrowIfNull("indexing_types");
			var url = "/_stats/indexing/{indexing_types}".Inject(new { indexing_types = indexing_types });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_stats/search/{search_groups}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		///<param name="search_groups">A comma-separated list of search groups to include in the `search` statistics</param>
		public ConnectionStatus IndicesSearchStatsGet(string search_groups, Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			search_groups.ThrowIfNull("search_groups");
			var url = "/_stats/search/{search_groups}".Inject(new { search_groups = search_groups });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_stats/search/{search_groups}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		///<param name="search_groups">A comma-separated list of search groups to include in the `search` statistics</param>
		public Task<ConnectionStatus> IndicesSearchStatsGetAsync(string search_groups, Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			search_groups.ThrowIfNull("search_groups");
			var url = "/_stats/search/{search_groups}".Inject(new { search_groups = search_groups });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_stats/search/{search_groups}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="search_groups">A comma-separated list of search groups to include in the `search` statistics</param>
		public ConnectionStatus IndexSearchStatsGet(string index, string search_groups, Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			search_groups.ThrowIfNull("search_groups");
			var url = "/{index}/_stats/search/{search_groups}".Inject(new { index = index, search_groups = search_groups });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_stats/search/{search_groups}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="search_groups">A comma-separated list of search groups to include in the `search` statistics</param>
		public Task<ConnectionStatus> IndexSearchStatsGetAsync(string index, string search_groups, Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			search_groups.ThrowIfNull("search_groups");
			var url = "/{index}/_stats/search/{search_groups}".Inject(new { index = index, search_groups = search_groups });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_stats/fielddata/{fields}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		///<param name="fields">A comma-separated list of fields to return detailed information for, when returning the `search` statistics</param>
		public ConnectionStatus IndicesFieldDataStatsGet(string fields, Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			fields.ThrowIfNull("fields");
			var url = "/_stats/fielddata/{fields}".Inject(new { fields = fields });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_stats/fielddata/{fields}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		///<param name="fields">A comma-separated list of fields to return detailed information for, when returning the `search` statistics</param>
		public Task<ConnectionStatus> IndicesFieldDataStatsGetAsync(string fields, Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			fields.ThrowIfNull("fields");
			var url = "/_stats/fielddata/{fields}".Inject(new { fields = fields });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_stats/fielddata/{fields}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		///<param name="fields">A comma-separated list of fields to return detailed information for, when returning the `search` statistics</param>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public ConnectionStatus IndexFieldDataStatsGet(string fields, string index, Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			fields.ThrowIfNull("fields");
			index.ThrowIfNull("index");
			var url = "/{index}/_stats/fielddata/{fields}".Inject(new { fields = fields, index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_stats/fielddata/{fields}
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-stats/</pre>	
	    ///</summary>
		///<param name="fields">A comma-separated list of fields to return detailed information for, when returning the `search` statistics</param>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public Task<ConnectionStatus> IndexFieldDataStatsGetAsync(string fields, string index, Func<IndicesStatsGetQueryString, NameValueCollection> queryString = null)
		{
			fields.ThrowIfNull("fields");
			index.ThrowIfNull("index");
			var url = "/{index}/_stats/fielddata/{fields}".Inject(new { fields = fields, index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatsGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /_status
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-status/</pre>	
	    ///</summary>
		public ConnectionStatus IndicesStatusGet(Func<IndicesStatusGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_status";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatusGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /_status
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-status/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> IndicesStatusGetAsync(Func<IndicesStatusGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_status";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatusGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>GET /{index}/_status
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-status/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public ConnectionStatus IndicesStatusGet(string index, Func<IndicesStatusGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_status".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatusGetQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /{index}/_status
	    ///<pre>http://elasticsearch.org/guide/reference/api/admin-indices-status/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names; use `_all` or empty string to perform the operation on all indices</param>
		public Task<ConnectionStatus> IndicesStatusGetAsync(string index, Func<IndicesStatusGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_status".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesStatusGetQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>POST /_aliases
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="body">The definition of `actions` to perform</param>
		public ConnectionStatus IndicesUpdateAliasesPost(object body, Func<IndicesUpdateAliasesPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_aliases".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesUpdateAliasesPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /_aliases
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/admin-indices-aliases/</pre>	
	    ///</summary>
		///<param name="body">The definition of `actions` to perform</param>
		public Task<ConnectionStatus> IndicesUpdateAliasesPostAsync(object body, Func<IndicesUpdateAliasesPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_aliases".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesUpdateAliasesPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>GET /_validate/query
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/validate/</pre>	
	    ///</summary>
		///<param name="body">The query definition</param>
		public ConnectionStatus IndicesValidateQueryGet(object body, Func<IndicesValidateQueryGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_validate/query".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesValidateQueryGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /_validate/query
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/validate/</pre>	
	    ///</summary>
		///<param name="body">The query definition</param>
		public Task<ConnectionStatus> IndicesValidateQueryGetAsync(object body, Func<IndicesValidateQueryGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_validate/query".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesValidateQueryGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/_validate/query
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/validate/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The query definition</param>
		public ConnectionStatus IndicesValidateQueryGet(string index, object body, Func<IndicesValidateQueryGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_validate/query".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesValidateQueryGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/_validate/query
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/validate/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The query definition</param>
		public Task<ConnectionStatus> IndicesValidateQueryGetAsync(string index, object body, Func<IndicesValidateQueryGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_validate/query".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesValidateQueryGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/{type}/_validate/query
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/validate/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
		///<param name="body">The query definition</param>
		public ConnectionStatus IndicesValidateQueryGet(string index, string type, object body, Func<IndicesValidateQueryGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_validate/query".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesValidateQueryGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/{type}/_validate/query
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/validate/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
		///<param name="body">The query definition</param>
		public Task<ConnectionStatus> IndicesValidateQueryGetAsync(string index, string type, object body, Func<IndicesValidateQueryGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_validate/query".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesValidateQueryGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>POST /_validate/query
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/validate/</pre>	
	    ///</summary>
		///<param name="body">The query definition</param>
		public ConnectionStatus IndicesValidateQueryPost(object body, Func<IndicesValidateQueryPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_validate/query".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesValidateQueryPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /_validate/query
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/validate/</pre>	
	    ///</summary>
		///<param name="body">The query definition</param>
		public Task<ConnectionStatus> IndicesValidateQueryPostAsync(object body, Func<IndicesValidateQueryPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_validate/query".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesValidateQueryPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/_validate/query
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/validate/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The query definition</param>
		public ConnectionStatus IndicesValidateQueryPost(string index, object body, Func<IndicesValidateQueryPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_validate/query".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesValidateQueryPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/_validate/query
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/validate/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The query definition</param>
		public Task<ConnectionStatus> IndicesValidateQueryPostAsync(string index, object body, Func<IndicesValidateQueryPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_validate/query".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesValidateQueryPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/_validate/query
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/validate/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
		///<param name="body">The query definition</param>
		public ConnectionStatus IndicesValidateQueryPost(string index, string type, object body, Func<IndicesValidateQueryPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_validate/query".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesValidateQueryPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/_validate/query
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/validate/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to restrict the operation; leave empty to perform the operation on all types</param>
		///<param name="body">The query definition</param>
		public Task<ConnectionStatus> IndicesValidateQueryPostAsync(string index, string type, object body, Func<IndicesValidateQueryPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_validate/query".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new IndicesValidateQueryPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>GET /
	    ///<pre>http://elasticsearch.org/guide/</pre>	
	    ///</summary>
		public ConnectionStatus InfoGet(Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			var url = "/";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequest("GET", url, nv);
		}
		
		///<summary>GET /
	    ///<pre>http://elasticsearch.org/guide/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> InfoGetAsync(Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			var url = "/";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequestAsync("GET", url, nv);
		}
		
		///<summary>HEAD /
	    ///<pre>http://elasticsearch.org/guide/</pre>	
	    ///</summary>
		public ConnectionStatus InfoHead(Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			var url = "/";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequest("HEAD", url, nv);
		}
		
		///<summary>HEAD /
	    ///<pre>http://elasticsearch.org/guide/</pre>	
	    ///</summary>
		public Task<ConnectionStatus> InfoHeadAsync(Func<FluentQueryString, NameValueCollection> queryString = null)
		{
			var url = "/";
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new FluentQueryString());

			return this.DoRequestAsync("HEAD", url, nv);
		}
		
		///<summary>GET /_mget
	    ///<pre>http://elasticsearch.org/guide/reference/api/multi-get/</pre>	
	    ///</summary>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		public ConnectionStatus MgetGet(object body, Func<MgetGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_mget".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MgetGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /_mget
	    ///<pre>http://elasticsearch.org/guide/reference/api/multi-get/</pre>	
	    ///</summary>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		public Task<ConnectionStatus> MgetGetAsync(object body, Func<MgetGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_mget".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MgetGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/_mget
	    ///<pre>http://elasticsearch.org/guide/reference/api/multi-get/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		public ConnectionStatus MgetGet(string index, object body, Func<MgetGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_mget".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MgetGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/_mget
	    ///<pre>http://elasticsearch.org/guide/reference/api/multi-get/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		public Task<ConnectionStatus> MgetGetAsync(string index, object body, Func<MgetGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_mget".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MgetGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/{type}/_mget
	    ///<pre>http://elasticsearch.org/guide/reference/api/multi-get/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		public ConnectionStatus MgetGet(string index, string type, object body, Func<MgetGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_mget".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MgetGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/{type}/_mget
	    ///<pre>http://elasticsearch.org/guide/reference/api/multi-get/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		public Task<ConnectionStatus> MgetGetAsync(string index, string type, object body, Func<MgetGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_mget".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MgetGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>POST /_mget
	    ///<pre>http://elasticsearch.org/guide/reference/api/multi-get/</pre>	
	    ///</summary>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		public ConnectionStatus MgetPost(object body, Func<MgetPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_mget".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MgetPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /_mget
	    ///<pre>http://elasticsearch.org/guide/reference/api/multi-get/</pre>	
	    ///</summary>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		public Task<ConnectionStatus> MgetPostAsync(object body, Func<MgetPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_mget".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MgetPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/_mget
	    ///<pre>http://elasticsearch.org/guide/reference/api/multi-get/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		public ConnectionStatus MgetPost(string index, object body, Func<MgetPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_mget".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MgetPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/_mget
	    ///<pre>http://elasticsearch.org/guide/reference/api/multi-get/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		public Task<ConnectionStatus> MgetPostAsync(string index, object body, Func<MgetPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_mget".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MgetPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/_mget
	    ///<pre>http://elasticsearch.org/guide/reference/api/multi-get/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		public ConnectionStatus MgetPost(string index, string type, object body, Func<MgetPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_mget".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MgetPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/_mget
	    ///<pre>http://elasticsearch.org/guide/reference/api/multi-get/</pre>	
	    ///</summary>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">Document identifiers; can be either `docs` (containing full document information) or `ids` (when index and type is provided in the URL.</param>
		public Task<ConnectionStatus> MgetPostAsync(string index, string type, object body, Func<MgetPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_mget".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MgetPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>GET /{index}/{type}/{id}/_mlt
	    ///<pre>http://elasticsearch.org/guide/reference/api/more-like-this/</pre>	
	    ///</summary>
		///<param name="id">The document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document (use `_all` to fetch the first document matching the ID across all types)</param>
		///<param name="body">A specific search request definition</param>
		public ConnectionStatus MltGet(string id, string index, string type, object body, Func<MltGetQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}/_mlt".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MltGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/{type}/{id}/_mlt
	    ///<pre>http://elasticsearch.org/guide/reference/api/more-like-this/</pre>	
	    ///</summary>
		///<param name="id">The document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document (use `_all` to fetch the first document matching the ID across all types)</param>
		///<param name="body">A specific search request definition</param>
		public Task<ConnectionStatus> MltGetAsync(string id, string index, string type, object body, Func<MltGetQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}/_mlt".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MltGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/{id}/_mlt
	    ///<pre>http://elasticsearch.org/guide/reference/api/more-like-this/</pre>	
	    ///</summary>
		///<param name="id">The document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document (use `_all` to fetch the first document matching the ID across all types)</param>
		///<param name="body">A specific search request definition</param>
		public ConnectionStatus MltPost(string id, string index, string type, object body, Func<MltPostQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}/_mlt".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MltPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/{id}/_mlt
	    ///<pre>http://elasticsearch.org/guide/reference/api/more-like-this/</pre>	
	    ///</summary>
		///<param name="id">The document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document (use `_all` to fetch the first document matching the ID across all types)</param>
		///<param name="body">A specific search request definition</param>
		public Task<ConnectionStatus> MltPostAsync(string id, string index, string type, object body, Func<MltPostQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}/_mlt".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MltPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>GET /_msearch
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/multi-search/</pre>	
	    ///</summary>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		public ConnectionStatus MsearchGet(object body, Func<MsearchGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_msearch".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MsearchGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /_msearch
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/multi-search/</pre>	
	    ///</summary>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		public Task<ConnectionStatus> MsearchGetAsync(object body, Func<MsearchGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_msearch".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MsearchGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/_msearch
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/multi-search/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to use as default</param>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		public ConnectionStatus MsearchGet(string index, object body, Func<MsearchGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_msearch".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MsearchGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/_msearch
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/multi-search/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to use as default</param>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		public Task<ConnectionStatus> MsearchGetAsync(string index, object body, Func<MsearchGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_msearch".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MsearchGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/{type}/_msearch
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/multi-search/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to use as default</param>
		///<param name="type">A comma-separated list of document types to use as default</param>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		public ConnectionStatus MsearchGet(string index, string type, object body, Func<MsearchGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_msearch".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MsearchGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/{type}/_msearch
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/multi-search/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to use as default</param>
		///<param name="type">A comma-separated list of document types to use as default</param>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		public Task<ConnectionStatus> MsearchGetAsync(string index, string type, object body, Func<MsearchGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_msearch".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MsearchGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>POST /_msearch
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/multi-search/</pre>	
	    ///</summary>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		public ConnectionStatus MsearchPost(object body, Func<MsearchPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_msearch".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MsearchPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /_msearch
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/multi-search/</pre>	
	    ///</summary>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		public Task<ConnectionStatus> MsearchPostAsync(object body, Func<MsearchPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_msearch".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MsearchPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/_msearch
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/multi-search/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to use as default</param>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		public ConnectionStatus MsearchPost(string index, object body, Func<MsearchPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_msearch".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MsearchPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/_msearch
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/multi-search/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to use as default</param>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		public Task<ConnectionStatus> MsearchPostAsync(string index, object body, Func<MsearchPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_msearch".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MsearchPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/_msearch
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/multi-search/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to use as default</param>
		///<param name="type">A comma-separated list of document types to use as default</param>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		public ConnectionStatus MsearchPost(string index, string type, object body, Func<MsearchPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_msearch".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MsearchPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/_msearch
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/multi-search/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to use as default</param>
		///<param name="type">A comma-separated list of document types to use as default</param>
		///<param name="body">The request definitions (metadata-search request definition pairs), separated by newlines</param>
		public Task<ConnectionStatus> MsearchPostAsync(string index, string type, object body, Func<MsearchPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_msearch".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new MsearchPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>GET /{index}/{type}/_percolate
	    ///<pre>http://elasticsearch.org/guide/reference/api/percolate/</pre>	
	    ///</summary>
		///<param name="index">The name of the index with a registered percolator query</param>
		///<param name="type">The document type</param>
		///<param name="body">The document (`doc`) to percolate against registered queries; optionally also a `query` to limit the percolation to specific registered queries</param>
		public ConnectionStatus PercolateGet(string index, string type, object body, Func<PercolateGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_percolate".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new PercolateGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/{type}/_percolate
	    ///<pre>http://elasticsearch.org/guide/reference/api/percolate/</pre>	
	    ///</summary>
		///<param name="index">The name of the index with a registered percolator query</param>
		///<param name="type">The document type</param>
		///<param name="body">The document (`doc`) to percolate against registered queries; optionally also a `query` to limit the percolation to specific registered queries</param>
		public Task<ConnectionStatus> PercolateGetAsync(string index, string type, object body, Func<PercolateGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_percolate".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new PercolateGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/_percolate
	    ///<pre>http://elasticsearch.org/guide/reference/api/percolate/</pre>	
	    ///</summary>
		///<param name="index">The name of the index with a registered percolator query</param>
		///<param name="type">The document type</param>
		///<param name="body">The document (`doc`) to percolate against registered queries; optionally also a `query` to limit the percolation to specific registered queries</param>
		public ConnectionStatus PercolatePost(string index, string type, object body, Func<PercolatePostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_percolate".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new PercolatePostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/_percolate
	    ///<pre>http://elasticsearch.org/guide/reference/api/percolate/</pre>	
	    ///</summary>
		///<param name="index">The name of the index with a registered percolator query</param>
		///<param name="type">The document type</param>
		///<param name="body">The document (`doc`) to percolate against registered queries; optionally also a `query` to limit the percolation to specific registered queries</param>
		public Task<ConnectionStatus> PercolatePostAsync(string index, string type, object body, Func<PercolatePostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_percolate".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new PercolatePostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>GET /_search/scroll
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/scroll/</pre>	
	    ///</summary>
		///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
		public ConnectionStatus ScrollGet(object body, Func<ScrollGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_search/scroll".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ScrollGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /_search/scroll
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/scroll/</pre>	
	    ///</summary>
		///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
		public Task<ConnectionStatus> ScrollGetAsync(object body, Func<ScrollGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_search/scroll".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ScrollGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>GET /_search/scroll/{scroll_id}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/scroll/</pre>	
	    ///</summary>
		///<param name="scroll_id">The scroll ID</param>
		///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
		public ConnectionStatus ScrollGet(string scroll_id, object body, Func<ScrollGetQueryString, NameValueCollection> queryString = null)
		{
			scroll_id.ThrowIfNull("scroll_id");
			var url = "/_search/scroll/{scroll_id}".Inject(new { scroll_id = scroll_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ScrollGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /_search/scroll/{scroll_id}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/scroll/</pre>	
	    ///</summary>
		///<param name="scroll_id">The scroll ID</param>
		///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
		public Task<ConnectionStatus> ScrollGetAsync(string scroll_id, object body, Func<ScrollGetQueryString, NameValueCollection> queryString = null)
		{
			scroll_id.ThrowIfNull("scroll_id");
			var url = "/_search/scroll/{scroll_id}".Inject(new { scroll_id = scroll_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ScrollGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>POST /_search/scroll
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/scroll/</pre>	
	    ///</summary>
		///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
		public ConnectionStatus ScrollPost(object body, Func<ScrollPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_search/scroll".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ScrollPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /_search/scroll
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/scroll/</pre>	
	    ///</summary>
		///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
		public Task<ConnectionStatus> ScrollPostAsync(object body, Func<ScrollPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_search/scroll".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ScrollPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /_search/scroll/{scroll_id}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/scroll/</pre>	
	    ///</summary>
		///<param name="scroll_id">The scroll ID</param>
		///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
		public ConnectionStatus ScrollPost(string scroll_id, object body, Func<ScrollPostQueryString, NameValueCollection> queryString = null)
		{
			scroll_id.ThrowIfNull("scroll_id");
			var url = "/_search/scroll/{scroll_id}".Inject(new { scroll_id = scroll_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ScrollPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /_search/scroll/{scroll_id}
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/scroll/</pre>	
	    ///</summary>
		///<param name="scroll_id">The scroll ID</param>
		///<param name="body">The scroll ID if not passed by URL or query parameter.</param>
		public Task<ConnectionStatus> ScrollPostAsync(string scroll_id, object body, Func<ScrollPostQueryString, NameValueCollection> queryString = null)
		{
			scroll_id.ThrowIfNull("scroll_id");
			var url = "/_search/scroll/{scroll_id}".Inject(new { scroll_id = scroll_id });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new ScrollPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>GET /_search
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/</pre>	
	    ///</summary>
		///<param name="body">The search definition using the Query DSL</param>
		public ConnectionStatus SearchGet(object body, Func<SearchGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_search".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SearchGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /_search
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/</pre>	
	    ///</summary>
		///<param name="body">The search definition using the Query DSL</param>
		public Task<ConnectionStatus> SearchGetAsync(object body, Func<SearchGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_search".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SearchGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/_search
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The search definition using the Query DSL</param>
		public ConnectionStatus SearchGet(string index, object body, Func<SearchGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_search".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SearchGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/_search
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The search definition using the Query DSL</param>
		public Task<ConnectionStatus> SearchGetAsync(string index, object body, Func<SearchGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_search".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SearchGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/{type}/_search
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
		///<param name="body">The search definition using the Query DSL</param>
		public ConnectionStatus SearchGet(string index, string type, object body, Func<SearchGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_search".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SearchGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/{type}/_search
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
		///<param name="body">The search definition using the Query DSL</param>
		public Task<ConnectionStatus> SearchGetAsync(string index, string type, object body, Func<SearchGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_search".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SearchGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>POST /_search
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/</pre>	
	    ///</summary>
		///<param name="body">The search definition using the Query DSL</param>
		public ConnectionStatus SearchPost(object body, Func<SearchPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_search".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SearchPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /_search
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/</pre>	
	    ///</summary>
		///<param name="body">The search definition using the Query DSL</param>
		public Task<ConnectionStatus> SearchPostAsync(object body, Func<SearchPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_search".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SearchPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/_search
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The search definition using the Query DSL</param>
		public ConnectionStatus SearchPost(string index, object body, Func<SearchPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_search".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SearchPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/_search
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The search definition using the Query DSL</param>
		public Task<ConnectionStatus> SearchPostAsync(string index, object body, Func<SearchPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_search".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SearchPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/_search
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
		///<param name="body">The search definition using the Query DSL</param>
		public ConnectionStatus SearchPost(string index, string type, object body, Func<SearchPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_search".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SearchPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/_search
	    ///<pre>http://www.elasticsearch.org/guide/reference/api/search/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to search; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="type">A comma-separated list of document types to search; leave empty to perform the operation on all types</param>
		///<param name="body">The search definition using the Query DSL</param>
		public Task<ConnectionStatus> SearchPostAsync(string index, string type, object body, Func<SearchPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/_search".Inject(new { index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SearchPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /_suggest
	    ///<pre>http://elasticsearch.org/guide/reference/api/search/suggest/</pre>	
	    ///</summary>
		///<param name="body">The request definition</param>
		public ConnectionStatus SuggestPost(object body, Func<SuggestPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_suggest".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SuggestPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /_suggest
	    ///<pre>http://elasticsearch.org/guide/reference/api/search/suggest/</pre>	
	    ///</summary>
		///<param name="body">The request definition</param>
		public Task<ConnectionStatus> SuggestPostAsync(object body, Func<SuggestPostQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_suggest".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SuggestPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/_suggest
	    ///<pre>http://elasticsearch.org/guide/reference/api/search/suggest/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The request definition</param>
		public ConnectionStatus SuggestPost(string index, object body, Func<SuggestPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_suggest".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SuggestPostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/_suggest
	    ///<pre>http://elasticsearch.org/guide/reference/api/search/suggest/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The request definition</param>
		public Task<ConnectionStatus> SuggestPostAsync(string index, object body, Func<SuggestPostQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_suggest".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SuggestPostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
		
		///<summary>GET /_suggest
	    ///<pre>http://elasticsearch.org/guide/reference/api/search/suggest/</pre>	
	    ///</summary>
		///<param name="body">The request definition</param>
		public ConnectionStatus SuggestGet(object body, Func<SuggestGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_suggest".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SuggestGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /_suggest
	    ///<pre>http://elasticsearch.org/guide/reference/api/search/suggest/</pre>	
	    ///</summary>
		///<param name="body">The request definition</param>
		public Task<ConnectionStatus> SuggestGetAsync(object body, Func<SuggestGetQueryString, NameValueCollection> queryString = null)
		{
			var url = "/_suggest".Inject(new {  });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SuggestGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/_suggest
	    ///<pre>http://elasticsearch.org/guide/reference/api/search/suggest/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The request definition</param>
		public ConnectionStatus SuggestGet(string index, object body, Func<SuggestGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_suggest".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SuggestGetQueryString());

			return this.DoRequest("GET", url, body, nv);
		}
		
		///<summary>GET /{index}/_suggest
	    ///<pre>http://elasticsearch.org/guide/reference/api/search/suggest/</pre>	
	    ///</summary>
		///<param name="index">A comma-separated list of index names to restrict the operation; use `_all` or empty string to perform the operation on all indices</param>
		///<param name="body">The request definition</param>
		public Task<ConnectionStatus> SuggestGetAsync(string index, object body, Func<SuggestGetQueryString, NameValueCollection> queryString = null)
		{
			index.ThrowIfNull("index");
			var url = "/{index}/_suggest".Inject(new { index = index });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new SuggestGetQueryString());

			return this.DoRequestAsync("GET", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/{id}/_update
	    ///<pre>http://elasticsearch.org/guide/reference/api/update/</pre>	
	    ///</summary>
		///<param name="id">Document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The request definition using either `script` or partial `doc`</param>
		public ConnectionStatus UpdatePost(string id, string index, string type, object body, Func<UpdatePostQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}/_update".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new UpdatePostQueryString());

			return this.DoRequest("POST", url, body, nv);
		}
		
		///<summary>POST /{index}/{type}/{id}/_update
	    ///<pre>http://elasticsearch.org/guide/reference/api/update/</pre>	
	    ///</summary>
		///<param name="id">Document ID</param>
		///<param name="index">The name of the index</param>
		///<param name="type">The type of the document</param>
		///<param name="body">The request definition using either `script` or partial `doc`</param>
		public Task<ConnectionStatus> UpdatePostAsync(string id, string index, string type, object body, Func<UpdatePostQueryString, NameValueCollection> queryString = null)
		{
			id.ThrowIfNull("id");
			index.ThrowIfNull("index");
			type.ThrowIfNull("type");
			var url = "/{index}/{type}/{id}/_update".Inject(new { id = id, index = index, type = type });
			NameValueCollection nv = null;
			if (queryString != null)
				nv = queryString(new UpdatePostQueryString());

			return this.DoRequestAsync("POST", url, body, nv);
		}
	
	  }
	  }
	