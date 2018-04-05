using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clientConsole.VelibService;

namespace clientConsole
{
    class VelibServiceCallbackSink : VelibService.IVelibServiceCallback
    {
        public void GetStationEvent(string cityID, int stationID, VelibStation station)
        {
            Console.WriteLine("Information de la station : " + station.stationName);
            Console.WriteLine("\tNombre de points d'attaches : " + station.numberOfPointAttache);
            Console.WriteLine("\tNombre de points d'attaches disponibles : " + station.numberOfPointAttacheAvailable);
            Console.WriteLine("\tAdresse : " + station.address);
            Console.WriteLine("\tNombre de vélos disponibles : " + station.availableBikes);
            Console.WriteLine("\tPaiement par carte : " + ((station.banking == true) ? "Oui" : "Non"));
        }

        public void GetStationsEvent(string cityID, VelibStation[] result)
        {
            foreach (VelibStation station in result)
            {
                Console.WriteLine("\t" + station.stationName);
            }
        }
    }
}
