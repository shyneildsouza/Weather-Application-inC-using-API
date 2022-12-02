namespace WeatherApplication
{
    partial class Forecastuc
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
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            this.labeldt = new System.Windows.Forms.Label();
            this.labWeatherCondition = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Location = new System.Drawing.Point(14, 16);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(49, 50);
            this.picWeatherIcon.TabIndex = 0;
            this.picWeatherIcon.TabStop = false;
            // 
            // labeldt
            // 
            this.labeldt.AutoSize = true;
            this.labeldt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldt.Location = new System.Drawing.Point(90, 0);
            this.labeldt.Name = "labeldt";
            this.labeldt.Size = new System.Drawing.Size(80, 24);
            this.labeldt.TabIndex = 1;
            this.labeldt.Text = "Sunday";
            // 
            // labWeatherCondition
            // 
            this.labWeatherCondition.AutoSize = true;
            this.labWeatherCondition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWeatherCondition.Location = new System.Drawing.Point(90, 26);
            this.labWeatherCondition.Name = "labWeatherCondition";
            this.labWeatherCondition.Size = new System.Drawing.Size(43, 19);
            this.labWeatherCondition.TabIndex = 2;
            this.labWeatherCondition.Text = "Clear";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(90, 53);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(94, 18);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description";
            // 
            // Forecastuc
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labWeatherCondition);
            this.Controls.Add(this.labeldt);
            this.Controls.Add(this.picWeatherIcon);
            this.Name = "Forecastuc";
            this.Size = new System.Drawing.Size(400, 83);
            this.Load += new System.EventHandler(this.Forecastuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labdt;
        public System.Windows.Forms.PictureBox picWeatherIcon;
        public System.Windows.Forms.Label labeldt;
        public System.Windows.Forms.Label labWeatherCondition;
        public System.Windows.Forms.Label labelDescription;
    }
}
