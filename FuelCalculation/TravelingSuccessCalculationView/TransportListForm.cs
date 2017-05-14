﻿using FuelCalculation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TravelingSuccessCalculationView
{
    public partial class TransportListForm : Form
    {
        #region - Private fields - 

        private string _filePath;
        private bool _projectSavedChanges;
        private bool _afterSearchChanges;
        private List<ITransport> _transportList;
        private List<ITransport> _searchedTransportList;
        private RecentFiles _recentFiles;

        #endregion

        public TransportListForm()
        {
            InitializeComponent();
            _filePath = null;
            _projectSavedChanges = true;
            _afterSearchChanges = false;
            _transportList = new List<ITransport>();
            iTransportBindingSource.DataSource = _transportList;
            _recentFiles = new RecentFiles();
            _recentFiles.RecentFilesDeserialize();
            if (_recentFiles.GetRecentFilesList().Count > 0)
            {
                LoadRecentFilesToMenu();
            }
            TransportListGridView.ClearSelection();
        }

        #region - Menu Items -

        private void CreateMenuItem_Click(object sender, EventArgs e)
        {
            CheckChanges();

            _filePath = null;
            _projectSavedChanges = true;
            FormNameChanger(_projectSavedChanges);
            _transportList = new List<ITransport>();
            iTransportBindingSource.DataSource = _transportList;
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            CheckChanges();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = @"Transport Files (*.tnp)|*.tnp";
            ofd.Title = @"Open file";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _filePath = ofd.FileName;
                Serializer.Deserialize(ref _transportList, _filePath);
                iTransportBindingSource.DataSource = _transportList;
                _projectSavedChanges = true;
                FormNameChanger(_projectSavedChanges);
                LoadRecentFiles(_filePath);
                TransportListGridView.ClearSelection();
            }
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (_filePath != null)
            {
                Serializer.Serialize(_transportList, _filePath);
            }
            else
            {
                SaveAs();
            }
            _projectSavedChanges = true;
            FormNameChanger(_projectSavedChanges);
        }

        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void AddNewItemButton_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void AddItemMenuItem_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void ModifyItemButton_Click(object sender, EventArgs e)
        {
            ModifyItem();
        }

        private void ModifyItemMenuItem_Click(object sender, EventArgs e)
        {
            ModifyItem();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        private void RemoveItemMenuItem_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new AboutProgram();
            frm.ShowDialog();
        }

        private void TransportListView_FormClosing(object sender, FormClosingEventArgs e)
        {
            _recentFiles.RecentFilesSerialize();
            CheckChanges();
        }

        #endregion

        #region - Main Methods - 

        private void CheckChanges()
        {
            if (!_projectSavedChanges)
            {
                if (MessageBox.Show("Do you want to save the changes?", "BeforeClose",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (_filePath != null)
                    {
                        Serializer.Serialize(_transportList, _filePath);
                    }
                    else
                    {
                        SaveAs();
                    }
                }
            }
        }

        private void SaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "tnp";
            sfd.Filter = @"Transport Files (*.tnp)|*.tnp";
            sfd.Title = @"Save file";
            sfd.FileName = "*.tnp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _filePath = sfd.FileName;
                Serializer.Serialize(_transportList, _filePath);
                _projectSavedChanges = true;
                FormNameChanger(_projectSavedChanges);
                LoadRecentFiles(_filePath);
            }
        }

        private void AddNewItem()
        {
            var frm = new AddNewTransportForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var transport = frm.Transport;
                iTransportBindingSource.Add(transport);
                _projectSavedChanges = false;
                FormNameChanger(_projectSavedChanges);
            }
        }

        private void ModifyItem()
        {
            if (_transportList.Count == 0)
            {
                MessageBox.Show("Your list is empty!");
                return;
            }
            var frm = new AddNewTransportForm();
            frm.Transport = (ITransport)iTransportBindingSource.Current;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var transport = frm.Transport;
                var index = _transportList.IndexOf((ITransport)iTransportBindingSource.Current);
                if (_afterSearchChanges == false)
                {
                    iTransportBindingSource.RemoveAt(index);
                    iTransportBindingSource.Insert(index, transport);
                }
                else
                {
                    var afterIndex = _searchedTransportList.IndexOf((ITransport)iTransportBindingSource.Current);
                    iTransportBindingSource.RemoveAt(afterIndex);
                    iTransportBindingSource.Insert(afterIndex, transport);
                    _transportList.RemoveAt(index);
                    _transportList.Insert(index, transport);
                }
                FormNameChanger(_projectSavedChanges);
                _projectSavedChanges = false;
            }
        }

        private void RemoveItem()
        {
            if (_transportList.Count == 0)
            {
                MessageBox.Show("Your list is empty!");
            }
            else if (TransportListGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Do you really want to remove this object?", "TransportRemove",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (_afterSearchChanges == false)
                    {
                        var index = TransportListGridView.CurrentRow.Index;
                        TransportListGridView.Rows.RemoveAt(index);
                    }
                    else
                    {
                        var index = _transportList.IndexOf((ITransport)iTransportBindingSource.Current);
                        var afterIndex = TransportListGridView.CurrentRow.Index;
                        iTransportBindingSource.RemoveAt(afterIndex);
                        _transportList.RemoveAt(index);
                    }
                    _projectSavedChanges = false;
                    FormNameChanger(_projectSavedChanges);
                }
            }
        }

        #endregion

        #region - Search -  

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (_transportList != null)
            {
                if (ByItemSerchComboBox.SelectedIndex != -1)
                {
                    _afterSearchChanges = true;
                    string searchLine = ItemSearchTextBox.Text;

                    switch (ByItemSerchComboBox.SelectedItem.ToString())
                    {
                        case "Transport Name":
                        {
                            iTransportBindingSource.DataSource = _searchedTransportList = _transportList.FindAll(delegate (ITransport transport)
                            {
                                return transport.TransportName == searchLine;
                            });
                            break;
                        }
                        case "Wear Rate":
                        {
                            iTransportBindingSource.DataSource = _searchedTransportList = _transportList.FindAll(delegate (ITransport transport)
                            {
                                return transport.WearRate.ToString() == searchLine;
                            });
                            break;
                        }
                        case "Fuel Waste":
                        {
                            iTransportBindingSource.DataSource = _searchedTransportList = _transportList.FindAll(delegate (ITransport transport)
                            {
                                return transport.FuelWaste.ToString() == searchLine;
                            });
                            break;
                        }
                        case "Speed":
                        {
                            iTransportBindingSource.DataSource = _searchedTransportList = _transportList.FindAll(delegate (ITransport transport)
                            {
                                return transport.Speed.ToString() == searchLine;
                            });
                            break;
                        }
                        case "Tank Volume":
                        {
                            iTransportBindingSource.DataSource = _searchedTransportList = _transportList.FindAll(delegate (ITransport transport)
                            {
                                return transport.TankVolume.ToString() == searchLine;
                            });
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не выбрано поле поиска");
                }
            }
            else
            {
                MessageBox.Show("База данных пуста");
            }
        }

        private void ItemSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemSearchTextBox.Text == "")
            {
                iTransportBindingSource.DataSource = _transportList;
                _afterSearchChanges = false;
            }
        }

        #endregion

        private void FormNameChanger(bool projectSavedChanges)
        {
            if (_filePath != null)
            {
                if (!projectSavedChanges)
                {
                    this.Text = Path.GetFileName(_filePath) + "* - Transport Form";
                }
                else
                {
                    this.Text = Path.GetFileName(_filePath) + " - Transport Form";
                }
            }
            else
            {
                this.Text = "Transport Form";
            }
        }

        #region - Recent Files -

        private void LoadRecentFiles(string filePath)
        {
            _recentFiles.AddToRecentFiles(filePath);

            if (_recentFiles.GetRecentFilesList().Count > 0)
            {
                recentFilesMenuItem.DropDownItems.Clear();

                LoadRecentFilesToMenu();
            }
        }

        private void LoadRecentFilesToMenu()
        {
            for (var i = 0; i < _recentFiles.GetRecentFilesList().Count; i++)
            {
                var projectName = Path.GetFileName(_recentFiles.GetRecentFilesList()[i]);
                recentFilesMenuItem.DropDownItems.Add(projectName);
                recentFilesMenuItem.DropDownItems[i].Click += OnClick;
            }
        }

        private void OnClick(object sender, EventArgs eventArgs)
        {
            CheckChanges();
            var stripItem = (ToolStripDropDownItem)sender;
            var index = recentFilesMenuItem.DropDownItems.IndexOf(stripItem);
            _filePath = _recentFiles.GetRecentFilesList()[index];
            Serializer.Deserialize(ref _transportList, _filePath);
            iTransportBindingSource.DataSource = _transportList;
            _projectSavedChanges = true;
            FormNameChanger(_projectSavedChanges);
            LoadRecentFiles(_filePath);
        }

        #endregion

        #region - IsCanPassDistance -

        private void TransportListGridView_MouseClick(object sender, MouseEventArgs e)
        {
            TransportControl.Transport = (ITransport)iTransportBindingSource.Current;
            TransportControl.ReadOnly = true;
        }

        private void IsCanPassDistanceButton_Click(object sender, EventArgs e)
        {
            int distance = Convert.ToInt32(DistanceTextBox.Text);
            var transport = (ITransport)iTransportBindingSource.Current;
            if (transport.IsCanPassDistance(distance))
            {
                MessageBox.Show("You can pass this distance using chosen transport!");
            }
            else
            {
                MessageBox.Show("It is impossible to pass this distance using chisen transport!");
            }
        }

        #endregion
    }
}

