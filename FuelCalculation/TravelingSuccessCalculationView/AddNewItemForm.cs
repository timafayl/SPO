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

        #region - Buttons -

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
            var randomTransport = new RandomTransportGenerator();
            if (TransportControl.TransportType == 0)
            {
                Transport = randomTransport.GenerateCar();
            }
            else if (TransportControl.TransportType == 1)
            {
                Transport = randomTransport.GenerateHelicopter();
            }
            else
            {
                if (randomTransport.GenerateRandomTransport() is Car)
                {
                    TransportControl.TransportType = 0;
                    Transport = randomTransport.GenerateRandomTransport();
                }
                else
                {
                    TransportControl.TransportType = 1;
                    Transport = randomTransport.GenerateRandomTransport();
                }
            }
        }

        #endregion
    }
}
