namespace TravelingSuccessCalculationView
{
    partial class AddNewTransportForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewTransportForm));
            this.TNameLabel = new System.Windows.Forms.Label();
            this.WearRateLabel = new System.Windows.Forms.Label();
            this.FuelWasteLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.TankVolumeLabel = new System.Windows.Forms.Label();
            this.UniqeFieldLabel = new System.Windows.Forms.Label();
            this.TNameTextBox = new System.Windows.Forms.TextBox();
            this.WearRateTextBox = new System.Windows.Forms.TextBox();
            this.FuelWasteTextBox = new System.Windows.Forms.TextBox();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.TankVolumeTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.FuelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.MassTextBox = new System.Windows.Forms.TextBox();
            this.GenerateRandomValuesButton = new System.Windows.Forms.Button();
            this.ChooseTransportLabel = new System.Windows.Forms.Label();
            this.ChooseTransportComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TNameLabel
            // 
            this.TNameLabel.AutoSize = true;
            this.TNameLabel.Location = new System.Drawing.Point(12, 63);
            this.TNameLabel.Name = "TNameLabel";
            this.TNameLabel.Size = new System.Drawing.Size(84, 13);
            this.TNameLabel.TabIndex = 2;
            this.TNameLabel.Text = "Transport name:";
            // 
            // WearRateLabel
            // 
            this.WearRateLabel.AutoSize = true;
            this.WearRateLabel.Location = new System.Drawing.Point(12, 89);
            this.WearRateLabel.Name = "WearRateLabel";
            this.WearRateLabel.Size = new System.Drawing.Size(57, 13);
            this.WearRateLabel.TabIndex = 3;
            this.WearRateLabel.Text = "Wear rate:";
            // 
            // FuelWasteLabel
            // 
            this.FuelWasteLabel.AutoSize = true;
            this.FuelWasteLabel.Location = new System.Drawing.Point(12, 115);
            this.FuelWasteLabel.Name = "FuelWasteLabel";
            this.FuelWasteLabel.Size = new System.Drawing.Size(61, 13);
            this.FuelWasteLabel.TabIndex = 4;
            this.FuelWasteLabel.Text = "Fuel waste:";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(12, 141);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(41, 13);
            this.SpeedLabel.TabIndex = 5;
            this.SpeedLabel.Text = "Speed:";
            // 
            // TankVolumeLabel
            // 
            this.TankVolumeLabel.AutoSize = true;
            this.TankVolumeLabel.Location = new System.Drawing.Point(12, 167);
            this.TankVolumeLabel.Name = "TankVolumeLabel";
            this.TankVolumeLabel.Size = new System.Drawing.Size(72, 13);
            this.TankVolumeLabel.TabIndex = 6;
            this.TankVolumeLabel.Text = "Tank volume:";
            // 
            // UniqeFieldLabel
            // 
            this.UniqeFieldLabel.AutoSize = true;
            this.UniqeFieldLabel.Location = new System.Drawing.Point(12, 192);
            this.UniqeFieldLabel.Name = "UniqeFieldLabel";
            this.UniqeFieldLabel.Size = new System.Drawing.Size(84, 13);
            this.UniqeFieldLabel.TabIndex = 7;
            this.UniqeFieldLabel.Text = "FuelType/Mass:";
            this.UniqeFieldLabel.Visible = false;
            // 
            // TNameTextBox
            // 
            this.TNameTextBox.Location = new System.Drawing.Point(141, 60);
            this.TNameTextBox.Name = "TNameTextBox";
            this.TNameTextBox.Size = new System.Drawing.Size(122, 20);
            this.TNameTextBox.TabIndex = 2;
            this.TNameTextBox.Leave += new System.EventHandler(this.TNameTextBox_Leave);
            this.TNameTextBox.MouseHover += new System.EventHandler(this.TNameTextBox_MouseHover);
            // 
            // WearRateTextBox
            // 
            this.WearRateTextBox.Location = new System.Drawing.Point(141, 86);
            this.WearRateTextBox.Name = "WearRateTextBox";
            this.WearRateTextBox.Size = new System.Drawing.Size(61, 20);
            this.WearRateTextBox.TabIndex = 3;
            this.WearRateTextBox.Leave += new System.EventHandler(this.WearRateTextBox_Leave);
            this.WearRateTextBox.MouseHover += new System.EventHandler(this.WearRateTextBox_MouseHover);
            // 
            // FuelWasteTextBox
            // 
            this.FuelWasteTextBox.Location = new System.Drawing.Point(141, 112);
            this.FuelWasteTextBox.Name = "FuelWasteTextBox";
            this.FuelWasteTextBox.Size = new System.Drawing.Size(61, 20);
            this.FuelWasteTextBox.TabIndex = 4;
            this.FuelWasteTextBox.Leave += new System.EventHandler(this.FuelWasteTextBox_Leave);
            this.FuelWasteTextBox.MouseHover += new System.EventHandler(this.FuelWasteTextBox_MouseHover);
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.Location = new System.Drawing.Point(141, 138);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(61, 20);
            this.SpeedTextBox.TabIndex = 5;
            this.SpeedTextBox.Leave += new System.EventHandler(this.SpeedTextBox_Leave);
            this.SpeedTextBox.MouseHover += new System.EventHandler(this.SpeedTextBox_MouseHover);
            // 
            // TankVolumeTextBox
            // 
            this.TankVolumeTextBox.Location = new System.Drawing.Point(141, 164);
            this.TankVolumeTextBox.Name = "TankVolumeTextBox";
            this.TankVolumeTextBox.Size = new System.Drawing.Size(61, 20);
            this.TankVolumeTextBox.TabIndex = 6;
            this.TankVolumeTextBox.Leave += new System.EventHandler(this.TankVolumeTextBox_Leave);
            this.TankVolumeTextBox.MouseHover += new System.EventHandler(this.TankVolumeTextBox_MouseHover);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(65, 245);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(69, 23);
            this.OKButton.TabIndex = 10;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // FuelTypeComboBox
            // 
            this.FuelTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FuelTypeComboBox.Items.AddRange(new object[] {
            "Бензин",
            "Дизель"});
            this.FuelTypeComboBox.Location = new System.Drawing.Point(141, 189);
            this.FuelTypeComboBox.Name = "FuelTypeComboBox";
            this.FuelTypeComboBox.Size = new System.Drawing.Size(122, 21);
            this.FuelTypeComboBox.TabIndex = 8;
            this.FuelTypeComboBox.Visible = false;
            this.FuelTypeComboBox.Leave += new System.EventHandler(this.FuelTypeComboBox_Leave);
            this.FuelTypeComboBox.MouseHover += new System.EventHandler(this.FuelTypeComboBox_MouseHover);
            // 
            // MassTextBox
            // 
            this.MassTextBox.Location = new System.Drawing.Point(141, 190);
            this.MassTextBox.Name = "MassTextBox";
            this.MassTextBox.Size = new System.Drawing.Size(61, 20);
            this.MassTextBox.TabIndex = 7;
            this.MassTextBox.Visible = false;
            this.MassTextBox.Leave += new System.EventHandler(this.MassTextBox_Leave);
            this.MassTextBox.MouseHover += new System.EventHandler(this.MassTextBox_MouseHover);
            // 
            // GenerateRandomValuesButton
            // 
            this.GenerateRandomValuesButton.Location = new System.Drawing.Point(30, 216);
            this.GenerateRandomValuesButton.Name = "GenerateRandomValuesButton";
            this.GenerateRandomValuesButton.Size = new System.Drawing.Size(210, 23);
            this.GenerateRandomValuesButton.TabIndex = 1;
            this.GenerateRandomValuesButton.Text = "Generate random values";
            this.GenerateRandomValuesButton.UseVisualStyleBackColor = true;
            this.GenerateRandomValuesButton.Click += new System.EventHandler(this.GenerateRandomValuesButton_Click);
            // 
            // ChooseTransportLabel
            // 
            this.ChooseTransportLabel.AutoSize = true;
            this.ChooseTransportLabel.Location = new System.Drawing.Point(12, 13);
            this.ChooseTransportLabel.Name = "ChooseTransportLabel";
            this.ChooseTransportLabel.Size = new System.Drawing.Size(90, 13);
            this.ChooseTransportLabel.TabIndex = 20;
            this.ChooseTransportLabel.Text = "Choose transport:";
            // 
            // ChooseTransportComboBox
            // 
            this.ChooseTransportComboBox.FormattingEnabled = true;
            this.ChooseTransportComboBox.Items.AddRange(new object[] {
            "Car",
            "Helicopter"});
            this.ChooseTransportComboBox.Location = new System.Drawing.Point(141, 10);
            this.ChooseTransportComboBox.Name = "ChooseTransportComboBox";
            this.ChooseTransportComboBox.Size = new System.Drawing.Size(122, 21);
            this.ChooseTransportComboBox.TabIndex = 0;
            this.ChooseTransportComboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseTransportComboBox_SelectedIndexChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(141, 245);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(69, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddNewTransportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 272);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ChooseTransportComboBox);
            this.Controls.Add(this.ChooseTransportLabel);
            this.Controls.Add(this.GenerateRandomValuesButton);
            this.Controls.Add(this.MassTextBox);
            this.Controls.Add(this.FuelTypeComboBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.TankVolumeTextBox);
            this.Controls.Add(this.SpeedTextBox);
            this.Controls.Add(this.FuelWasteTextBox);
            this.Controls.Add(this.WearRateTextBox);
            this.Controls.Add(this.TNameTextBox);
            this.Controls.Add(this.UniqeFieldLabel);
            this.Controls.Add(this.TankVolumeLabel);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.FuelWasteLabel);
            this.Controls.Add(this.WearRateLabel);
            this.Controls.Add(this.TNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewTransportForm";
            this.Text = "Add New Transport";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TNameLabel;
        private System.Windows.Forms.Label WearRateLabel;
        private System.Windows.Forms.Label FuelWasteLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label TankVolumeLabel;
        private System.Windows.Forms.Label UniqeFieldLabel;
        private System.Windows.Forms.TextBox TNameTextBox;
        private System.Windows.Forms.TextBox WearRateTextBox;
        private System.Windows.Forms.TextBox FuelWasteTextBox;
        private System.Windows.Forms.TextBox SpeedTextBox;
        private System.Windows.Forms.TextBox TankVolumeTextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.ComboBox FuelTypeComboBox;
        private System.Windows.Forms.TextBox MassTextBox;
        private System.Windows.Forms.Button GenerateRandomValuesButton;
        private System.Windows.Forms.Label ChooseTransportLabel;
        private System.Windows.Forms.ComboBox ChooseTransportComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip;
    }
}