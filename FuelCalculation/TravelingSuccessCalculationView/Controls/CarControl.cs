using System;
using System.Windows.Forms;
using FuelCalculation;
using System.Drawing;

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
                FuelTypeComboBox.Enabled = !value;
                if (FuelTypeComboBox.Enabled == false)
                {
                    FuelTypeComboBox.ForeColor = SystemColors.WindowText;
                    FuelTypeComboBox.BackColor = SystemColors.InactiveCaptionText;
                }
            }
            get
            {
                return _readonly;
            }
        }

        public bool IsCarFieldEmpty
        {
            get
            {
                return (TNameTextBox.Text == string.Empty || WearRateTextBox.Text == string.Empty ||
                    FuelWasteTextBox.Text == string.Empty || SpeedTextBox.Text == string.Empty ||
                    TankVolumeTextBox.Text == string.Empty || FuelTypeComboBox.Text == string.Empty);
            }
        }
/*-------------------------------------ERROR PROVIDER----------------------------------------------------------*/
        private void TNameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TNameTextBox.Text))
            {
                errorProvider.SetError(TNameTextBox, "Please enter your transport name using only a-z letters");
            }
            else
            {
                errorProvider.SetError(TNameTextBox, null);
            }
            if (TNameTextBox.ReadOnly == true)
            {
                errorProvider.Clear();
            }
        }

        private void WearRateTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(WearRateTextBox.Text))
            {
                errorProvider.SetError(WearRateTextBox, "Please enter your transport wear rate. Value have to vary from 0 to 1");
            }
            else
            {
                errorProvider.SetError(WearRateTextBox, null);
            }
            if (WearRateTextBox.ReadOnly == true)
            {
                errorProvider.Clear();
            }
        }

        private void FuelWasteTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TNameTextBox.Text))
            {
                errorProvider.SetError(FuelWasteTextBox, "Please enter your transport fuel waste. Value have to vary from 5 to 30");
            }
            else
            {
                errorProvider.SetError(FuelWasteTextBox, null);
            }
            if (FuelWasteTextBox.ReadOnly == true)
            {
                errorProvider.Clear();
            }
        }

        private void SpeedTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SpeedTextBox.Text))
            {
                errorProvider.SetError(SpeedTextBox, "Please enter speed value. Value have to vary from 1 to 180");
            }
            else
            {
                errorProvider.SetError(SpeedTextBox, null);
            }
            if (SpeedTextBox.ReadOnly == true)
            {
                errorProvider.Clear();
            }
        }

        private void TankVolumeTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TankVolumeTextBox.Text))
            {
                errorProvider.SetError(TankVolumeTextBox, "Please enter transport tank volume. Value have to vary from 20 to 100");
            }
            else
            {
                errorProvider.SetError(TankVolumeTextBox, null);
            }
            if (TankVolumeTextBox.ReadOnly == true)
            {
                errorProvider.Clear();
            }
        }

        private void FuelTypeComboBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FuelTypeComboBox.Text))
            {
                errorProvider.SetError(FuelTypeComboBox, "Please choose transport's fuel type");
            }
            else
            {
                errorProvider.SetError(FuelTypeComboBox, null);
            }
            if (WearRateTextBox.Enabled == false)
            {
                errorProvider.Clear();
            }
        }
/*-------------------------------------TOOL TIP----------------------------------------------------------------*/
        private void TNameTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Enter a transport name using a-z letters", TNameTextBox);
        }

        private void WearRateTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Transport wear rate. Value have to vary from 0 to 1", WearRateTextBox);
        }

        private void FuelWasteTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Transport fuel waste. Value have to vary from 5 to 30", FuelWasteTextBox);
        }

        private void SpeedTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Speed value. Value have to vary from 1 to 180", SpeedTextBox);
        }

        private void TankVolumeTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Transport tank volume. Value have to vary from 20 to 100", TankVolumeTextBox);
        }

        private void FuelTypeComboBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Transport fuel type", FuelTypeComboBox);
        }
    }
}
