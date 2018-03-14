using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VelibGUIClient.ServiceReference1;

namespace VelibGUIClient
{
    public partial class Form1 : Form
    {

        private VelibStation[] stations;

        public Form1()
        {
            InitializeComponent();
        }

        private void makeRequest(object sender, EventArgs e)
        {
            ServiceReference1.VelibServiceClient client = new ServiceReference1.VelibServiceClient();
            VelibStation station = client.getStation(this.cityComboBox.SelectedItem.ToString(), 
                this.stations[this.stationCombobox.SelectedIndex].stationNumber); 

            this.availableBikesText.Text        = station.availableBikes.ToString();
            this.nbPointAttacheText.Text        = station.numberOfPointAttache.ToString();
            this.nbPointsAttachesDispoText.Text = station.numberOfPointAttacheAvailable.ToString();
            this.adressStationText.Text         = station.address;
            this.stationNameText.Text           = station.stationName;
            this.terminalPaiementText.Text      = (station.banking == false) ? "Non" : "Oui";
        }

        private void cityChanged(object sender, EventArgs e)
        {
            ServiceReference1.VelibServiceClient client = new ServiceReference1.VelibServiceClient();
            this.stations = client.getStations(this.cityComboBox.SelectedItem.ToString());

            this.stationCombobox.Items.Clear();
           foreach (VelibStation station in stations)
            {
                this.stationCombobox.Items.Add(station.stationName);
            }
        }
    }
}
