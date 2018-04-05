using clientConsole.VelibService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace clientConsole
{
    class StationSelecter
    {
        private VelibServiceClient client;

        public StationSelecter(VelibServiceClient client)
        {
            this.client = client;
        }

        public void DisplayStations(String city)
        {
            client.GetStations(city);
        }
        

        public void SelectStations(String city)
        {
            int stationID;
            Console.Write("Veuillez selectionner le numéro de la station voulue : ");
            if (int.TryParse(Console.ReadLine(), out stationID))
            {
                try
                {
                    client.GetStation(city, stationID);
                } catch (Exception e)
                {
                    Console.WriteLine("Numéro de station incorrect");
                }
            }
           
        }

    }
}
