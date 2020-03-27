namespace IT3_Degradation
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Freq5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Freq4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Freq3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Freq2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Freq1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Amp5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Amp4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Amp3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Amp2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Amp1 = new System.Windows.Forms.TextBox();
            this.DrawButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SizeText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NoiseText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SizeMText = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.EdgeText = new System.Windows.Forms.TextBox();
            this.FoureaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainChart
            // 
            chartArea1.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.MainChart.Legends.Add(legend1);
            this.MainChart.Location = new System.Drawing.Point(9, 10);
            this.MainChart.Margin = new System.Windows.Forms.Padding(2);
            this.MainChart.Name = "MainChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Indigo;
            series1.Legend = "Legend1";
            series1.LegendText = "Source signal";
            series1.Name = "Series1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.LimeGreen;
            series2.Legend = "Legend1";
            series2.LegendText = "Prediction";
            series2.Name = "Series2";
            this.MainChart.Series.Add(series1);
            this.MainChart.Series.Add(series2);
            this.MainChart.Size = new System.Drawing.Size(781, 345);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Freq5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Freq4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Freq3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Freq2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Freq1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Amp5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Amp4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Amp3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Amp2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Amp1);
            this.groupBox1.Location = new System.Drawing.Point(794, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(262, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters of harmonics";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(131, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Frequency №5";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Freq5
            // 
            this.Freq5.Location = new System.Drawing.Point(213, 114);
            this.Freq5.Margin = new System.Windows.Forms.Padding(2);
            this.Freq5.Name = "Freq5";
            this.Freq5.Size = new System.Drawing.Size(42, 20);
            this.Freq5.TabIndex = 21;
            this.Freq5.Text = "0.4";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(131, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Frequency №4";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Freq4
            // 
            this.Freq4.Location = new System.Drawing.Point(213, 91);
            this.Freq4.Margin = new System.Windows.Forms.Padding(2);
            this.Freq4.Name = "Freq4";
            this.Freq4.Size = new System.Drawing.Size(42, 20);
            this.Freq4.TabIndex = 19;
            this.Freq4.Text = "0.5";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(131, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Frequency №3";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Freq3
            // 
            this.Freq3.Location = new System.Drawing.Point(213, 68);
            this.Freq3.Margin = new System.Windows.Forms.Padding(2);
            this.Freq3.Name = "Freq3";
            this.Freq3.Size = new System.Drawing.Size(42, 20);
            this.Freq3.TabIndex = 17;
            this.Freq3.Text = "0.2";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(131, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Frequency №2";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Freq2
            // 
            this.Freq2.Location = new System.Drawing.Point(213, 46);
            this.Freq2.Margin = new System.Windows.Forms.Padding(2);
            this.Freq2.Name = "Freq2";
            this.Freq2.Size = new System.Drawing.Size(42, 20);
            this.Freq2.TabIndex = 15;
            this.Freq2.Text = "0.1";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(131, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Frequency №1";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Freq1
            // 
            this.Freq1.Location = new System.Drawing.Point(213, 23);
            this.Freq1.Margin = new System.Windows.Forms.Padding(2);
            this.Freq1.Name = "Freq1";
            this.Freq1.Size = new System.Drawing.Size(42, 20);
            this.Freq1.TabIndex = 13;
            this.Freq1.Text = "0.3";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Amplitude №5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Amp5
            // 
            this.Amp5.Location = new System.Drawing.Point(86, 114);
            this.Amp5.Margin = new System.Windows.Forms.Padding(2);
            this.Amp5.Name = "Amp5";
            this.Amp5.Size = new System.Drawing.Size(42, 20);
            this.Amp5.TabIndex = 11;
            this.Amp5.Text = "5";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amplitude №4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Amp4
            // 
            this.Amp4.Location = new System.Drawing.Point(86, 91);
            this.Amp4.Margin = new System.Windows.Forms.Padding(2);
            this.Amp4.Name = "Amp4";
            this.Amp4.Size = new System.Drawing.Size(42, 20);
            this.Amp4.TabIndex = 9;
            this.Amp4.Text = "4";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amplitude №3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Amp3
            // 
            this.Amp3.Location = new System.Drawing.Point(86, 68);
            this.Amp3.Margin = new System.Windows.Forms.Padding(2);
            this.Amp3.Name = "Amp3";
            this.Amp3.Size = new System.Drawing.Size(42, 20);
            this.Amp3.TabIndex = 7;
            this.Amp3.Text = "3";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amplitude №2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Amp2
            // 
            this.Amp2.Location = new System.Drawing.Point(86, 46);
            this.Amp2.Margin = new System.Windows.Forms.Padding(2);
            this.Amp2.Name = "Amp2";
            this.Amp2.Size = new System.Drawing.Size(42, 20);
            this.Amp2.TabIndex = 5;
            this.Amp2.Text = "2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amplitude №1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Amp1
            // 
            this.Amp1.Location = new System.Drawing.Point(86, 23);
            this.Amp1.Margin = new System.Windows.Forms.Padding(2);
            this.Amp1.Name = "Amp1";
            this.Amp1.Size = new System.Drawing.Size(42, 20);
            this.Amp1.TabIndex = 3;
            this.Amp1.Text = "1";
            // 
            // DrawButton
            // 
            this.DrawButton.BackColor = System.Drawing.Color.LawnGreen;
            this.DrawButton.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawButton.Location = new System.Drawing.Point(802, 267);
            this.DrawButton.Margin = new System.Windows.Forms.Padding(2);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(255, 41);
            this.DrawButton.TabIndex = 4;
            this.DrawButton.Text = "Research";
            this.DrawButton.UseVisualStyleBackColor = false;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(799, 166);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Readouts";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SizeText
            // 
            this.SizeText.Location = new System.Drawing.Point(880, 166);
            this.SizeText.Margin = new System.Windows.Forms.Padding(2);
            this.SizeText.Name = "SizeText";
            this.SizeText.Size = new System.Drawing.Size(42, 20);
            this.SizeText.TabIndex = 23;
            this.SizeText.Text = "256";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(799, 188);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Noise, %";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoiseText
            // 
            this.NoiseText.Location = new System.Drawing.Point(880, 188);
            this.NoiseText.Margin = new System.Windows.Forms.Padding(2);
            this.NoiseText.Name = "NoiseText";
            this.NoiseText.Size = new System.Drawing.Size(42, 20);
            this.NoiseText.TabIndex = 25;
            this.NoiseText.Text = "0";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(799, 211);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "Amount of H.";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmountText
            // 
            this.AmountText.Location = new System.Drawing.Point(880, 211);
            this.AmountText.Margin = new System.Windows.Forms.Padding(2);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(42, 20);
            this.AmountText.TabIndex = 27;
            this.AmountText.Text = "5";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(799, 234);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 18);
            this.label14.TabIndex = 28;
            this.label14.Text = "Order";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SizeMText
            // 
            this.SizeMText.Location = new System.Drawing.Point(880, 234);
            this.SizeMText.Margin = new System.Windows.Forms.Padding(2);
            this.SizeMText.Name = "SizeMText";
            this.SizeMText.Size = new System.Drawing.Size(42, 20);
            this.SizeMText.TabIndex = 29;
            this.SizeMText.Text = "15";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(926, 166);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 18);
            this.label16.TabIndex = 31;
            this.label16.Text = "Threshold";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EdgeText
            // 
            this.EdgeText.Location = new System.Drawing.Point(1007, 166);
            this.EdgeText.Margin = new System.Windows.Forms.Padding(2);
            this.EdgeText.Name = "EdgeText";
            this.EdgeText.Size = new System.Drawing.Size(42, 20);
            this.EdgeText.TabIndex = 32;
            this.EdgeText.Text = "30";
            // 
            // FoureaButton
            // 
            this.FoureaButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.FoureaButton.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoureaButton.Location = new System.Drawing.Point(802, 314);
            this.FoureaButton.Margin = new System.Windows.Forms.Padding(2);
            this.FoureaButton.Name = "FoureaButton";
            this.FoureaButton.Size = new System.Drawing.Size(255, 41);
            this.FoureaButton.TabIndex = 33;
            this.FoureaButton.Text = "Spectrum";
            this.FoureaButton.UseVisualStyleBackColor = false;
            this.FoureaButton.Click += new System.EventHandler(this.FoureaButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 364);
            this.Controls.Add(this.FoureaButton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.EdgeText);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SizeMText);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.AmountText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NoiseText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.SizeText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainChart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Signal prediction";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Freq5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Freq4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Freq3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Freq2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Freq1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Amp5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Amp4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Amp3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Amp2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Amp1;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SizeText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NoiseText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox AmountText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SizeMText;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox EdgeText;
        private System.Windows.Forms.Button FoureaButton;
    }
}

