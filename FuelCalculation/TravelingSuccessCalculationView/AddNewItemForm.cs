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
            var randomObj = new RandomObjGenerator();
            if (TransportControl.TransportType() == 0)
            {
                Transport = randomObj.GenerateCar();
            }
            else if (TransportControl.TransportType() == 1)
            {
                Transport = randomObj.GenerateHelicopter();
            }
        }
    }
}
