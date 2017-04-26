namespace TravelingSuccessCalculationView
{
    partial class TransportListForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransportListForm));
            this.TransportListGroupBox = new System.Windows.Forms.GroupBox();
            this.TransportListGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTransportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ModifyItemButton = new System.Windows.Forms.Button();
            this.AddNewItemButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddItemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyItemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveItemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ByItemSerchComboBox = new System.Windows.Forms.ComboBox();
            this.TransportControlGroupBox = new System.Windows.Forms.GroupBox();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.DistanceTextBox = new System.Windows.Forms.MaskedTextBox();
            this.IsCanPassDistanceButton = new System.Windows.Forms.Button();
            this.TransportControl = new TravelingSuccessCalculationView.TransportControl();
            this.TransportListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransportListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTransportBindingSource)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.TransportControlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransportListGroupBox
            // 
            this.TransportListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransportListGroupBox.Controls.Add(this.TransportListGridView);
            this.TransportListGroupBox.Location = new System.Drawing.Point(12, 27);
            this.TransportListGroupBox.Name = "TransportListGroupBox";
            this.TransportListGroupBox.Size = new System.Drawing.Size(550, 353);
            this.TransportListGroupBox.TabIndex = 0;
            this.TransportListGroupBox.TabStop = false;
            this.TransportListGroupBox.Text = "Transport List";
            // 
            // TransportListGridView
            // 
            this.TransportListGridView.AllowUserToAddRows = false;
            this.TransportListGridView.AllowUserToResizeColumns = false;
            this.TransportListGridView.AllowUserToResizeRows = false;
            this.TransportListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransportListGridView.AutoGenerateColumns = false;
            this.TransportListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TransportListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransportListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.TransportListGridView.DataSource = this.iTransportBindingSource;
            this.TransportListGridView.Location = new System.Drawing.Point(6, 19);
            this.TransportListGridView.Name = "TransportListGridView";
            this.TransportListGridView.ReadOnly = true;
            this.TransportListGridView.RowHeadersVisible = false;
            this.TransportListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransportListGridView.Size = new System.Drawing.Size(538, 328);
            this.TransportListGridView.TabIndex = 4;
            this.TransportListGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TransportListGridView_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TransportName";
            this.dataGridViewTextBoxColumn1.HeaderText = "TransportName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "WearRate";
            this.dataGridViewTextBoxColumn2.HeaderText = "WearRate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FuelWaste";
            this.dataGridViewTextBoxColumn3.HeaderText = "FuelWaste";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Speed";
            this.dataGridViewTextBoxColumn4.HeaderText = "Speed";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TankVolume";
            this.dataGridViewTextBoxColumn5.HeaderText = "TankVolume";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // iTransportBindingSource
            // 
            this.iTransportBindingSource.DataSource = typeof(FuelCalculation.ITransport);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveItemButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RemoveItemButton.Location = new System.Drawing.Point(209, 386);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(92, 23);
            this.RemoveItemButton.TabIndex = 3;
            this.RemoveItemButton.Text = "Remove";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ModifyItemButton
            // 
            this.ModifyItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ModifyItemButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ModifyItemButton.Location = new System.Drawing.Point(111, 386);
            this.ModifyItemButton.Name = "ModifyItemButton";
            this.ModifyItemButton.Size = new System.Drawing.Size(92, 23);
            this.ModifyItemButton.TabIndex = 2;
            this.ModifyItemButton.Text = "Modify";
            this.ModifyItemButton.UseVisualStyleBackColor = true;
            this.ModifyItemButton.Click += new System.EventHandler(this.ModifyItemButton_Click);
            // 
            // AddNewItemButton
            // 
            this.AddNewItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNewItemButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddNewItemButton.Location = new System.Drawing.Point(12, 386);
            this.AddNewItemButton.Name = "AddNewItemButton";
            this.AddNewItemButton.Size = new System.Drawing.Size(92, 23);
            this.AddNewItemButton.TabIndex = 1;
            this.AddNewItemButton.Text = "Add";
            this.AddNewItemButton.UseVisualStyleBackColor = false;
            this.AddNewItemButton.Click += new System.EventHandler(this.AddNewItemButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem,
            this.HelpMenuItem,
            this.aboutMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(851, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateMenuItem,
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.SaveAsMenuItem,
            this.CloseMenuItem,
            this.recentFilesMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(35, 20);
            this.FileMenuItem.Text = "File";
            // 
            // CreateMenuItem
            // 
            this.CreateMenuItem.Name = "CreateMenuItem";
            this.CreateMenuItem.Size = new System.Drawing.Size(130, 22);
            this.CreateMenuItem.Text = "Create";
            this.CreateMenuItem.Click += new System.EventHandler(this.CreateMenuItem_Click);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(130, 22);
            this.OpenMenuItem.Text = "Open";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(130, 22);
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            this.SaveAsMenuItem.Size = new System.Drawing.Size(130, 22);
            this.SaveAsMenuItem.Text = "SaveAs";
            this.SaveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
            // 
            // CloseMenuItem
            // 
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.Size = new System.Drawing.Size(130, 22);
            this.CloseMenuItem.Text = "Close";
            this.CloseMenuItem.Click += new System.EventHandler(this.CloseMenuItem_Click);
            // 
            // recentFilesMenuItem
            // 
            this.recentFilesMenuItem.Name = "recentFilesMenuItem";
            this.recentFilesMenuItem.Size = new System.Drawing.Size(130, 22);
            this.recentFilesMenuItem.Text = "Recent files";
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddItemMenuItem,
            this.ModifyItemMenuItem,
            this.RemoveItemMenuItem});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(37, 20);
            this.EditMenuItem.Text = "Edit";
            // 
            // AddItemMenuItem
            // 
            this.AddItemMenuItem.Name = "AddItemMenuItem";
            this.AddItemMenuItem.Size = new System.Drawing.Size(113, 22);
            this.AddItemMenuItem.Text = "Add";
            this.AddItemMenuItem.Click += new System.EventHandler(this.AddItemMenuItem_Click);
            // 
            // ModifyItemMenuItem
            // 
            this.ModifyItemMenuItem.Name = "ModifyItemMenuItem";
            this.ModifyItemMenuItem.Size = new System.Drawing.Size(113, 22);
            this.ModifyItemMenuItem.Text = "Modify";
            this.ModifyItemMenuItem.Click += new System.EventHandler(this.ModifyItemMenuItem_Click);
            // 
            // RemoveItemMenuItem
            // 
            this.RemoveItemMenuItem.Name = "RemoveItemMenuItem";
            this.RemoveItemMenuItem.Size = new System.Drawing.Size(113, 22);
            this.RemoveItemMenuItem.Text = "Remove";
            this.RemoveItemMenuItem.Click += new System.EventHandler(this.RemoveItemMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(40, 20);
            this.HelpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // ItemSearchTextBox
            // 
            this.ItemSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemSearchTextBox.Location = new System.Drawing.Point(434, 388);
            this.ItemSearchTextBox.Name = "ItemSearchTextBox";
            this.ItemSearchTextBox.Size = new System.Drawing.Size(175, 20);
            this.ItemSearchTextBox.TabIndex = 7;
            this.ItemSearchTextBox.TextChanged += new System.EventHandler(this.ItemSearchTextBox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchButton.Location = new System.Drawing.Point(615, 386);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ByItemSerchComboBox
            // 
            this.ByItemSerchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ByItemSerchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ByItemSerchComboBox.FormattingEnabled = true;
            this.ByItemSerchComboBox.Items.AddRange(new object[] {
            "Transpor tName",
            "Wear Rate",
            "Fuel Waste",
            "Speed",
            "Tank Volume"});
            this.ByItemSerchComboBox.Location = new System.Drawing.Point(307, 388);
            this.ByItemSerchComboBox.Name = "ByItemSerchComboBox";
            this.ByItemSerchComboBox.Size = new System.Drawing.Size(121, 21);
            this.ByItemSerchComboBox.TabIndex = 9;
            // 
            // TransportControlGroupBox
            // 
            this.TransportControlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransportControlGroupBox.Controls.Add(this.DistanceLabel);
            this.TransportControlGroupBox.Controls.Add(this.DistanceTextBox);
            this.TransportControlGroupBox.Controls.Add(this.IsCanPassDistanceButton);
            this.TransportControlGroupBox.Controls.Add(this.TransportControl);
            this.TransportControlGroupBox.Location = new System.Drawing.Point(568, 27);
            this.TransportControlGroupBox.Name = "TransportControlGroupBox";
            this.TransportControlGroupBox.Size = new System.Drawing.Size(271, 353);
            this.TransportControlGroupBox.TabIndex = 10;
            this.TransportControlGroupBox.TabStop = false;
            this.TransportControlGroupBox.Text = "Transport Control";
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(9, 296);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(52, 13);
            this.DistanceLabel.TabIndex = 11;
            this.DistanceLabel.Text = "Distance:";
            // 
            // DistanceTextBox
            // 
            this.DistanceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DistanceTextBox.Location = new System.Drawing.Point(137, 293);
            this.DistanceTextBox.Mask = "00000";
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(63, 20);
            this.DistanceTextBox.TabIndex = 12;
            // 
            // IsCanPassDistanceButton
            // 
            this.IsCanPassDistanceButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.IsCanPassDistanceButton.Location = new System.Drawing.Point(97, 319);
            this.IsCanPassDistanceButton.Name = "IsCanPassDistanceButton";
            this.IsCanPassDistanceButton.Size = new System.Drawing.Size(75, 23);
            this.IsCanPassDistanceButton.TabIndex = 11;
            this.IsCanPassDistanceButton.Text = "Calculate";
            this.IsCanPassDistanceButton.UseVisualStyleBackColor = true;
            this.IsCanPassDistanceButton.Click += new System.EventHandler(this.IsCanPassDistanceButton_Click);
            // 
            // TransportControl
            // 
            this.TransportControl.Location = new System.Drawing.Point(6, 19);
            this.TransportControl.Name = "TransportControl";
            this.TransportControl.ReadOnly = false;
            this.TransportControl.Size = new System.Drawing.Size(258, 186);
            this.TransportControl.TabIndex = 0;
            this.TransportControl.Transport = null;
            this.TransportControl.TransportType = -1;
            // 
            // TransportListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 421);
            this.Controls.Add(this.TransportControlGroupBox);
            this.Controls.Add(this.ByItemSerchComboBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ItemSearchTextBox);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.TransportListGroupBox);
            this.Controls.Add(this.ModifyItemButton);
            this.Controls.Add(this.AddNewItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(708, 358);
            this.Name = "TransportListForm";
            this.Text = "Transport Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransportListView_FormClosing);
            this.TransportListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransportListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTransportBindingSource)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.TransportControlGroupBox.ResumeLayout(false);
            this.TransportControlGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TransportListGroupBox;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ModifyItemButton;
        private System.Windows.Forms.Button AddNewItemButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView TransportListGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wearRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelWasteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tankVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddItemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyItemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveItemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource iTransportBindingSource;
        private System.Windows.Forms.ToolStripMenuItem CreateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.TextBox ItemSearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox ByItemSerchComboBox;
        private System.Windows.Forms.ToolStripMenuItem recentFilesMenuItem;
        private System.Windows.Forms.GroupBox TransportControlGroupBox;
        private TransportControl TransportControl;
        private System.Windows.Forms.Button IsCanPassDistanceButton;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.MaskedTextBox DistanceTextBox;
    }
}

