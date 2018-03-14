using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VelibSoapService
{
    public class VelibService : IVelibService
    {

        private VelibAPIRequeter apiRequeter = new VelibAPIRequeter();
        

        public VelibStation getStation(string cityID, int stationID)
        {
            return this.apiRequeter.getCityInformation(cityID, stationID);
        }

        public List<VelibStation> getStations(string cityID)
        {
            return this.apiRequeter.getAllStation(cityID);
        }
    }
}
