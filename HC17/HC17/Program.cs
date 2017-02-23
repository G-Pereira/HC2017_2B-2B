﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication4
{
    public class Endpoint
    {
        public uint id { get; set; }
        public uint nCacheServers { get; set; }
        public uint dc_latency { get; set; }
        public CacheServer[] cache_servers { get; set; }
    }

	public class CacheServer
	{
		public uint id { get; set; }
		public uint latency { get; set; }
	}

	public class VideoRequest
	{
		public uint id { get; set; }
		public uint endpoint { get; set; }
		public uint nRequests { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			// Open the file.
			System.IO.StreamReader file = new System.IO.StreamReader("c:\\kittens.in");

			string line;
			string[] lines;
			uint nVideos=0;
			uint nEndpoints=0;
			uint nRequests=0;
			uint nCacheServers=0;
			uint cacheServersCapacity=0;

			if((line = file.ReadLine()) != null) {
				lines=line.Split(' ');
				nVideos					= Convert.ToUInt32(lines[0]);
				nEndpoints				= Convert.ToUInt32(lines[1]);
				nRequests				= Convert.ToUInt32(lines[2]);
				nCacheServers			= Convert.ToUInt32(lines[3]);
				cacheServersCapacity	= Convert.ToUInt32(lines[4]);
			}

			List<uint> videos=new List<uint>();

			if (((line = file.ReadLine()) != null))	// Ler a segunda linha
			{
				foreach (var a in line.Split(' ')){
					videos.Add(Convert.ToUInt32(a));
				}
			}
			Console.WriteLine("Read "+videos.Count() +" videos.");
			Console.WriteLine("Need to read " + nEndpoints + " endpoints.");

            List<Endpoint> endpoints = new List<Endpoint>();

            for (int i=0; i< nEndpoints; i++)
			{
                Endpoint endpoint = new Endpoint();
                line = file.ReadLine();
                endpoint.dc_latency= Convert.ToUInt32(line.Split(' ')[0]);
                endpoint.nCacheServers = Convert.ToUInt32(line.Split(' ')[1]);
                CacheServer cachesrv;
                // READ Cache Server
                endpoints.Add(endpoint);
			}

			//if (((line = file.ReadLine()) != null)) // Ler a segunda linha
			//{
			//	foreach (var a in line.Split(' '))
			//	{
			//		videos.Add(Convert.ToUInt32(a));
			//	}
			//}

			// Suspend the screen.
			Console.ReadLine();
		}
	}

    


}
