using Opc.UaFx.Client;
using Scada_opc_client_DB_writer.Classes;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Scada_opc_client_DB_writer
{
    public partial class Form1 : Form
    {
        // Create a logger to store the data for plotting
        readonly ScottPlot.Plottables.DataLogger Logger;

        private Label lblTemp;
        private OpcClient opcClient;
        private string tagName;
        private string opcServer;
        private System.Windows.Forms.Timer timer;
        private int sensorId;

        // Queue for database writes to ensure they are processed in order and without blocking the UI thread
        private readonly Channel<SensorData> _dbQueue = Channel.CreateUnbounded<SensorData>();
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();

        public Form1(ConfigData config)
        {
            if (config is null)
            {
                return;
            }

            InitializeComponent();

            sensorId = config.sensor.SensorId;
            tagName = string.IsNullOrEmpty(config.tagName) ? "" : config.tagName;
            opcServer = string.IsNullOrEmpty(config.opcServer) ? "" : config.opcServer;

            // create one logger and add them to the plot
            Logger = formsPlot1.Plot.Add.DataLogger();
            //Set axis labels
            formsPlot1.Plot.YLabel(config.processVariable.VariableName);
            formsPlot1.Plot.XLabel("Sample number");
            formsPlot1.Refresh();

            Text = "OPC UA Sensor Reader and DB Writer";
            Size = new Size(1024, 768);

            // Label
            lblTemp = new Label
            {
                Location = new Point(10, 600),
                Size = new Size(600, 20),
                Text = "Press Start to begin data acquisition"
            };
            Controls.Add(lblTemp);

            // Set textbox values as provided by config to inform about the current configuration
            txtTagName.Text = tagName;
            txtOpcServer.Text = opcServer;
            txtLocation.Text = string.IsNullOrEmpty(config.location.LocationName) ? "" : config.location.LocationName;
            txtProcessUnit.Text = string.IsNullOrEmpty(config.processUnit.ProcessName) ? "" : config.processUnit.ProcessName;
            txtProcessVariable.Text = string.IsNullOrEmpty(config.processVariable.VariableName) ? "" : config.processVariable.VariableName;
            txtSensor.Text = string.IsNullOrEmpty(config.sensor.SensorName) ? "" : config.sensor.SensorName;
            txtSensorType.Text = string.IsNullOrEmpty(config.sensorType.SensorTypeName) ? "" : config.sensorType.SensorTypeName;


            // Initialize OPC UA client
            opcClient = new OpcClient(opcServer);
            opcClient.Connect();

            // Timer for updating every 1 second
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick; // Attach event handler for timer tick

            // Start the background worker for DB writes
            _ = ProcessDbQueueAsync(_cts.Token);

            // Cleanup on close
            FormClosing += Form1_FormClosing;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                var node = opcClient.ReadNode(tagName);
                var processValue = Convert.ToDouble(node.Value);
                var timestamp = node.SourceTimestamp;

                lblTemp.Text = $"Temp: {processValue:F2} °C at {timestamp:HH:mm:ss}";

                //Plot Data
                Logger.Add(processValue);
                formsPlot1.Refresh();

                // Write to DB asynchronously
                var data = new SensorData
                {
                    SensorId = this.sensorId,
                    MeasuredValue = (float)processValue,
                    TimeStamp = Convert.ToDateTime(timestamp)
                };
                _dbQueue.Writer.TryWrite(data);
            }
            catch (Exception ex)
            {
                lblTemp.Text = $"Error: {ex.Message}";
            }
        }

        private async Task ProcessDbQueueAsync(CancellationToken ct)
        {
            try
            {
                await foreach (var data in _dbQueue.Reader.ReadAllAsync(ct))
                {
                    try
                    {
                        // Use a new instance of SensorData to perform the insert
                        new SensorData().Insert((int)data.SensorId, data.MeasuredValue, data.TimeStamp);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Database insert error: {ex.Message}");
                    }
                }
            }
            catch (OperationCanceledException) { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cts.Cancel();
            opcClient?.Disconnect();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
