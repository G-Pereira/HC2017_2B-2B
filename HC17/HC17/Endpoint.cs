namespace HC17
{
	class Endpoint
	{
		public uint id { get; set; }
		public uint nCacheServers { get; set; }
		public uint dc_latency { get; set; }
		public CacheServer[] cache_servers { get; set; } 
	}
}
