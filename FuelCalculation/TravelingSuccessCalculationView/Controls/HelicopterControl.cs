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

        public bool IsHelicopterFieldEmpty => 
            (TNameTextBox.Text == string.Empty || WearRateTextBox.Text == string.Empty ||
             FuelWasteTextBox.Text == string.Empty || SpeedTextBox.Text == string.Empty ||
             TankVolumeTextBox.Text == string.Empty || MassTextBox.Text == string.Empty);
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
            if (TNameTextBox.ReadOnly)
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
            if (WearRateTextBox.ReadOnly)
            {
                errorProvider.Clear();
            }
        }

        private void FuelWasteTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TNameTextBox.Text))
            {
                errorProvider.SetError(FuelWasteTextBox, "Please enter your transport fuel waste. Value have to vary from 20 to 50 (l/h)");
            }
            else
            {
                errorProvider.SetError(FuelWasteTextBox, null);
            }
            if (FuelWasteTextBox.ReadOnly)
            {
                errorProvider.Clear();
            }
        }

        private void SpeedTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SpeedTextBox.Text))
            {
                errorProvider.SetError(SpeedTextBox, "Please enter speed value. Value have to vary from 1 to 400");
            }
            else
            {
                errorProvider.SetError(SpeedTextBox, null);
            }
            if (SpeedTextBox.ReadOnly)
            {
                errorProvider.Clear();
            }
        }

        private void TankVolumeTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TankVolumeTextBox.Text))
            {
                errorProvider.SetError(TankVolumeTextBox, "Please enter transport tank volume. Value have to vary from 50 to 200");
            }
            else
            {
                errorProvider.SetError(TankVolumeTextBox, null);
            }
            if (TankVolumeTextBox.ReadOnly)
            {
                errorProvider.Clear();
            }
        }

        private void MassTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MassTextBox.Text))
            {
                errorProvider.SetError(MassTextBox, "Please enter the mass transported (1-1000 kg)");
            }
            else
            {
                errorProvider.SetError(MassTextBox, null);
            }
            if (MassTextBox.ReadOnly)
            {
                errorProvider.Clear();
            }
        }
        /*-----------------------------------------TOOL TIP-------------------------------------------------------------*/
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
            toolTip.Show("Transport fuel waste. Value have to vary from 20 to 50 (l/h)", FuelWasteTextBox);
        }

        private void SpeedTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Speed value. Value have to vary from 1 to 400", SpeedTextBox);
        }

        private void TankVolumeTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Transport tank volume. Value have to vary from 50 to 200", TankVolumeTextBox);
        }

        private void MassTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Введите массу перевозимого груза (1-1000 кг)", MassTextBox);
        }
    }
}
