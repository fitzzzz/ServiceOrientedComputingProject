using clientConsole.VelibService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientConsole
{
    class StationCommand
    {

        private StationSelecter stationSelecter;


        public StationCommand(VelibServiceClient client)
        {
            stationSelecter = new StationSelecter(client);
        }

        public void run(String city)
        {
            stationSelecter.DisplayStations(city);
            stationSelecter.SelectStations(city);
        }

    }
}
