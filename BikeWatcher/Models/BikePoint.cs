using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BikeWatcher
{
    public class BikePoints
    {
// Initializing empty constructor to prevent a bug
        public BikePoints() { }
// Setting variable of BDX with the same name as Lyon have
        public BikePoints(BikePointsBDX stationBdx)
        {
            lat = stationBdx.latitude;
            lng = stationBdx.longitude;
            name = stationBdx.name;
            status = stationBdx.is_online ? "OPEN" : "CLOSED";
            available_bikes = stationBdx.bike_count_total.ToString();
        }


// Get and set for Lyon
        public string available_bikes { get; set; }
        public string lng { get; set; }
        public string status { get; set; }
        public string address { get; set; }
        public string lat { get; set; }
        public string name { get; set; }
    }

    public class RootObject
    {
        public List<string> fields { get; set; }
        public List<BikePoints> values { get; set; }
        public int nb_results { get; set; }
        public string table_href { get; set; }
        public string layer_name { get; set; }
    }
}
