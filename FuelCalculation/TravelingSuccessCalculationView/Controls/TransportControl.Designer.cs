namespace TravelingSuccessCalculationView
{
    partial class TransportControl
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
            this.TransportTypeComboBox = new System.Windows.Forms.ComboBox();
            this.TransportTypeLabel = new System.Windows.Forms.Label();
            this.CarControl = new TravelingSuccessCalculationView.Controls.CarControl();
            this.HelicopterControl = new TravelingSuccessCalculationView.Controls.HelicopterControl();
            this.SuspendLayout();
            // 
            // TransportTypeComboBox
            // 
            this.TransportTypeComboBox.FormattingEnabled = true;
            this.TransportTypeComboBox.Items.AddRange(new object[] {
            "Car",
            "Helicopter"});
            this.TransportTypeComboBox.Location = new System.Drawing.Point(132, 3);
            this.TransportTypeComboBox.Name = "TransportTypeComboBox";
            this.TransportTypeComboBox.Size = new System.Drawing.Size(122, 21);
            this.TransportTypeComboBox.TabIndex = 21;
            this.TransportTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TransportTypeComboBox_SelectedIndexChanged_1);
            // 
            // TransportTypeLabel
            // 
            this.TransportTypeLabel.AutoSize = true;
            this.TransportTypeLabel.Location = new System.Drawing.Point(3, 6);
            this.TransportTypeLabel.Name = "TransportTypeLabel";
            this.TransportTypeLabel.Size = new System.Drawing.Size(78, 13);
            this.TransportTypeLabel.TabIndex = 35;
            this.TransportTypeLabel.Text = "Transport type:";
            // 
            // CarControl
            // 
            this.CarControl.Location = new System.Drawing.Point(3, 30);
            this.CarControl.Name = "CarControl";
            this.CarControl.Size = new System.Drawing.Size(251, 151);
            this.CarControl.TabIndex = 36;
            // 
            // HelicopterControl
            // 
            this.HelicopterControl.Location = new System.Drawing.Point(3, 30);
            this.HelicopterControl.Name = "HelicopterControl";
            this.HelicopterControl.Size = new System.Drawing.Size(253, 151);
            this.HelicopterControl.TabIndex = 37;
            // 
            // TransportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CarControl);
            this.Controls.Add(this.TransportTypeComboBox);
            this.Controls.Add(this.TransportTypeLabel);
            this.Controls.Add(this.HelicopterControl);
            this.Name = "TransportControl";
            this.Size = new System.Drawing.Size(257, 184);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TransportTypeComboBox;
        private System.Windows.Forms.Label TransportTypeLabel;
        private Controls.CarControl CarControl;
        private Controls.HelicopterControl HelicopterControl;
    }
}
