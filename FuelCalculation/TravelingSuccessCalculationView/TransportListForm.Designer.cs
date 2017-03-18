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
            this.transportNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wearRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelWasteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tankVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTransportPropertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ModifyItemButton = new System.Windows.Forms.Button();
            this.AddNewItemButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddItemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyItemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveItemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramGuideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransportListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransportListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTransportPropertyBindingSource)).BeginInit();
            this.menuStrip.SuspendLayout();
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
            this.TransportListGroupBox.Size = new System.Drawing.Size(641, 348);
            this.TransportListGroupBox.TabIndex = 0;
            this.TransportListGroupBox.TabStop = false;
            this.TransportListGroupBox.Text = "Transpor tList";
            // 
            // TransportListGridView
            // 
            this.TransportListGridView.AllowUserToAddRows = false;
            this.TransportListGridView.AllowUserToResizeColumns = false;
            this.TransportListGridView.AllowUserToResizeRows = false;
            this.TransportListGridView.AutoGenerateColumns = false;
            this.TransportListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TransportListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransportListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transportNameDataGridViewTextBoxColumn,
            this.wearRateDataGridViewTextBoxColumn,
            this.fuelWasteDataGridViewTextBoxColumn,
            this.speedDataGridViewTextBoxColumn,
            this.tankVolumeDataGridViewTextBoxColumn});
            this.TransportListGridView.DataSource = this.iTransportPropertyBindingSource;
            this.TransportListGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransportListGridView.Location = new System.Drawing.Point(3, 16);
            this.TransportListGridView.Name = "TransportListGridView";
            this.TransportListGridView.ReadOnly = true;
            this.TransportListGridView.RowHeadersVisible = false;
            this.TransportListGridView.Size = new System.Drawing.Size(635, 329);
            this.TransportListGridView.TabIndex = 4;
            // 
            // transportNameDataGridViewTextBoxColumn
            // 
            this.transportNameDataGridViewTextBoxColumn.DataPropertyName = "TransportName";
            this.transportNameDataGridViewTextBoxColumn.HeaderText = "TransportName";
            this.transportNameDataGridViewTextBoxColumn.Name = "transportNameDataGridViewTextBoxColumn";
            this.transportNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wearRateDataGridViewTextBoxColumn
            // 
            this.wearRateDataGridViewTextBoxColumn.DataPropertyName = "WearRate";
            this.wearRateDataGridViewTextBoxColumn.HeaderText = "WearRate";
            this.wearRateDataGridViewTextBoxColumn.Name = "wearRateDataGridViewTextBoxColumn";
            this.wearRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fuelWasteDataGridViewTextBoxColumn
            // 
            this.fuelWasteDataGridViewTextBoxColumn.DataPropertyName = "FuelWaste";
            this.fuelWasteDataGridViewTextBoxColumn.HeaderText = "FuelWaste";
            this.fuelWasteDataGridViewTextBoxColumn.Name = "fuelWasteDataGridViewTextBoxColumn";
            this.fuelWasteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speedDataGridViewTextBoxColumn
            // 
            this.speedDataGridViewTextBoxColumn.DataPropertyName = "Speed";
            this.speedDataGridViewTextBoxColumn.HeaderText = "Speed";
            this.speedDataGridViewTextBoxColumn.Name = "speedDataGridViewTextBoxColumn";
            this.speedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tankVolumeDataGridViewTextBoxColumn
            // 
            this.tankVolumeDataGridViewTextBoxColumn.DataPropertyName = "TankVolume";
            this.tankVolumeDataGridViewTextBoxColumn.HeaderText = "TankVolume";
            this.tankVolumeDataGridViewTextBoxColumn.Name = "tankVolumeDataGridViewTextBoxColumn";
            this.tankVolumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTransportPropertyBindingSource
            // 
            this.iTransportPropertyBindingSource.AllowNew = true;
            this.iTransportPropertyBindingSource.DataSource = typeof(FuelCalculation.ITransportProperty);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveItemButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.RemoveItemButton.Location = new System.Drawing.Point(208, 381);
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
            this.ModifyItemButton.Location = new System.Drawing.Point(110, 381);
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
            this.AddNewItemButton.Location = new System.Drawing.Point(12, 381);
            this.AddNewItemButton.Name = "AddNewItemButton";
            this.AddNewItemButton.Size = new System.Drawing.Size(92, 23);
            this.AddNewItemButton.TabIndex = 1;
            this.AddNewItemButton.Text = "Add";
            this.AddNewItemButton.UseVisualStyleBackColor = true;
            this.AddNewItemButton.Click += new System.EventHandler(this.AddNewItemButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem,
            this.HelpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(665, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.SaveAsMenuItem,
            this.CloseMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(35, 20);
            this.FileMenuItem.Text = "File";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(110, 22);
            this.OpenMenuItem.Text = "Open";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(110, 22);
            this.SaveMenuItem.Text = "Save";
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            this.SaveAsMenuItem.Size = new System.Drawing.Size(110, 22);
            this.SaveAsMenuItem.Text = "SaveAs";
            // 
            // CloseMenuItem
            // 
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.Size = new System.Drawing.Size(110, 22);
            this.CloseMenuItem.Text = "Close";
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
            // 
            // ModifyItemMenuItem
            // 
            this.ModifyItemMenuItem.Name = "ModifyItemMenuItem";
            this.ModifyItemMenuItem.Size = new System.Drawing.Size(113, 22);
            this.ModifyItemMenuItem.Text = "Modify";
            // 
            // RemoveItemMenuItem
            // 
            this.RemoveItemMenuItem.Name = "RemoveItemMenuItem";
            this.RemoveItemMenuItem.Size = new System.Drawing.Size(113, 22);
            this.RemoveItemMenuItem.Text = "Remove";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem,
            this.ProgramGuideMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(40, 20);
            this.HelpMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(164, 22);
            this.AboutMenuItem.Text = "About";
            // 
            // ProgramGuideMenuItem
            // 
            this.ProgramGuideMenuItem.Name = "ProgramGuideMenuItem";
            this.ProgramGuideMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ProgramGuideMenuItem.Text = "Technical guidance";
            // 
            // TransportListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 431);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.TransportListGroupBox);
            this.Controls.Add(this.ModifyItemButton);
            this.Controls.Add(this.AddNewItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransportListForm";
            this.Text = "Transport Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransportListView_FormClosing);
            this.Load += new System.EventHandler(this.TransportListView_Load);
            this.TransportListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransportListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTransportPropertyBindingSource)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.DataGridView TransportListGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wearRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelWasteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tankVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource iTransportPropertyBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddItemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyItemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveItemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProgramGuideMenuItem;
    }
}

