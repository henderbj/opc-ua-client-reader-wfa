using Opc.UaFx.Client;
using Scada_opc_client_DB_writer.Classes;
//using System.Timers;

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
        public Form1() : this(null) { }

        public Form1(ConfigData config)
        {
            InitializeComponent();

            tagName = string.IsNullOrEmpty(config.tagName) ? "" : config.tagName;
            opcServer = string.IsNullOrEmpty(config.opcServer) ? "" : config.opcServer;

            // create one logger and add them to the plot
            Logger = formsPlot1.Plot.Add.DataLogger();
            //Set axis labels
            formsPlot1.Plot.YLabel("Process Value");
            formsPlot1.Plot.XLabel("Sample number");
            formsPlot1.Refresh();

            Text = "OPC UA Temperature Reader";
            Size = new Size(700, 400);

            // Label
            lblTemp = new Label
            {
                Location = new Point(10, 400),
                Size = new Size(600, 20),
                Text = "Temperature: "
            };
            Controls.Add(lblTemp);

            // Set textbox values if provided
            txtTagName.Text = tagName;
            txtOpcServer.Text = opcServer;

            // Initialize OPC UA client
            opcClient = new OpcClient(opcServer);
            opcClient.Connect();

            // Timer for updating every 1 second
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();

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

                lblTemp.Text = $"Temp: {processValue} °C at {timestamp:HH:mm:ss}";

                //Plot Data
                Logger.Add(processValue);
                formsPlot1.Refresh();
            }
            catch (Exception ex)
            {
                lblTemp.Text = $"Error: {ex.Message}";
            }
        }

        private OpcClient opcConnect(string server)
        {
            OpcClient opcClient;
            try
            {
                opcClient = new OpcClient(server);
                opcClient.Connect();
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Failed to connect to OPC UA server: {ex.Message}");
                opcClient = null;
            }
            return opcClient;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            opcClient?.Disconnect();
        }

        private void txtOpcServer_Leave(object sender, EventArgs e)
        {
            opcServer = txtOpcServer.Text;

            // Stop timer while reconnecting
            timer?.Stop();

            // Disconnect and dispose old client
            if (opcClient != null)
            {
                try { opcClient.Disconnect(); } catch { }
                opcClient.Dispose();
                opcClient = null;
            }

            // Try to connect to new server
            if (!string.IsNullOrWhiteSpace(opcServer))
            {
                opcClient = opcConnect(opcServer);
                if (opcClient != null && opcClient.State == OpcClientState.Connected)
                {
                    lblTemp.Text = $"Connected to {opcServer}";
                    timer?.Start();
                }
                else
                {
                    lblTemp.Text = $"Failed to connect to {opcServer}";
                }
            }
            else
            {
                lblTemp.Text = "Please enter a valid OPC UA server address.";
            }

            // To clear the Logger:
            Logger.Clear();
            formsPlot1.Refresh();
        }
        private void txtTagName_Leave(object sender, EventArgs e)
        {
            tagName = txtTagName.Text;
            lblTemp.Text = "The new tagName is " + tagName;

            // To clear the Logger:
            Logger.Clear();
            formsPlot1.Refresh();
        }
    }
}
