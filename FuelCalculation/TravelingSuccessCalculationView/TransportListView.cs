using FuelCalculation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelingSuccessCalculationView
{
    public partial class TransportListView : Form
    {
        public TransportListView()
        {
            InitializeComponent();
            var TransportList = new List<ITransportProperty>();
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
    }
}
