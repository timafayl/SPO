using System;
using System.Windows.Forms;
using FuelCalculation;

namespace TravelingSuccessCalculationView.Controls
{
    public partial class HelicopterControl : UserControl
    {
        private Helicopter _helicopter = new Helicopter();
        private bool _readonly;

        public HelicopterControl()
        {
            InitializeComponent();
        }

        public Helicopter Helicopter
        {
            set
            {
                if (value == null)
                {
                    return;
                }
                _helicopter = value;
                TNameTextBox.Text = Convert.ToString(_helicopter.TransportName);
                WearRateTextBox.Text = Convert.ToString(_helicopter.WearRate);
                FuelWasteTextBox.Text = Convert.ToString(_helicopter.FuelWaste);
                SpeedTextBox.Text = Convert.ToString(_helicopter.Speed);
                TankVolumeTextBox.Text = Convert.ToString(_helicopter.TankVolume);
                MassTextBox.Text = Convert.ToString(_helicopter.Mass);
            }
            get
            {
                if (TNameTextBox.Text != "" && WearRateTextBox.Text != "" && FuelWasteTextBox.Text != "" &&
                    SpeedTextBox.Text != "" && TankVolumeTextBox.Text != "" && MassTextBox.Text != "") {
                    _helicopter.TransportName = TNameTextBox.Text;
                    _helicopter.WearRate = ConvertToDouble(WearRateTextBox.Text, "WearRate");
                    _helicopter.FuelWaste = ConvertToDouble(FuelWasteTextBox.Text, "FuelWaste");
                    _helicopter.Speed = ConvertToDouble(SpeedTextBox.Text, "Speed");
                    _helicopter.TankVolume = ConvertToDouble(TankVolumeTextBox.Text, "TankVolume");
                    _helicopter.Mass = ConvertToDouble(MassTextBox.Text, "Mass");
                }
                return _helicopter;
            }
        }

        private double ConvertToDouble(string value, string fieldname)
        {
            double setting_value;
            try
            {
                setting_value = Convert.ToDouble(value);
            }
            catch (FormatException)
            {
                throw new FormatException(fieldname + " have to contain digits only");
            }
            return setting_value;
        }

        public bool ReadOnly
        {
            set
            {
                _readonly = value;
                TNameTextBox.ReadOnly = value;
                WearRateTextBox.ReadOnly = value;
                FuelWasteTextBox.ReadOnly = value;
                SpeedTextBox.ReadOnly = value;
                TankVolumeTextBox.ReadOnly = value;
                MassTextBox.ReadOnly = value;
            }
            get
            {
                return _readonly;
            }
        }

        public bool IsHelicopterFieldEmpty
        {
            get
            {
                return (TNameTextBox.Text == string.Empty || WearRateTextBox.Text == string.Empty ||
                    FuelWasteTextBox.Text == string.Empty || SpeedTextBox.Text == string.Empty ||
                    TankVolumeTextBox.Text == string.Empty || MassTextBox.Text == string.Empty);
            }
        }
    }
}
