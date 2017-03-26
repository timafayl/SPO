﻿using FuelCalculation;
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
        private List<ITransport> _transportList;

        public TransportListForm()
        {
            InitializeComponent();
            _filePath = null;
            _projectSavedChanges = true;
            _transportList = new List<ITransport>();
            iTransportBindingSource.DataSource = _transportList;
        }

        private void CreateMenuItem_Click(object sender, EventArgs e)
        {
            if (_projectSavedChanges != true)
            {
                if (MessageBox.Show("Do you want to save the changes?", "BeforeClose",
                      MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (_filePath != null)
                    {
                        Serialization.Serialize(_transportList, _filePath);
                    }
                    else
                    {
                        SaveAsMenuItem_Click(sender, e);
                    }
                }
            }

            _filePath = null;
            _projectSavedChanges = true;
            _transportList = new List<ITransport>();
            iTransportBindingSource.DataSource = _transportList;
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            if (_projectSavedChanges != true)
            {
                if (MessageBox.Show("Do you want to save the changes?", "BeforeClose",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (_filePath != null)
                    {
                        Serialization.Serialize(_transportList, _filePath);
                    }
                    else
                    {
                        SaveAsMenuItem_Click(sender, e);
                    }
                }
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = @"Transport Files (*.tnp)|*.tnp";
            ofd.Title = @"Open file";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _filePath = ofd.FileName;
                Serialization.Deserialize(ref _transportList, _filePath);
                iTransportBindingSource.DataSource = _transportList;
                _projectSavedChanges = true;
            }
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (_filePath != null)
            {
                Serialization.Serialize(_transportList, _filePath);
            }
            else
            {
                SaveAsMenuItem_Click(sender, e);
            }

            _projectSavedChanges = true;
        }

        private void AddNewItemButton_Click(object sender, EventArgs e)
        {
            var frm = new AddNewTransportForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var transport = frm.Transport;
                iTransportBindingSource.Add(transport);
                _projectSavedChanges = false;
            }
        }

        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "tnp";
            sfd.Filter = @"Transport Files (*.tnp)|*.tnp";
            sfd.Title = @"Save file";
            sfd.FileName = "*.tnp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _filePath = sfd.FileName;
                Serialization.Serialize(_transportList, _filePath);
            }
        }

        private void AddItemMenuItem_Click(object sender, EventArgs e)
        {
            AddNewItemButton_Click(sender, e);
        }

        private void ModifyItemButton_Click(object sender, EventArgs e)
        {
            var frm = new AddNewTransportForm();

            frm.GetTransport((ITransport)iTransportBindingSource.Current);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var transport = frm.Transport;
                var index = _transportList.IndexOf((ITransport) iTransportBindingSource.Current);
                iTransportBindingSource.RemoveAt(index);
                iTransportBindingSource.Insert(index, transport);
                _projectSavedChanges = false;
            }
        }

        private void ModifyItemMenuItem_Click(object sender, EventArgs e)
        {
            ModifyItemButton_Click(sender, e);
        }

        private void TransportListView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((_projectSavedChanges != true && iTransportBindingSource.Count != 0) || 
                (_projectSavedChanges != true && iTransportBindingSource.Count == 0))
            {
                if (MessageBox.Show("Do you want to save the changes?", "BeforeClose",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (_filePath != null)
                    {
                        Serialization.Serialize(_transportList, _filePath);
                    }
                    else
                    {
                        SaveAsMenuItem_Click(sender, e);
                    }
                }
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (TransportListGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Do you really want to remove this object?", "TransportRemove",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var index = TransportListGridView.CurrentRow.Index;
                    TransportListGridView.Rows.RemoveAt(index);
                    _projectSavedChanges = false;
                }
            }
        }

        private void RemoveItemMenuItem_Click(object sender, EventArgs e)
        {
            RemoveItemButton_Click(sender, e);
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

