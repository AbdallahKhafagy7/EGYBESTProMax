using System;
using DBapplication;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CMPS_202_project
{
    public partial class StatsForm : Form
    {
        Controller controller = new Controller();
        DBManager dbMan = new DBManager(); 

        public StatsForm()
        {
            InitializeComponent();
            LoadData();
            LoadCharts();
        }

        private void LoadData()
        {
            
            dataGridViewShows.DataSource = dbMan.ExecuteReader(
                "SELECT M.MediaID, M.Name, M.NumOfFavs, M.Finished, P.UserID, U.Name as PublisherName " +
                "FROM Media M " +
                "JOIN Publisher P ON M.PublisherID = P.PublisherID " +
                "JOIN [User] U ON P.UserID = U.UserID");

           
            dataGridViewPublishers.DataSource = dbMan.ExecuteReader(
                "SELECT U.UserID, U.Name, U.Email, P.Website " +
                "FROM [User] U " +
                "JOIN Publisher P ON U.UserID = P.UserID");
        }

        private void LoadCharts()
        {
            LoadPublisherShowsChart();
            //LoadShowRatingsChart();
            LoadFavoritesHistogram();
            LoadGenreDistribution();
        }

        private void LoadPublisherShowsChart()
        {
            DataTable dt = dbMan.ExecuteReader(
                "SELECT P.UserID, U.Name, COUNT(M.MediaID) as ShowCount " +
                "FROM Publisher P " +
                "JOIN [User] U ON P.UserID = U.UserID " +
                "LEFT JOIN Media M ON P.PublisherID = M.PublisherID " +
                "GROUP BY P.UserID, U.Name");

            chartPublisherShows.Series.Clear();
            var series = chartPublisherShows.Series.Add("Shows");
            series.ChartType = SeriesChartType.Bar;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(row["Name"], row["ShowCount"]);
            }
        }

       /* private void LoadShowRatingsChart()
        {
            DataTable dt = dbMan.ExecuteReader(
                "SELECT M.Name, AVG(MR.Rating) as AvgRating " +
                "FROM Media M " +
                "LEFT JOIN MediaRating MR ON M.MediaID = MR.MediaID " +
                "GROUP BY M.Name");

            chartShowRatings.Series.Clear();
            var series = chartShowRatings.Series.Add("Avg Rating");
            series.ChartType = SeriesChartType.Line;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(row["Name"], row["AvgRating"]);
            }

            chartShowRatings.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
        }*/

        private void LoadFavoritesHistogram()
        {
            DataTable dt = dbMan.ExecuteReader("SELECT NumOfFavs FROM Media");

            Dictionary<int, int> bins = new Dictionary<int, int>();
            foreach (DataRow row in dt.Rows)
            {
                int fav = Convert.ToInt32(row["NumOfFavs"]);
                int bin = fav / 1000 * 1000; // Bin width 1000
                if (!bins.ContainsKey(bin)) bins[bin] = 0;
                bins[bin]++;
            }

            chartFavoritesHistogram.Series.Clear();
            var series = chartFavoritesHistogram.Series.Add("Favorites");
            series.ChartType = SeriesChartType.Column;

            foreach (var kvp in bins)
            {
                series.Points.AddXY(kvp.Key + "-" + (kvp.Key + 999), kvp.Value);
            }
        }

        private void LoadGenreDistribution()
        {
            DataTable dt = dbMan.ExecuteReader(
                "SELECT GenreName, COUNT(*) as Count FROM MediaGenre GROUP BY GenreName");

            chartGenreDistribution.Series.Clear();
            var series = chartGenreDistribution.Series.Add("Genres");
            series.ChartType = SeriesChartType.Pie;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(row["GenreName"], row["Count"]);
            }

            series.IsValueShownAsLabel = true;
        }

        private void dataGridViewShows_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
