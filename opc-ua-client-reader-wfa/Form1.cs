using Opc.UaFx.Client;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OpcUaWinForms
{
    public class Form1 : Form
    {
        private Label lblTemp;
        private Chart chart1;
        private OpcClient client;
        private string tagName = "ns=2;s=HeaterProcess.Temperature";
        private Timer timer;

        public Form1()
        {
            this.Text = "OPC UA Temperature Reader";
            this.Size = new Size(700, 400);

            // Label
            lblTemp = new Label();
            lblTemp.Location = new Point(10, 320);
            lblTemp.Size = new Size(600, 20);
            lblTemp.Text = "Temperature: ";
            this.Controls.Add(lblTemp);

            // Chart
            chart1 = new Chart();
            chart1.Location = new Point(10, 10);
            chart1.Size = new Size(660, 300);
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = 100;
            chart1.ChartAreas.Add(chartArea);
            Series series = new Series("Temperature");
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            chart1.Series.Add(series);
            this.Controls.Add(chart1);

            // Initialize OPC UA client
            client = new OpcClient("opc.tcp://deskbook:49580");
            client.Connect();

            // Timer for updating every 1 second
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();

            // Cleanup on close
            this.FormClosing += Form1_FormClosing;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                var node = client.ReadNode(tagName);
                var value = Convert.ToDouble(node.Value);
                var timestamp = node.SourceTimestamp;

                lblTemp.Text = $"Temp: {value} °C at {timestamp:HH:mm:ss}";

                Series series = chart1.Series[0];
                series.Points.AddY(value);

                // Keep last 30 points visible
                if (series.Points.Count > 30)
                    series.Points.RemoveAt(0);

                chart1.ResetAutoValues();
            }
            catch (Exception ex)
            {
                lblTemp.Text = $"Error: {ex.Message}";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client?.Disconnect();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1025, 472);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}