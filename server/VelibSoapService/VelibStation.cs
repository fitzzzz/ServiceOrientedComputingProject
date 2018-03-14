using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace VelibSoapService
{
    [DataContract]
    public class VelibStation
    {
        [DataMember]
        [JsonProperty("available_bikes")]
        public int availableBikes;

        [DataMember]
        [JsonProperty("name")]
        public string stationName;

        [DataMember]
        [JsonProperty("bike_stands")]
        public int numberOfPointAttache;

        [DataMember]
        [JsonProperty("available_bike_stands")]
        public int numberOfPointAttacheAvailable;

        [DataMember]
        [JsonProperty("address")]
        public string address;

        [DataMember]
        [JsonProperty("banking")]
        public Boolean banking;

        [DataMember]
        [JsonProperty("number")]
        public int stationNumber;

    }
}
