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
        private static Logger    logger      = new Logger();
        

        public VelibStation getStation(string cityID, int stationID)
        {
            logger.logCurrentRequest();
            VelibStation result = this.apiRequeter.getCityInformation(cityID, stationID);
            logger.addEntryToCache();
            return result;
        }

        public List<VelibStation> getStations(string cityID)
        {
            logger.logCurrentRequest();
            List<VelibStation> result = this.apiRequeter.getAllStation(cityID);
            logger.addEntryToCache();
            return result;
        }
    }
}
