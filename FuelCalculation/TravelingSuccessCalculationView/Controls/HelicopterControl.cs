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

namespace TravelingSuccessCalculationView.Controls
{
    public partial class HelicopterControl : UserControl
    {
        public HelicopterControl()
        {
            InitializeComponent();
        }

        public Helicopter Helicopter
        {
            set
            {
                Helicopter = value;
                TNameTextBox.Text = Convert.ToString(Helicopter.TransportName);
                WearRateTextBox.Text = Convert.ToString(Helicopter.WearRate);
                FuelWasteTextBox.Text = Convert.ToString(Helicopter.FuelWaste);
                SpeedTextBox.Text = Convert.ToString(Helicopter.Speed);
                TankVolumeTextBox.Text = Convert.ToString(Helicopter.TankVolume);
                MassTextBox.Text = Convert.ToString(Helicopter.Mass);
            }
            get
            {
                Helicopter.TransportName = TNameTextBox.Text;
                Helicopter.WearRate = ConvertToDouble(WearRateTextBox.Text, "WearRate");
                Helicopter.FuelWaste = ConvertToDouble(FuelWasteTextBox.Text, "FuelWaste");
                Helicopter.Speed = ConvertToDouble(SpeedTextBox.Text, "Speed");
                Helicopter.TankVolume = ConvertToDouble(TankVolumeTextBox.Text, "TankVolume");
                Helicopter.Mass = ConvertToDouble(MassTextBox.Text, "Mass");
                return Helicopter;
            }
        }

        private double ConvertToDouble(string value, string fieldname)
        {
            double setting_value;
            try
            {
                setting_value = Convert.ToDouble(value);
            }
            catch (FormatException exception)
            {
                throw new FormatException(fieldname + " have to contain digits only");
            }
            return setting_value;
        }
    }
}
