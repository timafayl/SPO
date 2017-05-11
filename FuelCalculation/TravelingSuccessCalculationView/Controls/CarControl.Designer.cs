namespace TravelingSuccessCalculationView.Controls
{
    partial class CarControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarControl));
            this.FuelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.TankVolumeTextBox = new System.Windows.Forms.TextBox();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.FuelWasteTextBox = new System.Windows.Forms.TextBox();
            this.WearRateTextBox = new System.Windows.Forms.TextBox();
            this.TNameTextBox = new System.Windows.Forms.TextBox();
            this.FuelTypeLabel = new System.Windows.Forms.Label();
            this.TankVolumeLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.FuelWasteLabel = new System.Windows.Forms.Label();
            this.WearRateLabel = new System.Windows.Forms.Label();
            this.TNameLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FuelTypeComboBox
            // 
            this.FuelTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FuelTypeComboBox.Items.AddRange(new object[] {
            "Бензин",
            "Дизель"});
            this.FuelTypeComboBox.Location = new System.Drawing.Point(129, 129);
            this.FuelTypeComboBox.Name = "FuelTypeComboBox";
            this.FuelTypeComboBox.Size = new System.Drawing.Size(122, 21);
            this.FuelTypeComboBox.TabIndex = 60;
            this.toolTip.SetToolTip(this.FuelTypeComboBox, "Transport fuel type");
            this.FuelTypeComboBox.Leave += new System.EventHandler(this.FuelTypeComboBox_Leave);
            // 
            // TankVolumeTextBox
            // 
            this.TankVolumeTextBox.Location = new System.Drawing.Point(129, 104);
            this.TankVolumeTextBox.Name = "TankVolumeTextBox";
            this.TankVolumeTextBox.Size = new System.Drawing.Size(61, 20);
            this.TankVolumeTextBox.TabIndex = 56;
            this.toolTip.SetToolTip(this.TankVolumeTextBox, "Transport tank volume. Value have to vary from 20 to 100");
            this.TankVolumeTextBox.Leave += new System.EventHandler(this.TankVolumeTextBox_Leave);
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.Location = new System.Drawing.Point(129, 78);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(61, 20);
            this.SpeedTextBox.TabIndex = 54;
            this.toolTip.SetToolTip(this.SpeedTextBox, "Speed value. Value have to vary from 1 to 180");
            this.SpeedTextBox.Leave += new System.EventHandler(this.SpeedTextBox_Leave);
            // 
            // FuelWasteTextBox
            // 
            this.FuelWasteTextBox.Location = new System.Drawing.Point(129, 52);
            this.FuelWasteTextBox.Name = "FuelWasteTextBox";
            this.FuelWasteTextBox.Size = new System.Drawing.Size(61, 20);
            this.FuelWasteTextBox.TabIndex = 52;
            this.toolTip.SetToolTip(this.FuelWasteTextBox, "Transport fuel waste. Value have to vary from 5 to 30");
            this.FuelWasteTextBox.Leave += new System.EventHandler(this.FuelWasteTextBox_Leave);
            // 
            // WearRateTextBox
            // 
            this.WearRateTextBox.Location = new System.Drawing.Point(129, 26);
            this.WearRateTextBox.Name = "WearRateTextBox";
            this.WearRateTextBox.Size = new System.Drawing.Size(61, 20);
            this.WearRateTextBox.TabIndex = 50;
            this.toolTip.SetToolTip(this.WearRateTextBox, "Transport wear rate. Value have to vary from 0 to 1");
            this.WearRateTextBox.Leave += new System.EventHandler(this.WearRateTextBox_Leave);
            // 
            // TNameTextBox
            // 
            this.TNameTextBox.Location = new System.Drawing.Point(129, 0);
            this.TNameTextBox.Name = "TNameTextBox";
            this.TNameTextBox.Size = new System.Drawing.Size(122, 20);
            this.TNameTextBox.TabIndex = 48;
            this.toolTip.SetToolTip(this.TNameTextBox, "Enter a transport name using a-z letters");
            this.TNameTextBox.Leave += new System.EventHandler(this.TNameTextBox_Leave);
            // 
            // FuelTypeLabel
            // 
            this.FuelTypeLabel.AutoSize = true;
            this.FuelTypeLabel.Location = new System.Drawing.Point(0, 133);
            this.FuelTypeLabel.Name = "FuelTypeLabel";
            this.FuelTypeLabel.Size = new System.Drawing.Size(53, 13);
            this.FuelTypeLabel.TabIndex = 59;
            this.FuelTypeLabel.Text = "Fuel type:";
            // 
            // TankVolumeLabel
            // 
            this.TankVolumeLabel.AutoSize = true;
            this.TankVolumeLabel.Location = new System.Drawing.Point(0, 107);
            this.TankVolumeLabel.Name = "TankVolumeLabel";
            this.TankVolumeLabel.Size = new System.Drawing.Size(72, 13);
            this.TankVolumeLabel.TabIndex = 57;
            this.TankVolumeLabel.Text = "Tank volume:";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(0, 81);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(41, 13);
            this.SpeedLabel.TabIndex = 55;
            this.SpeedLabel.Text = "Speed:";
            // 
            // FuelWasteLabel
            // 
            this.FuelWasteLabel.AutoSize = true;
            this.FuelWasteLabel.Location = new System.Drawing.Point(0, 55);
            this.FuelWasteLabel.Name = "FuelWasteLabel";
            this.FuelWasteLabel.Size = new System.Drawing.Size(61, 13);
            this.FuelWasteLabel.TabIndex = 53;
            this.FuelWasteLabel.Text = "Fuel waste:";
            // 
            // WearRateLabel
            // 
            this.WearRateLabel.AutoSize = true;
            this.WearRateLabel.Location = new System.Drawing.Point(0, 29);
            this.WearRateLabel.Name = "WearRateLabel";
            this.WearRateLabel.Size = new System.Drawing.Size(57, 13);
            this.WearRateLabel.TabIndex = 51;
            this.WearRateLabel.Text = "Wear rate:";
            // 
            // TNameLabel
            // 
            this.TNameLabel.AutoSize = true;
            this.TNameLabel.Location = new System.Drawing.Point(0, 3);
            this.TNameLabel.Name = "TNameLabel";
            this.TNameLabel.Size = new System.Drawing.Size(84, 13);
            this.TNameLabel.TabIndex = 49;
            this.TNameLabel.Text = "Transport name:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // CarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FuelTypeComboBox);
            this.Controls.Add(this.TankVolumeTextBox);
            this.Controls.Add(this.SpeedTextBox);
            this.Controls.Add(this.FuelWasteTextBox);
            this.Controls.Add(this.WearRateTextBox);
            this.Controls.Add(this.TNameTextBox);
            this.Controls.Add(this.FuelTypeLabel);
            this.Controls.Add(this.TankVolumeLabel);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.FuelWasteLabel);
            this.Controls.Add(this.WearRateLabel);
            this.Controls.Add(this.TNameLabel);
            this.Name = "CarControl";
            this.Size = new System.Drawing.Size(251, 151);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FuelTypeComboBox;
        private System.Windows.Forms.TextBox TankVolumeTextBox;
        private System.Windows.Forms.TextBox SpeedTextBox;
        private System.Windows.Forms.TextBox FuelWasteTextBox;
        private System.Windows.Forms.TextBox WearRateTextBox;
        private System.Windows.Forms.TextBox TNameTextBox;
        private System.Windows.Forms.Label FuelTypeLabel;
        private System.Windows.Forms.Label TankVolumeLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label FuelWasteLabel;
        private System.Windows.Forms.Label WearRateLabel;
        private System.Windows.Forms.Label TNameLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
