namespace WeatherDashboardWinForms.Components.Common
{
    partial class BrazilMapComponent
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
            this._brazilMap = new LiveCharts.WinForms.GeoMap();
            this.SuspendLayout();
            // 
            // geoMap1
            // 
            this._brazilMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this._brazilMap.Location = new System.Drawing.Point(0, 0);
            this._brazilMap.Name = "_brazilMap";
            this._brazilMap.Source = "D:\\luizm\\Documents\\Projetos\\Weather-Dashboard\\WeatherDashboard.WinForms\\Assets\\Brazil.xml";
            this._brazilMap.Size = new System.Drawing.Size(817, 516);
            this._brazilMap.TabIndex = 0;
            this._brazilMap.Text = "geoMap1";
            // 
            // BrazilMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._brazilMap);
            this.Name = "BrazilMapComponent";
            this.Size = new System.Drawing.Size(817, 516);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.GeoMap _brazilMap;
    }
}
