using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace VelibSoapService
{
    class Logger
    {
        private static int numberOfRequest = 0;
        private static int numberOfVelibAPIRequest = 0;
        private static List<string> clients = new List<string>();
        private static LoggerCache cache = new LoggerCache();


        private void incrementNumberOfClient()
        {
            RemoteEndpointMessageProperty clientEndpoint = OperationContext.Current.
                IncomingMessageProperties[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
            String adress = clientEndpoint.Address;
            if (!clients.Contains(adress))
            {
                clients.Add(adress);
            }
        }

        public void addEntryToCache()
        {
            DataLogs log = new DataLogs();
            log.numberOfAPIRequest = numberOfVelibAPIRequest;
            log.numberOfClientRequest = getNumberOfClients();
            log.numberOfRequest = numberOfRequest;
            cache.addEntry(log);
        }


        public int getNumberOfAPIRequest()
        {
            return numberOfVelibAPIRequest;
        }

        public void incrementNumberOfVelibAPIRequest()
        {
            numberOfVelibAPIRequest += 1;
        }

        public void logCurrentRequest()
        {
            incrementNumberOfClient();
            numberOfRequest += 1;
            return;
        }

        public int getNumbeOfReQuest()
        {
            return numberOfRequest;
        }

        public int getNumberOfClients()
        {
            return clients.Count();
        }

        public DataLogs getLogs(DateTime start, DateTime end)
        {
            return cache.getLog(start, end);
        }
    }
        
}
