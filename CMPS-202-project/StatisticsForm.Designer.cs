namespace CMPS_202_project
{
    partial class StatsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPublisherShows = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGenreDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewShows = new System.Windows.Forms.DataGridView();
            this.dataGridViewPublishers = new System.Windows.Forms.DataGridView();
            this.chartFavoritesHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPublisherShows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGenreDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFavoritesHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPublisherShows
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPublisherShows.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPublisherShows.Legends.Add(legend1);
            this.chartPublisherShows.Location = new System.Drawing.Point(1072, 306);
            this.chartPublisherShows.Name = "chartPublisherShows";
            this.chartPublisherShows.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPublisherShows.Series.Add(series1);
            this.chartPublisherShows.Size = new System.Drawing.Size(476, 288);
            this.chartPublisherShows.TabIndex = 0;
            this.chartPublisherShows.Text = "chart1";
            // 
            // chartGenreDistribution
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGenreDistribution.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGenreDistribution.Legends.Add(legend2);
            this.chartGenreDistribution.Location = new System.Drawing.Point(587, 306);
            this.chartGenreDistribution.Name = "chartGenreDistribution";
            this.chartGenreDistribution.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGenreDistribution.Series.Add(series2);
            this.chartGenreDistribution.Size = new System.Drawing.Size(386, 288);
            this.chartGenreDistribution.TabIndex = 2;
            this.chartGenreDistribution.Text = "chart1";
            // 
            // dataGridViewShows
            // 
            this.dataGridViewShows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShows.Location = new System.Drawing.Point(12, 3);
            this.dataGridViewShows.Name = "dataGridViewShows";
            this.dataGridViewShows.RowHeadersWidth = 51;
            this.dataGridViewShows.RowTemplate.Height = 24;
            this.dataGridViewShows.Size = new System.Drawing.Size(594, 297);
            this.dataGridViewShows.TabIndex = 3;
            this.dataGridViewShows.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShows_CellContentClick);
            // 
            // dataGridViewPublishers
            // 
            this.dataGridViewPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPublishers.Location = new System.Drawing.Point(977, 3);
            this.dataGridViewPublishers.Name = "dataGridViewPublishers";
            this.dataGridViewPublishers.RowHeadersWidth = 51;
            this.dataGridViewPublishers.RowTemplate.Height = 24;
            this.dataGridViewPublishers.Size = new System.Drawing.Size(552, 288);
            this.dataGridViewPublishers.TabIndex = 4;
            // 
            // chartFavoritesHistogram
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFavoritesHistogram.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFavoritesHistogram.Legends.Add(legend3);
            this.chartFavoritesHistogram.Location = new System.Drawing.Point(12, 306);
            this.chartFavoritesHistogram.Name = "chartFavoritesHistogram";
            this.chartFavoritesHistogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFavoritesHistogram.Series.Add(series3);
            this.chartFavoritesHistogram.Size = new System.Drawing.Size(404, 297);
            this.chartFavoritesHistogram.TabIndex = 5;
            this.chartFavoritesHistogram.Text = "chart1";
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 606);
            this.Controls.Add(this.chartFavoritesHistogram);
            this.Controls.Add(this.dataGridViewPublishers);
            this.Controls.Add(this.dataGridViewShows);
            this.Controls.Add(this.chartGenreDistribution);
            this.Controls.Add(this.chartPublisherShows);
            this.Name = "StatsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartPublisherShows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGenreDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFavoritesHistogram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPublisherShows;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGenreDistribution;
        private System.Windows.Forms.DataGridView dataGridViewShows;
        private System.Windows.Forms.DataGridView dataGridViewPublishers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFavoritesHistogram;
    }
}