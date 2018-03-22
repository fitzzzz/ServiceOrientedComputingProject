using MathLibraryGUI.MathsOperationService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathLibraryGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(this.nombre1TextBox.Text);
            int number2 = Int32.Parse(this.nombre2TextBox.Text);
            MathsOperationsClient client1 = new MathsOperationsClient("Endpoint1");
            MathsOperationsClient client2 = new MathsOperationsClient("Endpoint2");
            MathsOperationsClient client3 = new MathsOperationsClient("Endpoint3");


            this.resultEndpoint1Text.Text = client1.Add(number1, number2).ToString();
            this.resultEndpoint2Text.Text = client2.Add(number1, number2).ToString();
            this.resultEndpoint3Text.Text = client3.Add(number1, number2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(this.nombre1TextBox.Text);
            int number2 = Int32.Parse(this.nombre2TextBox.Text);
            MathsOperationsClient client1 = new MathsOperationsClient("Endpoint1");
            MathsOperationsClient client2 = new MathsOperationsClient("Endpoint2");
            MathsOperationsClient client3 = new MathsOperationsClient("Endpoint3");


            this.resultEndpoint1Text.Text = client1.Multiply(number1, number2).ToString();
            this.resultEndpoint2Text.Text = client2.Multiply(number1, number2).ToString();
            this.resultEndpoint3Text.Text = client3.Multiply(number1, number2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number1 = Int32.Parse(this.nombre1TextBox.Text);
            int number2 = Int32.Parse(this.nombre2TextBox.Text);
            MathsOperationsClient client1 = new MathsOperationsClient("Endpoint1");
            MathsOperationsClient client2 = new MathsOperationsClient("Endpoint2");
            MathsOperationsClient client3 = new MathsOperationsClient("Endpoint3");


            this.resultEndpoint1Text.Text = client1.Divide(number1, number2).ToString();
            this.resultEndpoint2Text.Text = client2.Divide(number1, number2).ToString();
            this.resultEndpoint3Text.Text = client3.Divide(number1, number2).ToString();
        }
    }
}
