using FuelCalculation;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TravelingSuccessCalculationView
{
    public partial class TransportListView : Form
    {
        public static List<ITransportProperty> transportList = new List<ITransportProperty>();

        public TransportListView()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewItemForm frm = new AddNewItemForm();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeItemForm frm = new ChangeItemForm();
            frm.Show();
        }

        private void TransportListView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = transportList;
        }

        private void TransportListView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialization.Serialize(transportList);
        }
    }
}
