using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VelibSoapService
{
    public class VelibService : IVelibService
    {

        private VelibAPIRequeter apiRequeter = new VelibAPIRequeter();
        private static Logger    logger      = new Logger();

        static Action<string, int, VelibStation> getStation_Event = delegate { };
        static Action<string, List<VelibStation>> getStations_Event = delegate { };



        public void GetStation(string cityID, int stationID)
        {
            logger.logCurrentRequest();
            VelibStation result = this.apiRequeter.getCityInformation(cityID, stationID);
            logger.addEntryToCache();
            getStation_Event(cityID, stationID, result);
        }

        public void GetStations(string cityID)
        {
            logger.logCurrentRequest();
            List<VelibStation> result = this.apiRequeter.getAllStation(cityID);
            logger.addEntryToCache();
            getStations_Event(cityID, result);
        }

        public void SubscribeGetStations()
        {
            IVelibServiceEvents subscriber = OperationContext.Current.GetCallbackChannel<IVelibServiceEvents>();
            getStations_Event += subscriber.GetStationsEvent;
        }

        public void SubscribeGetStation()
        {
            IVelibServiceEvents subscriber = OperationContext.Current.GetCallbackChannel<IVelibServiceEvents>();
            getStation_Event += subscriber.GetStationEvent;
        }

    }
}
