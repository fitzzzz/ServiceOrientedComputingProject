using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VelibSoapService
{
    [ServiceContract]
    interface IMonitoringService
    {
        [OperationContract]
        int GetNumberOfRequest();

        [OperationContract]
        int GetNumberOfClients();

        [OperationContract]
        int GetNumberOfRequestToAPI();

        [OperationContract]
        DataLogs GetLogs(DateTime start, DateTime end);
    }
}
