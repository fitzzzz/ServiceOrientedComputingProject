using clientConsole.VelibService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace clientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            VelibServiceClient client = new VelibServiceClient(new InstanceContext(new VelibServiceCallbackSink()));
            client.SubscribeGetStation();
            client.SubscribeGetStations();

            Shell shell = new Shell(client);
            
            shell.Run();
        }
    }
}
