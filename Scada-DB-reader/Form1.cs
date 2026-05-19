using Microsoft.Extensions.Logging;
using Scada_DB_reader.Classes;

namespace Scada_DB_reader
{
    public partial class Form1 : Form
    {
        // Create a logger to store the data for plotting
        private readonly ScottPlot.Plottables.DataLogger _logger;
        private Label _lblTemp;
        private DateTime _lastTime = DateTime.MinValue;
        private System.Windows.Forms.Timer timer;
        int sensorId;

        public Form1(ConfigData config)
        {
            InitializeComponent();
            Form_LoadSensorDetails(config);
            sensorId = config.sensor.SensorId;

            // create one logger and add them to the plot
            _logger = formsPlot1.Plot.Add.DataLogger();
            //Set axis labels
            formsPlot1.Plot.YLabel(config.processVariable.VariableName);
            formsPlot1.Plot.XLabel("Sample number");
            formsPlot1.Refresh();

            Text = "Scada DB Reader";
            Size = new Size(1024, 768);

            // Label
            _lblTemp = new Label
            {
                Location = new Point(10, 600),
                Size = new Size(600, 20),
                Text = "Form loaded"
            };
            Controls.Add(_lblTemp);
            List<SensorData> sensorDataList = new SensorData().findAll(config.sensor.SensorId);
            AddDataToPlot(sensorDataList); // Add the historical data points to the plot

            // Timer for updating every 1 second
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += timer1_Tick; // Attach event handler for timer tick
            timer.Start(); // Start the timer
        }

        private void AddDataToPlot(List<SensorData> sensorDataList)
        {
            _lastTime = sensorDataList.Max(data => data.TimeStamp); // Get the latest timestamp from the data
            double[] yValues = sensorDataList.Select(data => (double)data.MeasuredValue).ToArray(); // Convert MeasuredValue to double for plotting
            _logger.Add(yValues); // Add all the historical values to the logger at once
        }

        private void Form_LoadSensorDetails(ConfigData config)
        {
            txtLocation.Text = config.location.LocationName;
            txtProcessUnit.Text = config.processUnit.ProcessName;
            txtProcessVariable.Text = config.processVariable.VariableName;
            txtSensor.Text = config.sensor.SensorName;
            txtSensorType.Text = config.sensorType.SensorTypeName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Fetch new data from the database for the specific sensor
            List<SensorData> sensorDataList = new SensorData().findAllAfter(sensorId, _lastTime);
            if (sensorDataList.Count > 0)
            {
                AddDataToPlot(sensorDataList); // Add the new data points to the plot and update the last timestamp
                _lblTemp.Text = $"Last update: {DateTime.Now}, Latest value: {sensorDataList.Last().MeasuredValue:F2} at {sensorDataList.Last().TimeStamp}";
            }
            formsPlot1.Refresh();
        }
    }
}
