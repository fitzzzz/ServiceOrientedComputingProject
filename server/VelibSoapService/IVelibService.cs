using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VelibSoapService
{
    [ServiceContract]
    public interface IVelibService
    {
        [OperationContract]
        List<VelibStation> getStations(string cityID);

        [OperationContract]
        VelibStation getStation(string cityID, int stationID);
    }
}
