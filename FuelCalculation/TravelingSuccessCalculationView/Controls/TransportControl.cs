using System;
using System.Windows.Forms;
using FuelCalculation;
using System.Drawing;

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
                TransportTypeComboBox.Enabled = !value;
                if (TransportTypeComboBox.Enabled == false)
                {
                    TransportTypeComboBox.ForeColor = SystemColors.Info;
                    TransportTypeComboBox.BackColor = SystemColors.InactiveCaptionText;
                }
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

        public bool IsFieldEmpty => 
            (TransportTypeComboBox.SelectedIndex == 0) ? CarControl.IsCarFieldEmpty :
            (TransportTypeComboBox.SelectedIndex == 1) ? HelicopterControl.IsHelicopterFieldEmpty : true;

        public int TransportType
        {
            get { return TransportTypeComboBox.SelectedIndex; }
            set { TransportTypeComboBox.SelectedIndex = value; }
        }
    }
}
