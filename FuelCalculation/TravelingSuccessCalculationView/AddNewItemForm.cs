using System;
using System.Windows.Forms;
using FuelCalculation;

namespace TravelingSuccessCalculationView
{
    public partial class AddNewTransportForm : Form
    {
        public ITransport Transport { set; get; }

        public AddNewTransportForm()
        {
            InitializeComponent();

            TNameTextBox.Enabled = false;
            WearRateTextBox.Enabled = false;
            FuelWasteTextBox.Enabled = false;
            SpeedTextBox.Enabled = false;
            TankVolumeTextBox.Enabled = false;
        }

        private void ChooseTransportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            TNameTextBox.Enabled = true;
            WearRateTextBox.Enabled = true;
            FuelWasteTextBox.Enabled = true;
            SpeedTextBox.Enabled = true;
            TankVolumeTextBox.Enabled = true;

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

/*-------------------------------------GET/SET TRANSPORT-----------------------------------------------------------------------------------*/

        public ITransport SetTransport()
        {
            if (ChooseTransportComboBox.Text == "Car")
            {
                Car car = new Car();
                car.TransportName = TNameTextBox.Text;
                car.WearRate = ConvertToDouble(WearRateTextBox.Text, "WearRate");
                car.FuelWaste = ConvertToDouble(FuelWasteTextBox.Text, "FuelWaste");
                car.Speed = ConvertToDouble(SpeedTextBox.Text, "Speed");
                car.TankVolume = ConvertToDouble(TankVolumeTextBox.Text, "TankVolume");
                car.FuelType = (FuelType)Enum.Parse(typeof(FuelType), FuelTypeComboBox.Text);

                return car;
            }
            else
            {
                Helicopter helicopter = new Helicopter();
                helicopter.TransportName = TNameTextBox.Text;
                helicopter.WearRate = ConvertToDouble(WearRateTextBox.Text, "WearRate");
                helicopter.FuelWaste = ConvertToDouble(FuelWasteTextBox.Text, "FuelWaste");
                helicopter.Speed = ConvertToDouble(SpeedTextBox.Text, "Speed");
                helicopter.TankVolume = ConvertToDouble(TankVolumeTextBox.Text, "TankVolume");
                helicopter.Mass = Convert.ToDouble(TankVolumeTextBox.Text);

                return helicopter;
            }
        }

        private double ConvertToDouble (string value, string fieldname)
        {
            double a;
            try
            {
                a = Convert.ToDouble(value);
            }
            catch (FormatException exception)
            {
                throw new FormatException(fieldname + " have to contain digits only");
            }
            return a;
        }

        public void GetTransport(ITransport transport)
        {
            TNameTextBox.Text = Convert.ToString(transport.TransportName);
            WearRateTextBox.Text = Convert.ToString(transport.WearRate);
            FuelWasteTextBox.Text = Convert.ToString(transport.FuelWaste);
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
                ChooseTransportComboBox.Text = "Helicopter";
                MassTextBox.Text = Convert.ToString(carTransport.Mass);
            }
        }

/*-------------------------------------------BOXES' VALUES CHEKING----------------------------------------------------------------------------*/

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
        }

        private void TNameTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Enter a transport name using a-z letters", TNameTextBox);
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
        }

        private void WearRateTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Transport wear rate. Value have to vary from 0 to 1", WearRateTextBox);
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
        }

        private void FuelWasteTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Transport fuel waste. Value have to vary from 5 to 30", FuelWasteTextBox);
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
        }

        private void SpeedTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Speed value. Value have to vary from 1 to 180", SpeedTextBox);
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
        }

        private void TankVolumeTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Transport tank volume. Value have to vary from 20 to 100", TankVolumeTextBox);
        }

        private void MassTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MassTextBox.Text))
            {
                errorProvider.SetError(MassTextBox, "Please enter the mass transported");
            }
            else
            {
                errorProvider.SetError(MassTextBox, null);
            }
        }

        private void MassTextBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Введите массу перевозимого груза", MassTextBox);
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
        }

        private void FuelTypeComboBox_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Transport fuel type", FuelTypeComboBox);
        }

        /*-------------------------------------------BUTTONS-------------------------------------------------------------------------------------------*/

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
            FuelWasteTextBox.Text = Convert.ToString(randomInt.Next(25, 27));
            SpeedTextBox.Text = Convert.ToString(randomInt.Next(100, 180));
            TankVolumeTextBox.Text = Convert.ToString(randomInt.Next(50, 60));

            if (ChooseTransportComboBox.Text == "Car")
            {
                FuelTypeComboBox.Text = Convert.ToString(FuelType.Бензин);
            }
            else
            {
                MassTextBox.Text = Convert.ToString(randomInt.Next(100, 999));
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ChooseTransportComboBox.Text == "Car")
            {
                if (TNameTextBox.Text == string.Empty || WearRateTextBox.Text == string.Empty ||
                    FuelWasteTextBox.Text == string.Empty || SpeedTextBox.Text == string.Empty || 
                    TankVolumeTextBox.Text == string.Empty || FuelTypeComboBox.Text == string.Empty)
                {
                    MessageBox.Show("All fields have to be filled", "ArgumentErrorMessage", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
            else if (ChooseTransportComboBox.Text == "Helicopter")
                {
                    if (TNameTextBox.Text == string.Empty || WearRateTextBox.Text == string.Empty ||
                        FuelWasteTextBox.Text == string.Empty || SpeedTextBox.Text == string.Empty ||
                        TankVolumeTextBox.Text == string.Empty || MassTextBox.Text == string.Empty)
                    {
                        MessageBox.Show("All fields have to be filled", "ArgumentErrorMessage", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }

            try
            {
                Transport = SetTransport();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
