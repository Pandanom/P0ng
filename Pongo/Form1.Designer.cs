namespace Pongo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PingTmr = new System.Windows.Forms.Timer(this.components);
            this.StBtn = new System.Windows.Forms.Button();
            this.PlLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(151, 58);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(600, 351);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // PingTmr
            // 
            this.PingTmr.Enabled = true;
            this.PingTmr.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StBtn
            // 
            this.StBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StBtn.Location = new System.Drawing.Point(151, 12);
            this.StBtn.Name = "StBtn";
            this.StBtn.Size = new System.Drawing.Size(101, 40);
            this.StBtn.TabIndex = 2;
            this.StBtn.Text = "Stop";
            this.StBtn.UseVisualStyleBackColor = true;
            this.StBtn.Click += new System.EventHandler(this.StBtn_Click);
            // 
            // PlLbl
            // 
            this.PlLbl.AutoSize = true;
            this.PlLbl.Location = new System.Drawing.Point(372, 412);
            this.PlLbl.Name = "PlLbl";
            this.PlLbl.Size = new System.Drawing.Size(86, 17);
            this.PlLbl.TabIndex = 3;
            this.PlLbl.Text = "Loss = 0.0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlLbl);
            this.Controls.Add(this.StBtn);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "P0ng v1.0 by Pandanom";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer PingTmr;
        private System.Windows.Forms.Button StBtn;
        private System.Windows.Forms.Label PlLbl;
        private System.Windows.Forms.Label label1;
    }
}

