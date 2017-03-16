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
            Serialization.Deserialize(ref TransportList);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewItemForm frm = new AddNewItemForm();
            frm.ShowDialog();
            var transport = frm.GetTransport();
            iTransportPropertyBindingSource.Add(transport);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewItemForm frm = new AddNewItemForm();
            int index = dataGridView1.CurrentRow.Index;
            frm.SetTransport((ITransportProperty)iTransportPropertyBindingSource.Current);
            frm.ShowDialog();
            var transport = frm.GetTransport();
            iTransportPropertyBindingSource[index] = transport;
        }

        private void TransportListView_Load(object sender, EventArgs e)
        {
            iTransportPropertyBindingSource.DataSource = TransportList;
        }

        private void TransportListView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialization.Serialize(TransportList);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void abouUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

