using System;
using System.Windows.Forms;
using FuelCalculation;

namespace TravelingSuccessCalculationView
{
    public partial class AddNewTransportForm : Form
    {
        //private ITransportProperty _transportProperty;

        public AddNewTransportForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /*public ITransportProperty TransportProperty
        {
            set
            {
                _transportProperty = value;
            }
            get
            {
                return _transportProperty;
            }
        }*/

        public ITransport GetTransport()
        {
            if (ChooseTransportComboBox.Text == "Car")
            {
                Car car = new Car();
                car.TransportName = TNameTextBox.Text;
                car.WearRate = Convert.ToDouble(WearRateTextBox.Text);
                car.FuelWaste = Convert.ToDouble(FuelWasteTtextBox.Text);
                car.Speed = Convert.ToDouble(SpeedTextBox.Text);
                car.TankVolume = Convert.ToDouble(TankVolumeTextBox.Text);
                car.FuelType = (FuelType)Enum.Parse(typeof(FuelType), FuelTypeComboBox.Text);

                return car;
            }

            else
            {
                Helicopter helicopter = new Helicopter();
                helicopter.TransportName = TNameTextBox.Text;
                helicopter.WearRate = Convert.ToDouble(WearRateTextBox.Text);
                helicopter.FuelWaste = Convert.ToDouble(FuelWasteTtextBox.Text);
                helicopter.Speed = Convert.ToDouble(SpeedTextBox.Text);
                helicopter.TankVolume = Convert.ToDouble(TankVolumeTextBox.Text);
                helicopter.Mass = Convert.ToDouble(TankVolumeTextBox.Text);

                return helicopter;
            }
        }

        public void SetTransport(ITransport transport)
        {
            TNameTextBox.Text = Convert.ToString(transport.TransportName);
            WearRateTextBox.Text = Convert.ToString(transport.WearRate);
            FuelWasteTtextBox.Text = Convert.ToString(transport.FuelWaste);
            SpeedTextBox.Text = Convert.ToString(transport.Speed);
            TankVolumeTextBox.Text = Convert.ToString(transport.TankVolume);
            if (transport is Car)
            {
                var carTransport = new Car();
                carTransport = (Car)transport;
                ChooseTransportComboBox.Text = "Car";
                FuelTypeComboBox.Text = Convert.ToString(carTransport.FuelType);
            }
            else
            {
                var carTransport = new Helicopter();
                carTransport = (Helicopter)transport;
                ChooseTransportComboBox.Text = "Helocopter";
                MassTextBox.Text = Convert.ToString(carTransport.Mass);
            }
        }

        private void GenerateRandomValuesButton_Click(object sender, EventArgs e)
        {
            const int size = 5;
            Random rand = new Random();

            string name = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < size; i++, TNameTextBox.Text += name[rand.Next(name.Length)].ToString()) ;

            char[] newName = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < size; i++, TNameTextBox.Text += newName[rand.Next(newName.Length)].ToString()) ;

            /*-------------------------*/
            var unixTimestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            var randomInt = new Random(unixTimestamp);
            WearRateTextBox.Text = @"0," + Convert.ToString(randomInt.Next(10, 90));
            FuelWasteTtextBox.Text = Convert.ToString(randomInt.Next(25, 27));
            SpeedTextBox.Text = Convert.ToString(randomInt.Next(100, 180));
            TankVolumeTextBox.Text = Convert.ToString(randomInt.Next(50, 60));

            if (ChooseTransportComboBox.Text == "Car")
            {
                FuelTypeComboBox.Text = Convert.ToString(FuelType.Бензин);
            }
            else
            {
                MassTextBox.Text = Convert.ToString(randomInt.Next(500, 999));
            }

        }

        private void ChooseTransportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChooseTransportComboBox.Text == "Car")
            {
                UniqeFieldLabel.Text = "FuelType";
                UniqeFieldLabel.Visible = true;
                FuelTypeComboBox.Visible = true;
                MassTextBox.Visible = false;
            }
            else
            {
                UniqeFieldLabel.Text = "Mass";
                UniqeFieldLabel.Visible = true;
                MassTextBox.Visible = true;
                FuelTypeComboBox.Visible = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
