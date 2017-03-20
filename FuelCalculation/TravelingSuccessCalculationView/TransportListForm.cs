using FuelCalculation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TravelingSuccessCalculationView
{
    public partial class TransportListForm : Form
    {
        private string _filePath;
        private bool _projectSavedChanges;
        private List<ITransport> TransportList;

        public TransportListForm()
        {
            InitializeComponent();

            _projectSavedChanges = true;

            TransportList = new List<ITransport>();

            if (_filePath != null)
            {
                Serialization.Deserialize(ref TransportList, _filePath);
            }

            iTransportBindingSource.DataSource = TransportList;
        }

        private void AddNewItemButton_Click(object sender, EventArgs e)
        {
            var frm = new AddNewTransportForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var transport = frm.GetTransport();
                iTransportBindingSource.Add(transport);
            }

            _projectSavedChanges = false;
        }

        private void ModifyItemButton_Click(object sender, EventArgs e)
        {
            var frm = new AddNewTransportForm();
            frm.SetTransport((ITransport)iTransportBindingSource.Current);
            frm.ShowDialog();
                
            var transport = frm.GetTransport();
            var index = TransportList.IndexOf((ITransport)iTransportBindingSource.Current);
            iTransportBindingSource.RemoveAt(index);
            iTransportBindingSource.Insert(index, transport);

            _projectSavedChanges = false;
        }

        private void TransportListView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_projectSavedChanges)
            {
                if (MessageBox.Show("Do you want to save the changes?", "BeforeClose",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (_filePath != null)
                    {
                        Serialization.Serialize(TransportList, _filePath);
                    }
                    else
                    {
                        SaveAsMenuItem_Click(sender, e);
                    }
                }
            }
            else if (TransportList == null){}
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (TransportListGridView.CurrentRow != null)
            {
                var index = TransportListGridView.CurrentRow.Index;
                TransportListGridView.Rows.RemoveAt(index);
            }

            _projectSavedChanges = false;
        }

        private void PrintMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "tnp";
            sfd.Filter = @"Transport Files (*.tnp)|*.tnp";
            sfd.Title = @"Save file";
            sfd.FileName = "*.tnp";
            File.Create("kjgfjhg.txt");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _filePath = sfd.FileName;
                Serialization.Serialize(TransportList, _filePath);
            }
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {

            _projectSavedChanges = true;

            if (_filePath != null)
            {
                Serialization.Serialize(TransportList, _filePath);
            }
            else
            {
                SaveAsMenuItem_Click(sender, e);
            }
        }
    }
}

