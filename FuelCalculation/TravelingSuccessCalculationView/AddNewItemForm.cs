using System;
using System.Windows.Forms;
using FuelCalculation;

namespace TravelingSuccessCalculationView
{
    public partial class AddNewTransportForm : Form
    {
        public ITransport Transport { get { return TransportControl.Transport; } set { TransportControl.Transport = value; } }

        public AddNewTransportForm()
        {
            InitializeComponent();
        }

        /*-------------------------------------------BUTTONS-------------------------------------------------------------------------------------------*/

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (TransportControl.IsFieldEmpty)
            {
                MessageBox.Show("All fields have to be filled", "ArgumentErrorMessage", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }

            
            try
            {
                var transport = Transport;
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

        private void GenerateRandomValuesButton_Click(object sender, EventArgs e)
        {
          
        }

        /*-------------------------------------------BOXES' VALUES CHEKING----------------------------------------------------------------------------*/

        /*   private void TNameTextBox_Leave(object sender, EventArgs e)
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
           }*/
    }
}
