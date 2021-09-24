using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll

{
    public class Root 
    {
        // Properties 
        public string Id { get; set; }
        public string Name { get; set; }
        public double Lon { get; set; }
        public double Lat { get; set; }
        public string zone { get; set; }
        public List<string> lines { get; set; }

        public string Json { get; set; }
        


        //Constructeur
        public Root(string id, string name, double lon, double lat)
        {

            Id = id;
            Name = name;
            Lon = lon;
            Lat = lat;
        }
    }






}
