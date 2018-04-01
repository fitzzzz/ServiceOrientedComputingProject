using clientConsole.VelibServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientConsole
{
    class StationCommand
    {

        private StationSelecter stationSelecter = new StationSelecter();

        private void DisplayInformation(VelibStation station)
        {
            Console.WriteLine("Information de la station : " + station.stationName);
            Console.WriteLine("\tNombre de points d'attaches : " + station.numberOfPointAttache);
            Console.WriteLine("\tNombre de points d'attaches disponibles : " + station.numberOfPointAttacheAvailable);
            Console.WriteLine("\tAdresse : " + station.address);
            Console.WriteLine("\tNombre de vélos disponibles : " + station.availableBikes);
            Console.WriteLine("\tPaiement par carte : " + ((station.banking == true) ? "Oui" : "Non" ));

        }

        public void run(String city)
        {
            stationSelecter.DisplayStations(city);
            VelibStation station = stationSelecter.SelectStations(city);
            DisplayInformation(station);
        }

    }
}
