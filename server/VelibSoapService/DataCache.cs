using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelibSoapService
{
    class DataCache
    {
        private static DataTable dataTable = null;

        public DataCache()
        {
            if (dataTable == null)
            {
                dataTable = new DataTable();
                DataColumn stationColumn = new DataColumn("station");
                stationColumn.DataType = typeof(VelibStation);
                stationColumn.ColumnName = "station";

                DataColumn timeColumn = new DataColumn("time");
                timeColumn.DataType = typeof(DateTime);
                timeColumn.ColumnName = "time";

                DataColumn stationIDcolumn = new DataColumn("stationId");
                stationIDcolumn.DataType = System.Type.GetType("System.Int32");
                stationIDcolumn.ColumnName = "stationId";

                DataColumn cityIDcolumn = new DataColumn("cityId");
                cityIDcolumn.DataType = System.Type.GetType("System.String");
                cityIDcolumn.ColumnName = "cityId";

                dataTable.Columns.Add(stationIDcolumn);
                dataTable.Columns.Add(cityIDcolumn);
                dataTable.Columns.Add(stationColumn);
                dataTable.Columns.Add(timeColumn);

                DataColumn[] PrimaryKeyColumns = new DataColumn[2];
                PrimaryKeyColumns[0] = dataTable.Columns["stationId"];
                PrimaryKeyColumns[1] = dataTable.Columns["cityId"];
                dataTable.PrimaryKey = PrimaryKeyColumns;
            }
        }

        private void deleteOldEntry(VelibStation station, string cityId)
        {
            string expression = "stationId = " + station.stationNumber + " And cityId = '" + cityId + "'";
            DataRow[] foundRows = dataTable.Select(expression);
            if (foundRows.Length > 0)
                foundRows[0].Delete();
        }

        public void addToCache(VelibStation station, string cityId)
        {
            this.deleteOldEntry(station, cityId);
            DataRow data = dataTable.NewRow();
            data[0] = station.stationNumber; // station id
            data[1] = cityId; // city ID
            data[2] = station;
            data[3] = DateTime.Today;

            dataTable.Rows.Add(data);
            return;
        }

        public VelibStation getVelibStationFromCache(int stationID, string cityID)
        {
            string expression = "stationId = " + stationID + " And cityId = '" + cityID + "'";
            DataRow[] foundRows = dataTable.Select(expression);
            if (foundRows.Length <= 0)
                return null;

            DateTime time        = (DateTime)foundRows[0][3];
            DateTime currentTime = DateTime.Today;
            if ((currentTime - time).TotalMinutes >= 5)
            {
                foundRows[0].Delete();
                return null;
            }
            return (VelibStation)foundRows[0][2];
        }

        public List<VelibStation> getVelibStationsFromCache(string cityID)
        {
            string expression = "cityId = '" + cityID + "'";
            DataRow[] foundRows = dataTable.Select(expression);
            if (foundRows.Length <= 0)
                return null;

            DateTime time = (DateTime)foundRows[0][3];
            DateTime currentTime = DateTime.Today;
            if ((currentTime - time).TotalMinutes >= 5)
            {
                foreach (DataRow row in foundRows)
                    row.Delete();
                return null;
            }

            List<VelibStation> stations = new List<VelibStation>();
            foreach (DataRow row in foundRows)
                stations.Add((VelibStation)row[2]);
            return stations;
        }

    }
}
