using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelibSoapService
{
    class LoggerCache
    {
        private static DataTable dataTable = null;

        public LoggerCache()
        {
            if (dataTable == null)
            {
                dataTable = new DataTable();
                DataColumn logColumn = new DataColumn("Logs");
                logColumn.DataType = typeof(DataLogs);
                logColumn.ColumnName = "Logs";

                DataColumn dataColumn = new DataColumn("Time");
                dataColumn.DataType = typeof(DateTime);
                dataColumn.ColumnName = "Time";

                dataTable.Columns.Add(logColumn);
                dataTable.Columns.Add(dataColumn);

                addEntry(new DataLogs());
            }
        }

        public void addEntry(DataLogs dataLogs)
        {
            DataRow row = dataTable.NewRow();
            row[0] = dataLogs;
            row[1] = DateTime.Now;
            dataTable.Rows.Add(row);
        }

        public DataLogs getLog(DateTime start, DateTime end)
        {

            string sortOrder = "Time ASC";
            string expression;
            expression = string.Format("Time >= #" + start.ToString("yyyy/MM/dd HH:mm:ss") + "#"
                + " And Time <= #" + end.ToString("yyyy/MM/dd HH:mm:ss") + "#");

                         

            DataRow[] foundRows;
            foundRows = dataTable.Select(expression, sortOrder);

            DataLogs result = null;
            if (foundRows.Length <= 0)
            {
                result = new DataLogs();
                result.numberOfAPIRequest = 0;
                result.numberOfClientRequest = 0;
                result.numberOfRequest = 0;
            } else if (foundRows.Length == 1)
            {
                result = (DataLogs)foundRows[0][0];
            } else
            {
                result = new DataLogs();
                DataLogs firstEntry = (DataLogs)foundRows[0][0];
                DataLogs lastEntry = (DataLogs)foundRows[foundRows.Length - 1][0];
                result.numberOfAPIRequest = lastEntry.numberOfAPIRequest - firstEntry.numberOfAPIRequest;
                result.numberOfClientRequest = lastEntry.numberOfClientRequest - firstEntry.numberOfClientRequest;
                result.numberOfRequest = lastEntry.numberOfRequest - firstEntry.numberOfRequest;
            }

            return result;
        }

    }
}
