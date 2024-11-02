using AiCashGuard.Constants;
using AiCashGuard.Logic.Processor;
using AiCashGuard.Model.Internal.Report;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AiCashGuard.Forms
{
    public partial class Reports : BaseForm
    {
        private Random random = new Random();
        private TransactionNumberModel reportNumber;

        public Reports()
        {
            InitializeComponent();
            BaseTableLayoutPanel.Controls.Add(this.reportPanel, 0, 1); // Row 1 for dashboardPanel
            dateTimePicker1.Value = DateTime.Now.AddMonths(-1);
            dateTimePicker2.Value = DateTime.Now;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            reportNumber = new ReportProcessor().GetTransactionReport(dateTimePicker1.Text, dateTimePicker2.Text);

            if(reportNumber != null)
            {
                TotalT_Label.Text = reportNumber.totalTransactions.ToString();
                TotalAmount_Label.Text = reportNumber.totalAmount.ToString("F2");
                TotalReturnClear_Label.Text = reportNumber.numOfReturnCleared.ToString();
                AvgAmount_Label.Text = reportNumber.averageAmount.ToString("F2");
                TotalClear_Label.Text = reportNumber.numOfCleared.ToString();
                TotalReturn_Label.Text = reportNumber.numOfReturn.ToString();
            }

            GenerateRandomData();
        }

        private void GenerateRandomData()
        {
            // Assuming chart8 is a Chart control added to your form
            chart8.Series.Clear();
            var series = new Series("Monthly Data")
            {
                ChartType = SeriesChartType.Column
            };
            chart8.Series.Add(series);

            // Generate random data for each month
            for (int month = 1; month <= 12; month++)
            {
                int randomValue = random.Next(100, 1000); // Random values between 100 and 1000
                series.Points.AddXY(month, randomValue);
            }

            // Set chart titles and labels

            chart8.ChartAreas[0].AxisX.Title = "Month";
            chart8.ChartAreas[0].AxisY.Title = "Value";


            chart7.Series.Clear();
            var series3 = new Series("Monthly Data")
            {
                ChartType = SeriesChartType.Column
            };
            chart7.Series.Add(series);

            // Generate random data for each month
            for (int month = 1; month <= 12; month++)
            {
                int randomValue = random.Next(100, 1000); // Random values between 100 and 1000
                series.Points.AddXY(month, randomValue);
            }

            // Set chart titles and labels

            chart7.ChartAreas[0].AxisX.Title = "Month";
            chart7.ChartAreas[0].AxisY.Title = "Value";

            chart7.Series.Clear();

            // Create series for Cashed checks
            var cashedSeries = new Series("Cashed Checks")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.Green
            };
            chart7.Series.Add(cashedSeries);

            // Create series for Deposited checks
            var depositedSeries = new Series("Deposited Checks")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.Blue
            };
            chart7.Series.Add(depositedSeries);

            // Generate random data for each month
            for (int month = 1; month <= 12; month++)
            {
                int cashedValue = random.Next(100, 1000); // Random values for cashed checks
                int depositedValue = random.Next(100, 1000); // Random values for deposited checks

                cashedSeries.Points.AddXY(month, cashedValue);
                depositedSeries.Points.AddXY(month, depositedValue);
            }

            chart7.ChartAreas[0].AxisX.Title = "Month";
            chart7.ChartAreas[0].AxisY.Title = "Value";
            chart7.ChartAreas[0].AxisX.Interval = 1; // Set interval for X axis to show each month
            chart7.ChartAreas[0].AxisX.Minimum = 1; // Set minimum for X axis
            chart7.ChartAreas[0].AxisX.Maximum = 12; // Set maximum for X axis



            chart12.Series.Clear();
            var series4 = new Series("Transaction Volume")
            {
                ChartType = SeriesChartType.Pyramid
            };
            chart12.Series.Add(series);

            // Array for month names
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            // Generate random transaction volumes for each month
            for (int month = 0; month < 12; month++)
            {
                int randomVolume = random.Next(1000, 5000); // Random values between 1000 and 5000
                series.Points.AddXY(months[month], randomVolume);
            }

            // Set chart titles and labels
            chart12.Titles.Add("Monthly Transaction Volume");
            chart12.ChartAreas[0].AxisX.Title = "Month";
            chart12.ChartAreas[0].AxisY.Title = "Volume";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Filter_Btn_Click(object sender, EventArgs e)
        {
            Reports_Load(sender, e);
        }

		private void panel1_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void reportBackBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard dashboard = new Dashboard();
			dashboard.WindowState = this.WindowState;
			dashboard.Show();
		}

		private void panel9_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{
			this.Hide();
			Dashboard dashboard = new Dashboard();
            dashboard.WindowState = this.WindowState;
			dashboard.Show();
		}

		private void label28_Click(object sender, EventArgs e)
		{

		}
	}
}
