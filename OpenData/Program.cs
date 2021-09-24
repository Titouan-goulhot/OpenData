// Instalé grâce à Nuget 
using Newtonsoft.Json;
//Les fichers System viennent du framework .NET
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using dll;

namespace OpenData
{
    class Program
    {
        static void Main(string[] args)
        {

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 |
          SecurityProtocolType.Tls;


            Transports transport = new Transports(true);


            List<Root> station = transport.GetStation();

            foreach(Root coordinat in station)
            {
                Console.WriteLine(coordinat.Id);
                Console.WriteLine(coordinat.Name);
                Console.WriteLine(coordinat.Lon);
                Console.WriteLine(coordinat.Lat);
                Console.WriteLine(coordinat.zone + "\n");
                
            }

            //Console.Write(json);
            Console.Read();
        }
    }
}
