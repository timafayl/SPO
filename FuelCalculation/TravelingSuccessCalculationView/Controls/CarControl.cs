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
    public partial class CarControl : UserControl
    { 
        public CarControl()
        {
            InitializeComponent();
        }

        public Car Car
        {
            set
            {
                Car = value;
                TNameTextBox.Text = Convert.ToString(Car.TransportName);
                WearRateTextBox.Text = Convert.ToString(Car.WearRate);
                FuelWasteTextBox.Text = Convert.ToString(Car.FuelWaste);
                SpeedTextBox.Text = Convert.ToString(Car.Speed);
                TankVolumeTextBox.Text = Convert.ToString(Car.TankVolume);
                FuelTypeComboBox.Text = Convert.ToString(Car.FuelType);
            }
            get
            {
                Car.TransportName = TNameTextBox.Text;
                Car.WearRate = ConvertToDouble(WearRateTextBox.Text, "WearRate");
                Car.FuelWaste = ConvertToDouble(FuelWasteTextBox.Text, "FuelWaste");
                Car.Speed = ConvertToDouble(SpeedTextBox.Text, "Speed");
                Car.TankVolume = ConvertToDouble(TankVolumeTextBox.Text, "TankVolume");
                Car.FuelType = (FuelType)Enum.Parse(typeof(FuelType), FuelTypeComboBox.Text);
                return Car;
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
