using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuelCalculation;

namespace TravelingSuccessCalculationView
{
    public partial class TransportControl : UserControl
    {
        public ITransport Transport {
            set
            {
                Transport = value;
                if (value is Car)
                {
                    TransportTypeComboBox.Text = "Car";
                    CarControl.Car = value as Car;
                }
                else
                {
                    TransportTypeComboBox.Text = "Helicopter";
                    HelicopterControl.Helicopter = value as Helicopter;
                }
            }
            get
            {
                if (TransportTypeComboBox.Text == "Car")
                {
                    Transport = CarControl.Car;
                }
                else
                {
                    Transport = HelicopterControl.Helicopter;
                }
                return Transport;
            }
        }

        public bool ReadOnly { set; get; }

        public TransportControl()
        {
            InitializeComponent();
        }

        private void TransportTypeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (TransportTypeComboBox.Text == "Car")
            {
                CarControl.Visible = true;
                HelicopterControl.Visible = false;
            }
            else
            {
                CarControl.Visible = false;
                HelicopterControl.Visible = true;
            }
        }
    }
}
