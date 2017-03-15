namespace TravelingSuccessCalculationView
{
    partial class TransportListView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transportNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wearRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelWasteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tankVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTransportPropertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTransportPropertyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 489);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TransportList";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transportNameDataGridViewTextBoxColumn,
            this.wearRateDataGridViewTextBoxColumn,
            this.fuelWasteDataGridViewTextBoxColumn,
            this.speedDataGridViewTextBoxColumn,
            this.tankVolumeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iTransportPropertyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(549, 415);
            this.dataGridView1.TabIndex = 4;
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
            this.iTransportPropertyBindingSource.DataSource = typeof(FuelCalculation.ITransportProperty);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(394, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Remove Transport";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Change Transport";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Transport";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TransportListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 493);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TransportListView";
            this.Text = "TransportForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransportListView_FormClosing);
            this.Load += new System.EventHandler(this.TransportListView_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTransportPropertyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wearRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelWasteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tankVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource iTransportPropertyBindingSource;
    }
}

