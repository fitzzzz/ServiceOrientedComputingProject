using clientMonitoring.MonitoringReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientMonitoring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            MonitoringServiceClient monitoringClient = new MonitoringServiceClient();
            DataLogs log = monitoringClient.GetLogs(startDate.Value.Date, endDate.Value.Date);

            this.numberOfRequestText.Text      = log.numberOfRequest.ToString();
            this.numberOfClientsText.Text      = log.numberOfClientRequest.ToString();
            this.numberOfRequestToAPIText.Text = log.numberOfAPIRequest.ToString();
        }

    }
}
