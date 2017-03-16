using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;
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
                comboBox1.Visible = true;
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
                car.FuelType = (FuelType)Enum.Parse(typeof(FuelType), comboBox1.Text);

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
                var carTransport = new Car();
                carTransport = (Car)transport;
                radioButton1.Checked = true;
                comboBox1.Text = Convert.ToString(carTransport.FuelType);
            }
            else
            {
                var carTransport = new Helicopter();
                carTransport = (Helicopter)transport;
                radioButton2.Checked = true;
                textBox6.Text = Convert.ToString(carTransport.Mass);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const int size = 5;
            Random rand = new Random();

            string name = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < size; i++, textBox1.Text += name[rand.Next(name.Length)].ToString()) ;

            char[] newName = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < size; i++, textBox1.Text += newName[rand.Next(newName.Length)].ToString()) ;

            /*-------------------------*/

            var randomInt = new Random(50);
            textBox2.Text = @"0," + Convert.ToString(randomInt.Next(10, 90));
            textBox3.Text = Convert.ToString(randomInt.Next(25, 27));
            textBox4.Text = Convert.ToString(randomInt.Next(100, 180));
            textBox5.Text = Convert.ToString(randomInt.Next(50, 60));

            if (radioButton1.Checked)
            {
                comboBox1.Text = Convert.ToString(FuelType.Бензин);
            }
            else
            {
                textBox6.Text = Convert.ToString(randomInt.Next(500, 999));
            }

        }
    }
}
