using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
			// Open the file.
			System.IO.StreamReader file = new System.IO.StreamReader("c:\\kittens.in");

			string line;
			string[] lines;
			uint nVideos;
			uint nEndpoints;
			uint nRequests;
			uint nCacheServers;
			uint cacheServersCapacity;

			if((line = file.ReadLine()) != null) {
				lines=line.Split(' ');
				nVideos					= Convert.ToUInt32(lines[0]);
				nEndpoints				= Convert.ToUInt32(lines[1]);
				nRequests				= Convert.ToUInt32(lines[2]);
				nCacheServers			= Convert.ToUInt32(lines[3]);
				cacheServersCapacity	= Convert.ToUInt32(lines[4]);
			}

			// Suspend the screen.
			Console.ReadLine();
        }
    }


}
