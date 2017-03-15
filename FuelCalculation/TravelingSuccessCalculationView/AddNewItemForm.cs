using System;
using System.Windows.Forms;
using System.Collections.Generic;
using FuelCalculation;

namespace TravelingSuccessCalculationView
{
    public partial class AddNewItemForm : Form
    {
        public AddNewItemForm()
        {
            InitializeComponent();
        }

        private void AddNewItemForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                label6.Text = "FuelType";
                label6.Visible = true;
                textBox6.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
                label6.Text = "Mass";
                label6.Visible = true;
                textBox6.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public ITransportProperty GetTransport()
        {
            Car car = new Car();
            Helicopter helicopter = new Helicopter();

            if (radioButton1.Checked)
            {
                car.TransportName = textBox1.Text;
                car.WearRate = Convert.ToDouble(textBox2.Text);
                car.FuelWaste = Convert.ToDouble(textBox3.Text);
                car.Speed = Convert.ToDouble(textBox4.Text);
                car.TankVolume = Convert.ToDouble(textBox5.Text);
                car.FuelType = textBox6.Text;

                return car;
            }

            else
            {
                helicopter.TransportName = textBox1.Text;
                helicopter.WearRate = Convert.ToDouble(textBox2.Text);
                helicopter.FuelWaste = Convert.ToDouble(textBox3.Text);
                helicopter.Speed = Convert.ToDouble(textBox4.Text);
                helicopter.TankVolume = Convert.ToDouble(textBox5.Text);
                helicopter.Mass = Convert.ToDouble(textBox5.Text);

                return helicopter;
            }
        }

        public void SetTransport(ITransportProperty transport)
        {
            textBox1.Text = Convert.ToString(transport.TransportName);
            textBox2.Text = Convert.ToString(transport.WearRate);
            textBox3.Text = Convert.ToString(transport.FuelWaste);
            textBox4.Text = Convert.ToString(transport.Speed);
            textBox5.Text = Convert.ToString(transport.TankVolume);
            if (transport is Car)
            {
                Car carTransport = new Car();
                carTransport = (Car)transport;
                radioButton1.Checked = true;
                textBox6.Text = Convert.ToString(carTransport.FuelType);
            }
            else //if (transport is Helicopter)
            {
                Helicopter carTransport = new Helicopter();
                carTransport = (Helicopter)transport;
                radioButton2.Checked = true;
                textBox6.Text = Convert.ToString(carTransport.Mass);
            }
        }
    }
}
