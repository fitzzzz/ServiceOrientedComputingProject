using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VelibSoapService
{
    [DataContract]
    class DataLogs
    {
        [DataMember]
        public int numberOfAPIRequest  { get; set; }

        [DataMember]
        public int numberOfRequest { get; set; }

        [DataMember]
        public int numberOfClientRequest { get; set; }
    }
}
