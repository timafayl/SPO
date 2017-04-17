using System;
using System.Windows.Forms;
using FuelCalculation;
using TravelingSuccessCalculationView.Controls;

namespace TravelingSuccessCalculationView
{
    public partial class TransportControl : UserControl
    {
        private ITransport _transport;
        private bool _readonly;

        public TransportControl()
        {
            InitializeComponent();
        }

        public ITransport Transport
        {
            set
            {
                _transport = value;
                if (value is Car)
                {
                    CarControl.Car = value as Car;
                    TransportTypeComboBox.SelectedIndex = 0;
                }
                else if (value is Helicopter)
                {
                    HelicopterControl.Helicopter = value as Helicopter;
                    TransportTypeComboBox.SelectedIndex = 1;
                }
            }
            get
            {
                if (TransportTypeComboBox.SelectedIndex == 0)
                {
                    _transport = CarControl.Car;
                }
                else if (TransportTypeComboBox.SelectedIndex == 1)
                {
                    _transport = HelicopterControl.Helicopter;
                }
                return _transport;
            }
        }

        public bool ReadOnly {
            set
            {
                _readonly = value;
                if (TransportTypeComboBox.Text == "Car")
                {
                    CarControl.ReadOnly = value;
                }
                else if (TransportTypeComboBox.Text == "Helicopter")
                {
                    HelicopterControl.ReadOnly = value;
                }

            }
            get { return _readonly; } }

        private void TransportTypeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (TransportTypeComboBox.Text == "Car")
            {
                CarControl.Visible = true;
                HelicopterControl.Visible = false;
            }
            else
            {
                HelicopterControl.Visible = true;
                CarControl.Visible = false;
            }
        }
    }
}
