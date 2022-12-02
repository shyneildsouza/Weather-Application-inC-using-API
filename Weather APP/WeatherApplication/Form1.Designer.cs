namespace WeatherApplication
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.labCondition = new System.Windows.Forms.Label();
            this.labelsunrise = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.labelsunset = new System.Windows.Forms.Label();
            this.labwindspeed = new System.Windows.Forms.Label();
            this.labelwind = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.labCond = new System.Windows.Forms.Label();
            this.labdescrip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter City:";
            // 
            // TBCity
            // 
            this.TBCity.AccessibleName = "City";
            this.TBCity.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TBCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(297, 26);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(255, 31);
            this.TBCity.TabIndex = 1;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Black;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Location = new System.Drawing.Point(602, 26);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(97, 31);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.Location = new System.Drawing.Point(105, 146);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(95, 24);
            this.labCondition.TabIndex = 4;
            this.labCondition.Text = "Condition:";
            // 
            // labelsunrise
            // 
            this.labelsunrise.AutoSize = true;
            this.labelsunrise.BackColor = System.Drawing.Color.Transparent;
            this.labelsunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsunrise.Location = new System.Drawing.Point(105, 244);
            this.labelsunrise.Name = "labelsunrise";
            this.labelsunrise.Size = new System.Drawing.Size(79, 24);
            this.labelsunrise.TabIndex = 5;
            this.labelsunrise.Text = "Sunrise:";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.Location = new System.Drawing.Point(105, 187);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(109, 24);
            this.labDetails.TabIndex = 6;
            this.labDetails.Text = "Description:";
            // 
            // labSunrise
            // 
            this.labSunrise.AccessibleName = "";
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.Location = new System.Drawing.Point(190, 244);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(37, 24);
            this.labSunrise.TabIndex = 7;
            this.labSunrise.Text = "NA";
            // 
            // labSunset
            // 
            this.labSunset.AccessibleName = "";
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.Location = new System.Drawing.Point(517, 244);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(37, 24);
            this.labSunset.TabIndex = 9;
            this.labSunset.Text = "NA";
            // 
            // labelsunset
            // 
            this.labelsunset.AutoSize = true;
            this.labelsunset.BackColor = System.Drawing.Color.Transparent;
            this.labelsunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsunset.Location = new System.Drawing.Point(432, 244);
            this.labelsunset.Name = "labelsunset";
            this.labelsunset.Size = new System.Drawing.Size(73, 24);
            this.labelsunset.TabIndex = 8;
            this.labelsunset.Text = "Sunset:";
            // 
            // labwindspeed
            // 
            this.labwindspeed.AccessibleName = "LabSunrise";
            this.labwindspeed.AutoSize = true;
            this.labwindspeed.BackColor = System.Drawing.Color.Transparent;
            this.labwindspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labwindspeed.Location = new System.Drawing.Point(578, 146);
            this.labwindspeed.Name = "labwindspeed";
            this.labwindspeed.Size = new System.Drawing.Size(37, 24);
            this.labwindspeed.TabIndex = 11;
            this.labwindspeed.Text = "NA";
            // 
            // labelwind
            // 
            this.labelwind.AutoSize = true;
            this.labelwind.BackColor = System.Drawing.Color.Transparent;
            this.labelwind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwind.Location = new System.Drawing.Point(432, 146);
            this.labelwind.Name = "labelwind";
            this.labelwind.Size = new System.Drawing.Size(120, 24);
            this.labelwind.TabIndex = 10;
            this.labelwind.Text = "Wind Speed:";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.Location = new System.Drawing.Point(578, 187);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(37, 24);
            this.labPressure.TabIndex = 13;
            this.labPressure.Text = "NA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(432, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "Pressure:";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(297, 74);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(100, 50);
            this.picIcon.TabIndex = 14;
            this.picIcon.TabStop = false;
            // 
            // FLP
            // 
            this.FLP.AutoScroll = true;
            this.FLP.BackColor = System.Drawing.Color.Transparent;
            this.FLP.Location = new System.Drawing.Point(94, 338);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(605, 100);
            this.FLP.TabIndex = 15;
            this.FLP.WrapContents = false;
            // 
            // labCond
            // 
            this.labCond.AccessibleName = "LabSunrise";
            this.labCond.AutoSize = true;
            this.labCond.BackColor = System.Drawing.Color.Transparent;
            this.labCond.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCond.Location = new System.Drawing.Point(236, 146);
            this.labCond.Name = "labCond";
            this.labCond.Size = new System.Drawing.Size(37, 24);
            this.labCond.TabIndex = 16;
            this.labCond.Text = "NA";
            // 
            // labdescrip
            // 
            this.labdescrip.AccessibleName = "";
            this.labdescrip.AutoSize = true;
            this.labdescrip.BackColor = System.Drawing.Color.Transparent;
            this.labdescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdescrip.Location = new System.Drawing.Point(236, 187);
            this.labdescrip.Name = "labdescrip";
            this.labdescrip.Size = new System.Drawing.Size(37, 24);
            this.labdescrip.TabIndex = 17;
            this.labdescrip.Text = "NA";
            // 
            // Form1
            // 
            this.AccessibleName = "btnSearch";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherApplication.Properties.Resources.pexels_pixabay_414837;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labdescrip);
            this.Controls.Add(this.labCond);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labwindspeed);
            this.Controls.Add(this.labelwind);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.labelsunset);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labelsunrise);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.search);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labelsunrise;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label labelsunset;
        private System.Windows.Forms.Label labwindspeed;
        private System.Windows.Forms.Label labelwind;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private System.Windows.Forms.Label labCond;
        private System.Windows.Forms.Label labdescrip;
    }
}

