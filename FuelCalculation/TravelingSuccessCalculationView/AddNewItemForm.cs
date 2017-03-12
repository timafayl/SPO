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
            if (radioButton1.Checked)
            {
                label6.Text = "FuelType";
                label6.Visible = true;
                textBox6.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label6.Text = "Mass";
                label6.Visible = true;
                textBox6.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car _car = new Car();
            Helicopter _helicopter = new Helicopter();

            if (radioButton1.Checked)
            {
                _car.TransportName = textBox1.Text;
                _car.WearRate = Convert.ToDouble(textBox2.Text);
                _car.FuelWaste = Convert.ToDouble(textBox3.Text);
                _car.Speed = Convert.ToDouble(textBox4.Text);
                _car.TankVolume = Convert.ToDouble(textBox5.Text);
                _car.FuelType = textBox6.Text;

                TransportListView.transportList.Add(_car);
            }
            else if (radioButton2.Checked)
            {
                _helicopter.TransportName = textBox1.Text;
                _helicopter.WearRate = Convert.ToDouble(textBox2.Text);
                _helicopter.FuelWaste = Convert.ToDouble(textBox3.Text);
                _helicopter.Speed = Convert.ToDouble(textBox4.Text);
                _helicopter.TankVolume = Convert.ToDouble(textBox5.Text);
                _helicopter.Mass = Convert.ToDouble(textBox5.Text);

                TransportListView.transportList.Add(_helicopter);
            }

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            Close();
        }
    }
}
