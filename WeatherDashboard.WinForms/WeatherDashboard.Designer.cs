namespace WeatherDashboardWinForms
{
    partial class WeatherDashboard
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
            this.brazilMap1 = new Components.Common.BrazilMapComponent();
            this.SuspendLayout();
            // 
            // brazilMap1
            // 
            this.brazilMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brazilMap1.Location = new System.Drawing.Point(0, 0);
            this.brazilMap1.Name = "brazilMap1";
            this.brazilMap1.Size = new System.Drawing.Size(800, 450);
            this.brazilMap1.TabIndex = 0;
            // 
            // WeatherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brazilMap1);
            this.Name = "WeatherDashboard";
            this.Text = "Weather Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.Common.BrazilMapComponent brazilMap1;
    }
}

