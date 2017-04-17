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
            this.OKButton = new System.Windows.Forms.Button();
            this.GenerateRandomValuesButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TransportControl = new TravelingSuccessCalculationView.TransportControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(66, 231);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(69, 23);
            this.OKButton.TabIndex = 10;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // GenerateRandomValuesButton
            // 
            this.GenerateRandomValuesButton.Location = new System.Drawing.Point(30, 202);
            this.GenerateRandomValuesButton.Name = "GenerateRandomValuesButton";
            this.GenerateRandomValuesButton.Size = new System.Drawing.Size(210, 23);
            this.GenerateRandomValuesButton.TabIndex = 1;
            this.GenerateRandomValuesButton.Text = "Generate random values";
            this.GenerateRandomValuesButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(141, 231);
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
            // TransportControl
            // 
            this.TransportControl.Location = new System.Drawing.Point(12, 12);
            this.TransportControl.Name = "TransportControl";
            this.TransportControl.ReadOnly = false;
            this.TransportControl.Size = new System.Drawing.Size(257, 184);
            this.TransportControl.TabIndex = 13;
            this.TransportControl.Transport = null;
            // 
            // AddNewTransportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 266);
            this.Controls.Add(this.TransportControl);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.GenerateRandomValuesButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewTransportForm";
            this.Text = "Add New Transport";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button GenerateRandomValuesButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip;
        private TransportControl TransportControl;
    }
}