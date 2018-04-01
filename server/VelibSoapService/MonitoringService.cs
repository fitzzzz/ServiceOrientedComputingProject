using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelibSoapService
{
    class MonitoringService : IMonitoringService
    {
        private Logger logger = new Logger();

        public int GetNumberOfRequest()
        {
            return logger.getNumbeOfReQuest();
        }

        public int GetNumberOfClients()
        {
            return logger.getNumberOfClients();
        }

        public int GetNumberOfRequestToAPI()
        {
            return logger.getNumberOfAPIRequest();
        }

        public DataLogs GetLogs(DateTime start, DateTime end)
        {
            return logger.getLogs(start, end);
        }
    }
}
