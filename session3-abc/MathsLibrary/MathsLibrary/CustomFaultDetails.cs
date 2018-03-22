using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    [DataContract]
    class CustomFaultDetails
    {
        private int errorID;
        private string errorDetails;

        [DataMember]
        public int ErrorID { get => errorID; set => errorID = value; }

        [DataMember]
        public string ErrorDetails { get => errorDetails; set => errorDetails = value; }
    }
}
