namespace IT3_Fuck
{
    partial class Fourea
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.FoureaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.FoureaChart)).BeginInit();
            this.SuspendLayout();
            // 
            // FoureaChart
            // 
            chartArea1.Name = "ChartArea1";
            this.FoureaChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.FoureaChart.Legends.Add(legend1);
            this.FoureaChart.Location = new System.Drawing.Point(9, 10);
            this.FoureaChart.Margin = new System.Windows.Forms.Padding(2);
            this.FoureaChart.Name = "FoureaChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Indigo;
            series1.Legend = "Legend1";
            series1.LegendText = "source";
            series1.Name = "Series1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.LimeGreen;
            series2.Legend = "Legend1";
            series2.LegendText = "predict";
            series2.Name = "Series2";
            this.FoureaChart.Series.Add(series1);
            this.FoureaChart.Series.Add(series2);
            this.FoureaChart.Size = new System.Drawing.Size(1015, 435);
            this.FoureaChart.TabIndex = 1;
            this.FoureaChart.Text = "chart1";
            // 
            // Fourea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 454);
            this.Controls.Add(this.FoureaChart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Fourea";
            this.Text = "Fourea";
            this.Load += new System.EventHandler(this.Fourea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FoureaChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart FoureaChart;
    }
}