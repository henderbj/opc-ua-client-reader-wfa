using Scada_opc_client_DB_writer.Classes;

namespace Scada_opc_client_DB_writer
{
    public partial class ConfigForm: Form
    {
        //Functions that handle the SensorType controls in the ConfigForm

        private List<Sensor> _sensors = new List<Sensor>();
        private int _sensorSelected = 0;

        // Sensor Methods ********************************************************

        /// <summary>
        /// Populates the Sensor controls in ConfigForm
        /// </summary>
        private void PopulateSensor()
        {

            _sensors = LoadSensors();

            cmbSensor.DataSource = _sensors;
            cmbSensor.DisplayMember = "SensorName";
            cmbSensor.ValueMember = "SensorId";
            if(_sensors.Count > 0)
            { 
                cmbSensor.SelectedIndex = _sensorSelected;
                fillSensorDetails();
            }
        }

        /// <summary>
        /// Populates the sensor details in the ConfigForm with the selected Sensor
        /// </summary>
        private void fillSensorDetails()
        {
            txtSensorName.Text = _sensors[_sensorSelected].SensorName;
            txtSensorManufacturer.Text = _sensors[_sensorSelected].Manufacturer;
            txtSensorModel.Text = _sensors[_sensorSelected].Model;
            txtSensorSerial.Text = _sensors[_sensorSelected].SerialNumber;
            txtSensorInstallDate.Text = _sensors[_sensorSelected].InstallationDate.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// Load ProcessVariables from the DB
        /// </summary>
        /// <returns>List of ProcessVariable</returns>
        private List<Sensor> LoadSensors()
        {
            Sensor sensor = new Sensor();
            return sensor.GetAllSensors();
        }

        private void cmbSensor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _sensorSelected = cmbSensor.SelectedIndex;
            // Fill sensor details
            fillSensorDetails();
        }
    }
}
