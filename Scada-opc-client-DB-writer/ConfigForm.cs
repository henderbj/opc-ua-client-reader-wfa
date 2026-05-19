using Scada_opc_client_DB_writer.Classes;

namespace Scada_opc_client_DB_writer
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
            ConfigForm_Load();
        }

        /// <summary>
        /// Load existing configuration and populate controls in ConfigForm
        /// </summary>
        private void ConfigForm_Load()
        {
            PopulateLocation();
            PopulateProcessUnit();
            PopulateProcessVariable();
            PopulateSensorType();
            PopulateSensor();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location = location.FindOrCreate(txtLocationName.Text, txtBuilding.Text, Convert.ToInt32(txtFloor.Text), txtRoom.Text);
            ProcessUnit processUnit = new ProcessUnit();
            processUnit = processUnit.FindOrCreate(txtProcessName.Text, txtProcessType.Text, txtProcessDescription.Text, location.LocationId);
            ProcessVariable processVariable = new ProcessVariable();
            processVariable = processVariable.FindOrCreate(processUnit.ProcessId, txtVariableName.Text, txtEngineeringUnit.Text, txtVariableDescription.Text);
            SensorType sensorType = new SensorType();
            sensorType = sensorType.FindOrCreate(txtSensorTypeName.Text, txtSensorTypeDescription.Text);
            Sensor sensor = new Sensor();
            sensor = sensor.FindOrCreate(processVariable.VariableId, sensorType.SensorTypeId, txtSensorName.Text, txtSensorManufacturer.Text, txtSensorModel.Text, txtSensorSerial.Text, Convert.ToDateTime(txtSensorInstallDate.Text));

            ConfigData configData = new ConfigData
            {
                opcServer = cfgTxtOpcServer.Text,
                tagName = cfgTxtTagName.Text,
                location = location,
                processUnit = processUnit,
                processVariable = processVariable,
                sensorType = sensorType,
                sensor = sensor
            };

            AppConfig.SaveConfig(configData);
            this.Close();
        }
    }
}
