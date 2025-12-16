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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.layoutGrids = new System.Windows.Forms.TableLayoutPanel();
            this.grpShows = new System.Windows.Forms.GroupBox();
            this.grpPublishers = new System.Windows.Forms.GroupBox();
            this.layoutCharts = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chartPublisherShows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGenreDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFavoritesHistogram)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.layoutMain.SuspendLayout();
            this.layoutGrids.SuspendLayout();
            this.grpShows.SuspendLayout();
            this.grpPublishers.SuspendLayout();
            this.layoutCharts.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartPublisherShows
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPublisherShows.ChartAreas.Add(chartArea1);
            this.chartPublisherShows.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartPublisherShows.Legends.Add(legend1);
            this.chartPublisherShows.Location = new System.Drawing.Point(865, 3);
            this.chartPublisherShows.Name = "chartPublisherShows";
            this.chartPublisherShows.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPublisherShows.Series.Add(series1);
            this.chartPublisherShows.Size = new System.Drawing.Size(426, 338);
            this.chartPublisherShows.TabIndex = 0;
            this.chartPublisherShows.Text = "Publisher Shows";
            // 
            // chartGenreDistribution
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGenreDistribution.ChartAreas.Add(chartArea2);
            this.chartGenreDistribution.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartGenreDistribution.Legends.Add(legend2);
            this.chartGenreDistribution.Location = new System.Drawing.Point(434, 3);
            this.chartGenreDistribution.Name = "chartGenreDistribution";
            this.chartGenreDistribution.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGenreDistribution.Series.Add(series2);
            this.chartGenreDistribution.Size = new System.Drawing.Size(425, 338);
            this.chartGenreDistribution.TabIndex = 2;
            this.chartGenreDistribution.Text = "Genre Distribution";
            // 
            // dataGridViewShows
            // 
            this.dataGridViewShows.AllowUserToAddRows = false;
            this.dataGridViewShows.AllowUserToDeleteRows = false;
            this.dataGridViewShows.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShows.Location = new System.Drawing.Point(10, 33);
            this.dataGridViewShows.Name = "dataGridViewShows";
            this.dataGridViewShows.ReadOnly = true;
            this.dataGridViewShows.RowHeadersWidth = 51;
            this.dataGridViewShows.RowTemplate.Height = 24;
            this.dataGridViewShows.Size = new System.Drawing.Size(621, 295);
            this.dataGridViewShows.TabIndex = 3;
            this.dataGridViewShows.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShows_CellContentClick);
            // 
            // dataGridViewPublishers
            // 
            this.dataGridViewPublishers.AllowUserToAddRows = false;
            this.dataGridViewPublishers.AllowUserToDeleteRows = false;
            this.dataGridViewPublishers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPublishers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPublishers.Location = new System.Drawing.Point(10, 33);
            this.dataGridViewPublishers.Name = "dataGridViewPublishers";
            this.dataGridViewPublishers.ReadOnly = true;
            this.dataGridViewPublishers.RowHeadersWidth = 51;
            this.dataGridViewPublishers.RowTemplate.Height = 24;
            this.dataGridViewPublishers.Size = new System.Drawing.Size(621, 295);
            this.dataGridViewPublishers.TabIndex = 4;
            // 
            // chartFavoritesHistogram
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFavoritesHistogram.ChartAreas.Add(chartArea3);
            this.chartFavoritesHistogram.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartFavoritesHistogram.Legends.Add(legend3);
            this.chartFavoritesHistogram.Location = new System.Drawing.Point(3, 3);
            this.chartFavoritesHistogram.Name = "chartFavoritesHistogram";
            this.chartFavoritesHistogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFavoritesHistogram.Series.Add(series3);
            this.chartFavoritesHistogram.Size = new System.Drawing.Size(425, 338);
            this.chartFavoritesHistogram.TabIndex = 5;
            this.chartFavoritesHistogram.Text = "Favorites";
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1300, 70);
            this.panelTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Platform Statistics";
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 1;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Controls.Add(this.layoutGrids, 0, 0);
            this.layoutMain.Controls.Add(this.layoutCharts, 0, 1);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 70);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 2;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMain.Size = new System.Drawing.Size(1300, 700);
            this.layoutMain.TabIndex = 7;
            // 
            // layoutGrids
            // 
            this.layoutGrids.ColumnCount = 2;
            this.layoutGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutGrids.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutGrids.Controls.Add(this.grpShows, 0, 0);
            this.layoutGrids.Controls.Add(this.grpPublishers, 1, 0);
            this.layoutGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutGrids.Location = new System.Drawing.Point(3, 3);
            this.layoutGrids.Name = "layoutGrids";
            this.layoutGrids.RowCount = 1;
            this.layoutGrids.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutGrids.Size = new System.Drawing.Size(1294, 344);
            this.layoutGrids.TabIndex = 0;
            // 
            // grpShows
            // 
            this.grpShows.Controls.Add(this.dataGridViewShows);
            this.grpShows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpShows.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpShows.Location = new System.Drawing.Point(3, 3);
            this.grpShows.Name = "grpShows";
            this.grpShows.Padding = new System.Windows.Forms.Padding(10);
            this.grpShows.Size = new System.Drawing.Size(641, 338);
            this.grpShows.TabIndex = 0;
            this.grpShows.TabStop = false;
            this.grpShows.Text = "All Shows Data";
            // 
            // grpPublishers
            // 
            this.grpPublishers.Controls.Add(this.dataGridViewPublishers);
            this.grpPublishers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPublishers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpPublishers.Location = new System.Drawing.Point(650, 3);
            this.grpPublishers.Name = "grpPublishers";
            this.grpPublishers.Padding = new System.Windows.Forms.Padding(10);
            this.grpPublishers.Size = new System.Drawing.Size(641, 338);
            this.grpPublishers.TabIndex = 1;
            this.grpPublishers.TabStop = false;
            this.grpPublishers.Text = "Publishers Data";
            // 
            // layoutCharts
            // 
            this.layoutCharts.ColumnCount = 3;
            this.layoutCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.layoutCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.layoutCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.layoutCharts.Controls.Add(this.chartFavoritesHistogram, 0, 0);
            this.layoutCharts.Controls.Add(this.chartGenreDistribution, 1, 0);
            this.layoutCharts.Controls.Add(this.chartPublisherShows, 2, 0);
            this.layoutCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutCharts.Location = new System.Drawing.Point(3, 353);
            this.layoutCharts.Name = "layoutCharts";
            this.layoutCharts.RowCount = 1;
            this.layoutCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutCharts.Size = new System.Drawing.Size(1294, 344);
            this.layoutCharts.TabIndex = 1;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 770);
            this.Controls.Add(this.layoutMain);
            this.Controls.Add(this.panelTitle);
            this.Name = "StatsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics Dashboard";
            this.Load += new System.EventHandler(this.StatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPublisherShows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGenreDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFavoritesHistogram)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.layoutMain.ResumeLayout(false);
            this.layoutGrids.ResumeLayout(false);
            this.grpShows.ResumeLayout(false);
            this.grpPublishers.ResumeLayout(false);
            this.layoutCharts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // DECLARATIONS (Must be present for the code to compile)
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPublisherShows;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGenreDistribution;
        private System.Windows.Forms.DataGridView dataGridViewShows;
        private System.Windows.Forms.DataGridView dataGridViewPublishers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFavoritesHistogram;

        // Layout Containers
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.TableLayoutPanel layoutCharts;
        private System.Windows.Forms.TableLayoutPanel layoutGrids;
        private System.Windows.Forms.GroupBox grpShows;
        private System.Windows.Forms.GroupBox grpPublishers;
    }
}