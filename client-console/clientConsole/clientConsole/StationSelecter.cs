using clientConsole.VelibServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientConsole
{
    class StationSelecter
    {
        private VelibServiceClient client = new VelibServiceClient();

        public void DisplayStations(String city)
        {
            VelibStation[] stations = client.getStations(city);
            
            foreach (VelibStation station in stations)
            {
                Console.WriteLine("\t" + station.stationName);
            }
        }
        

        public VelibStation SelectStations(String city)
        {
            VelibStation station = null;

            int stationID;
            while (station == null)
            {
                Console.Write("Veuillez selectionner le numéro de la station voulue : ");
                if (int.TryParse(Console.ReadLine(), out stationID))
                {
                    try
                    {
                        station = client.getStation(city, stationID);
                    } catch (Exception e)
                    {
                        Console.WriteLine("Numéro de station incorrect");
                    }
                }
            }
            return station;
        }

    }
}
