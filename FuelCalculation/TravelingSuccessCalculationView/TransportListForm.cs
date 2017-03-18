using FuelCalculation;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TravelingSuccessCalculationView
{
    public partial class TransportListForm : Form
    {
        public List<ITransportProperty> TransportList;
        private List<ITransportProperty> _savedTransportList = new List<ITransportProperty>();

        public List<ITransportProperty> SavedTransportList
        {
            get
            {
                return _savedTransportList;
            }
            set
            {
                _savedTransportList = value;
            }
        }

        public TransportListForm()
        {
            InitializeComponent();

            TransportList = new List<ITransportProperty>();
            Serialization.Deserialize(ref TransportList);
            iTransportPropertyBindingSource.DataSource = TransportList;
        }

        private void AddNewItemButton_Click(object sender, EventArgs e)
        {
            var frm = new AddNewTransportForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var transport = frm.GetTransport();
                iTransportPropertyBindingSource.Add(transport);
            }
            // iTransportPropertyBindingSource.Add(frm.TransportProperty);
        }

        private void ModifyItemButton_Click(object sender, EventArgs e)
        {
            var frm = new AddNewTransportForm();
            frm.SetTransport((ITransportProperty)iTransportPropertyBindingSource.Current);
            frm.ShowDialog();
                
            var transport = frm.GetTransport();
            var index = TransportList.IndexOf((ITransportProperty) iTransportPropertyBindingSource.Current);
            iTransportPropertyBindingSource.RemoveAt(index);
            iTransportPropertyBindingSource.Insert(index, transport);
        }

        private void TransportListView_Load(object sender, EventArgs e)
        {
            //iTransportPropertyBindingSource.DataSource = TransportList;
        }

        private void TransportListView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SavedTransportList.Equals(TransportList))
            {
                if (MessageBox.Show("Do you want to save the changes?", "BeforeClose",
                MessageBoxButtons.YesNo) == DialogResult.No)
                {
                   Application.Exit();
                }
                else
                {
                    Serialization.Serialize(TransportList);
                    Application.Exit();
                    //_savedTransportList = TransportList;
                }
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (TransportListGridView.CurrentRow != null)
            {
                var index = TransportListGridView.CurrentRow.Index;
                TransportListGridView.Rows.RemoveAt(index);
            }
        }

        private void SaveMenuItem_Click()
        {
            Serialization.Serialize(TransportList);
            SavedTransportList = TransportList;
        }

        private void PrintMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            if (!SavedTransportList.Equals(TransportList))
            {
                if (MessageBox.Show("Do you want to save the changes?", "BeforeClose",
                MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    Serialization.Serialize(TransportList);
                    if (MessageBox.Show("Changes successfully saved", "ChangesSaved",
                            MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    //_savedTransportList = TransportList;
                }
            }
        }
    }
}

