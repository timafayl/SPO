namespace TravelingSuccessCalculationView.Controls
{
    partial class HelicopterControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelicopterControl));
            this.MassTextBox = new System.Windows.Forms.TextBox();
            this.TankVolumeTextBox = new System.Windows.Forms.TextBox();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.FuelWasteTextBox = new System.Windows.Forms.TextBox();
            this.WearRateTextBox = new System.Windows.Forms.TextBox();
            this.TNameTextBox = new System.Windows.Forms.TextBox();
            this.MassLabel = new System.Windows.Forms.Label();
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
            // MassTextBox
            // 
            this.MassTextBox.Location = new System.Drawing.Point(129, 131);
            this.MassTextBox.Name = "MassTextBox";
            this.MassTextBox.Size = new System.Drawing.Size(61, 20);
            this.MassTextBox.TabIndex = 45;
            this.toolTip.SetToolTip(this.MassTextBox, "Transported mass (1-1000 kg)");
            this.MassTextBox.Leave += new System.EventHandler(this.MassTextBox_Leave);
            // 
            // TankVolumeTextBox
            // 
            this.TankVolumeTextBox.Location = new System.Drawing.Point(129, 105);
            this.TankVolumeTextBox.Name = "TankVolumeTextBox";
            this.TankVolumeTextBox.Size = new System.Drawing.Size(61, 20);
            this.TankVolumeTextBox.TabIndex = 43;
            this.toolTip.SetToolTip(this.TankVolumeTextBox, "Transport tank volume. Value have to vary from 50 to 200");
            this.TankVolumeTextBox.Leave += new System.EventHandler(this.TankVolumeTextBox_Leave);
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.Location = new System.Drawing.Point(129, 79);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(61, 20);
            this.SpeedTextBox.TabIndex = 41;
            this.toolTip.SetToolTip(this.SpeedTextBox, "Speed value. Value have to vary from 1 to 400");
            this.SpeedTextBox.Leave += new System.EventHandler(this.SpeedTextBox_Leave);
            // 
            // FuelWasteTextBox
            // 
            this.FuelWasteTextBox.Location = new System.Drawing.Point(129, 53);
            this.FuelWasteTextBox.Name = "FuelWasteTextBox";
            this.FuelWasteTextBox.Size = new System.Drawing.Size(61, 20);
            this.FuelWasteTextBox.TabIndex = 39;
            this.toolTip.SetToolTip(this.FuelWasteTextBox, "Transport fuel waste. Value have to vary from 20 to 50 (l/h)");
            this.FuelWasteTextBox.Leave += new System.EventHandler(this.FuelWasteTextBox_Leave);
            // 
            // WearRateTextBox
            // 
            this.WearRateTextBox.Location = new System.Drawing.Point(129, 27);
            this.WearRateTextBox.Name = "WearRateTextBox";
            this.WearRateTextBox.Size = new System.Drawing.Size(61, 20);
            this.WearRateTextBox.TabIndex = 37;
            this.toolTip.SetToolTip(this.WearRateTextBox, "Transport wear rate. Value have to vary from 0 to 1");
            this.WearRateTextBox.Leave += new System.EventHandler(this.WearRateTextBox_Leave);
            // 
            // TNameTextBox
            // 
            this.TNameTextBox.Location = new System.Drawing.Point(129, 1);
            this.TNameTextBox.Name = "TNameTextBox";
            this.TNameTextBox.Size = new System.Drawing.Size(122, 20);
            this.TNameTextBox.TabIndex = 35;
            this.toolTip.SetToolTip(this.TNameTextBox, "Enter a transport name using a-z letters");
            this.TNameTextBox.Leave += new System.EventHandler(this.TNameTextBox_Leave);
            // 
            // MassLabel
            // 
            this.MassLabel.AutoSize = true;
            this.MassLabel.Location = new System.Drawing.Point(0, 133);
            this.MassLabel.Name = "MassLabel";
            this.MassLabel.Size = new System.Drawing.Size(35, 13);
            this.MassLabel.TabIndex = 46;
            this.MassLabel.Text = "Mass:";
            // 
            // TankVolumeLabel
            // 
            this.TankVolumeLabel.AutoSize = true;
            this.TankVolumeLabel.Location = new System.Drawing.Point(0, 108);
            this.TankVolumeLabel.Name = "TankVolumeLabel";
            this.TankVolumeLabel.Size = new System.Drawing.Size(72, 13);
            this.TankVolumeLabel.TabIndex = 44;
            this.TankVolumeLabel.Text = "Tank volume:";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(0, 82);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(41, 13);
            this.SpeedLabel.TabIndex = 42;
            this.SpeedLabel.Text = "Speed:";
            // 
            // FuelWasteLabel
            // 
            this.FuelWasteLabel.AutoSize = true;
            this.FuelWasteLabel.Location = new System.Drawing.Point(0, 56);
            this.FuelWasteLabel.Name = "FuelWasteLabel";
            this.FuelWasteLabel.Size = new System.Drawing.Size(61, 13);
            this.FuelWasteLabel.TabIndex = 40;
            this.FuelWasteLabel.Text = "Fuel waste:";
            // 
            // WearRateLabel
            // 
            this.WearRateLabel.AutoSize = true;
            this.WearRateLabel.Location = new System.Drawing.Point(0, 30);
            this.WearRateLabel.Name = "WearRateLabel";
            this.WearRateLabel.Size = new System.Drawing.Size(57, 13);
            this.WearRateLabel.TabIndex = 38;
            this.WearRateLabel.Text = "Wear rate:";
            // 
            // TNameLabel
            // 
            this.TNameLabel.AutoSize = true;
            this.TNameLabel.Location = new System.Drawing.Point(0, 4);
            this.TNameLabel.Name = "TNameLabel";
            this.TNameLabel.Size = new System.Drawing.Size(84, 13);
            this.TNameLabel.TabIndex = 36;
            this.TNameLabel.Text = "Transport name:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // HelicopterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MassTextBox);
            this.Controls.Add(this.TankVolumeTextBox);
            this.Controls.Add(this.SpeedTextBox);
            this.Controls.Add(this.FuelWasteTextBox);
            this.Controls.Add(this.WearRateTextBox);
            this.Controls.Add(this.TNameTextBox);
            this.Controls.Add(this.MassLabel);
            this.Controls.Add(this.TankVolumeLabel);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.FuelWasteLabel);
            this.Controls.Add(this.WearRateLabel);
            this.Controls.Add(this.TNameLabel);
            this.Name = "HelicopterControl";
            this.Size = new System.Drawing.Size(253, 151);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MassTextBox;
        private System.Windows.Forms.TextBox TankVolumeTextBox;
        private System.Windows.Forms.TextBox SpeedTextBox;
        private System.Windows.Forms.TextBox FuelWasteTextBox;
        private System.Windows.Forms.TextBox WearRateTextBox;
        private System.Windows.Forms.TextBox TNameTextBox;
        private System.Windows.Forms.Label MassLabel;
        private System.Windows.Forms.Label TankVolumeLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label FuelWasteLabel;
        private System.Windows.Forms.Label WearRateLabel;
        private System.Windows.Forms.Label TNameLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
