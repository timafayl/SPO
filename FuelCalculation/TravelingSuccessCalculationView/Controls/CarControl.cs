using System;
using System.Windows.Forms;
using FuelCalculation;

namespace TravelingSuccessCalculationView.Controls
{
    public partial class CarControl : UserControl
    {
        private Car _car = new Car();
        private bool _readonly;

        public CarControl()
        {
            InitializeComponent();
        }

        public Car Car
        {
            set
            {
                if (value == null)
                {
                    return;
                }
                _car = value;
                TNameTextBox.Text = Convert.ToString(_car.TransportName);
                WearRateTextBox.Text = Convert.ToString(_car.WearRate);
                FuelWasteTextBox.Text = Convert.ToString(_car.FuelWaste);
                SpeedTextBox.Text = Convert.ToString(_car.Speed);
                TankVolumeTextBox.Text = Convert.ToString(_car.TankVolume);
                FuelTypeComboBox.Text = Convert.ToString(_car.FuelType);
            }
            get
            {
                if (TNameTextBox.Text != "" && WearRateTextBox.Text != "" && FuelWasteTextBox.Text != "" &&
                   SpeedTextBox.Text != "" && TankVolumeTextBox.Text != "" && FuelTypeComboBox.Text != "")
                {
                    _car.TransportName = TNameTextBox.Text;
                    _car.WearRate = ConvertToDouble(WearRateTextBox.Text, "WearRate");
                    _car.FuelWaste = ConvertToDouble(FuelWasteTextBox.Text, "FuelWaste");
                    _car.Speed = ConvertToDouble(SpeedTextBox.Text, "Speed");
                    _car.TankVolume = ConvertToDouble(TankVolumeTextBox.Text, "TankVolume");
                    _car.FuelType = (FuelType)Enum.Parse(typeof(FuelType), FuelTypeComboBox.Text);
                }
                return _car;
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
            }
            get
            {
                return _readonly;
            }
        }
    }
}
