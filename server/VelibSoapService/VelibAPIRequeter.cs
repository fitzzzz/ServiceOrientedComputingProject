using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VelibSoapService
{
    class VelibAPIRequeter
    {
        private string    apiKey    = "e15af7817bf0e3bb9f9d3fc8fc315c2fc94748aa";
        private string    apiURL    = "https://api.jcdecaux.com/vls/v1/stations/";
        private DataCache dataCache = new DataCache();   
    
        private string constructURL(string city, int stationID)
        {
            return this.apiURL + stationID + "?contract=" + city + "&apiKey=" + apiKey;
        }

        private string constructURL(string city)
        {
            return this.apiURL + "?contract=" + city + "&apiKey=" + apiKey; ;
        }

        private string requestURL(string urlToRequest)
        {
            WebRequest request   = WebRequest.Create(urlToRequest);
            WebResponse response = request.GetResponse();
            Stream dataStream    = response.GetResponseStream();
            StreamReader reader  = new StreamReader(dataStream);
            string responseText      =  reader.ReadToEnd();

            reader.Close();
            response.Close();
            return responseText;
        }

        public VelibStation getCityInformation(string city, int stationID)
        {
            VelibStation station;

            if ((station = dataCache.getVelibStationFromCache(stationID, city)) == null)
            {
                string urlToRequest = this.constructURL(city, stationID);
                string responseFromServer = this.requestURL(urlToRequest);
                station = JsonConvert.DeserializeObject<VelibStation>(responseFromServer);
                dataCache.addToCache(station, city);
            }

            return station;
        }

        public List<VelibStation> getAllStation(string city)
        {
            List<VelibStation> stations;

            if ((stations = dataCache.getVelibStationsFromCache(city)) == null)
            {
                string urlToRequest = this.constructURL(city);
                string responseFromServer = this.requestURL(urlToRequest);
                stations = JsonConvert.DeserializeObject<List<VelibStation>>(responseFromServer);

                foreach (VelibStation station in stations)
                {
                    dataCache.addToCache(station, city);
                }
            }

            return stations;
        }

    }
}
