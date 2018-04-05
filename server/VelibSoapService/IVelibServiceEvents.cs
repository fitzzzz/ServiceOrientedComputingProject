using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VelibSoapService
{
    interface IVelibServiceEvents
    {
        [OperationContract(IsOneWay = true)]
        void GetStationEvent(string cityID, int stationID, VelibStation result);

        [OperationContract(IsOneWay = true)]
        void GetStationsEvent(string cityID, List<VelibStation> result);
    }
}
