using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VelibSoapService
{
    [ServiceContract(CallbackContract = typeof(IVelibServiceEvents))]
    public interface IVelibService
    {
        [OperationContract]
        void GetStations(string cityID);

        [OperationContract]
        void GetStation(string cityID, int stationID);

        [OperationContract]
        void SubscribeGetStations();

        [OperationContract]
        void SubscribeGetStation();

    }
}
