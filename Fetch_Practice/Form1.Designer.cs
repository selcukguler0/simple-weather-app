namespace Fetch_Practice
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
            this.cityName = new System.Windows.Forms.TextBox();
            this.getWeather = new System.Windows.Forms.Button();
            this.degree = new System.Windows.Forms.Label();
            this.minDeg = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.maxDeg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Degree";
            // 
            // cityName
            // 
            this.cityName.Location = new System.Drawing.Point(69, 48);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(120, 20);
            this.cityName.TabIndex = 1;
            // 
            // getWeather
            // 
            this.getWeather.Location = new System.Drawing.Point(69, 74);
            this.getWeather.Name = "getWeather";
            this.getWeather.Size = new System.Drawing.Size(120, 28);
            this.getWeather.TabIndex = 2;
            this.getWeather.Text = "Find Weather";
            this.getWeather.UseVisualStyleBackColor = true;
            this.getWeather.Click += new System.EventHandler(this.getWeather_Click);
            // 
            // degree
            // 
            this.degree.AutoSize = true;
            this.degree.Location = new System.Drawing.Point(288, 48);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(0, 13);
            this.degree.TabIndex = 3;
            // 
            // minDeg
            // 
            this.minDeg.AutoSize = true;
            this.minDeg.Location = new System.Drawing.Point(288, 74);
            this.minDeg.Name = "minDeg";
            this.minDeg.Size = new System.Drawing.Size(0, 13);
            this.minDeg.TabIndex = 5;
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(214, 74);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(62, 13);
            this.min.TabIndex = 4;
            this.min.Text = "Min Degree";
            // 
            // maxDeg
            // 
            this.maxDeg.AutoSize = true;
            this.maxDeg.Location = new System.Drawing.Point(288, 99);
            this.maxDeg.Name = "maxDeg";
            this.maxDeg.Size = new System.Drawing.Size(0, 13);
            this.maxDeg.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Max Degree";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 161);
            this.Controls.Add(this.maxDeg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minDeg);
            this.Controls.Add(this.min);
            this.Controls.Add(this.degree);
            this.Controls.Add(this.getWeather);
            this.Controls.Add(this.cityName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "WEATHER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityName;
        private System.Windows.Forms.Button getWeather;
        private System.Windows.Forms.Label degree;
        private System.Windows.Forms.Label minDeg;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label maxDeg;
        private System.Windows.Forms.Label label5;
    }
}

