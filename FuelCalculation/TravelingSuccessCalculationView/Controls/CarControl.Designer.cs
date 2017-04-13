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
            // 
            // TankVolumeTextBox
            // 
            this.TankVolumeTextBox.Location = new System.Drawing.Point(129, 104);
            this.TankVolumeTextBox.Name = "TankVolumeTextBox";
            this.TankVolumeTextBox.Size = new System.Drawing.Size(61, 20);
            this.TankVolumeTextBox.TabIndex = 56;
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.Location = new System.Drawing.Point(129, 78);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(61, 20);
            this.SpeedTextBox.TabIndex = 54;
            // 
            // FuelWasteTextBox
            // 
            this.FuelWasteTextBox.Location = new System.Drawing.Point(129, 52);
            this.FuelWasteTextBox.Name = "FuelWasteTextBox";
            this.FuelWasteTextBox.Size = new System.Drawing.Size(61, 20);
            this.FuelWasteTextBox.TabIndex = 52;
            // 
            // WearRateTextBox
            // 
            this.WearRateTextBox.Location = new System.Drawing.Point(129, 26);
            this.WearRateTextBox.Name = "WearRateTextBox";
            this.WearRateTextBox.Size = new System.Drawing.Size(61, 20);
            this.WearRateTextBox.TabIndex = 50;
            // 
            // TNameTextBox
            // 
            this.TNameTextBox.Location = new System.Drawing.Point(129, 0);
            this.TNameTextBox.Name = "TNameTextBox";
            this.TNameTextBox.Size = new System.Drawing.Size(122, 20);
            this.TNameTextBox.TabIndex = 48;
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
    }
}
