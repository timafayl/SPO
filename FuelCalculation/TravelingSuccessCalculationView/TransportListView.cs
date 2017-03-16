using FuelCalculation;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TravelingSuccessCalculationView
{
    public partial class TransportListView : Form
    {
        public List<ITransportProperty> TransportList;

        public TransportListView()
        {
            InitializeComponent();

            TransportList = new List<ITransportProperty>();
            //Serialization.Deserialize(ref TransportList);
            iTransportPropertyBindingSource.DataSource = TransportList;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new AddNewItemForm();
            frm.ShowDialog();
           // var transport = frm.GetTransport();
            iTransportPropertyBindingSource.Add(frm.TransportProperty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new AddNewItemForm();
            if (dataGridView1.CurrentRow != null)
            {
                var index = dataGridView1.CurrentRow.Index;
                frm.SetTransport((ITransportProperty)iTransportPropertyBindingSource.Current);
                frm.ShowDialog();
                var transport = frm.GetTransport();
                iTransportPropertyBindingSource[index] = transport;
            }
        }

        private void TransportListView_Load(object sender, EventArgs e)
        {
            //iTransportPropertyBindingSource.DataSource = TransportList;
        }

        private void TransportListView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Serialization.Serialize(TransportList);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var index = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(index);
            }
        }

        private void abouUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            Serialization.Serialize(TransportList);
        }
    }
}

