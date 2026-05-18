using Scada_opc_client_DB_writer.Classes;

namespace Scada_opc_client_DB_writer
{
    public partial class ConfigForm: Form
    {
        //Functions that handle the SensorType controls in the ConfigForm

        private List<SensorType> _sensorTypes = new List<SensorType>();
        private int _sensorTypeSelected = 0;

        // SensorType Methods ********************************************************

        /// <summary>
        /// Populates the SensorType controls in ConfigForm
        /// </summary>
        private void PopulateSensorType()
        {

            _sensorTypes = LoadSensorTypes();

            cmbSensorType.DataSource = _sensorTypes;
            cmbSensorType.DisplayMember = "SensorTypeName";
            cmbSensorType.ValueMember = "SensorTypeId";
            if(_sensorTypes.Count > 0)
            { 
                cmbSensorType.SelectedIndex = _sensorTypeSelected;
                fillSensorTypeDetails();
            }
        }

        /// <summary>
        /// Populates the sensor type details in the ConfigForm with the selected SensorType
        /// </summary>
        private void fillSensorTypeDetails()
        {
            txtSensorTypeName.Text = _sensorTypes[_sensorTypeSelected].SensorTypeName;
            txtSensorTypeDescription.Text = _sensorTypes[_sensorTypeSelected].SensorTypeDescription;
        }

        /// <summary>
        /// Load ProcessVariables from the DB
        /// </summary>
        /// <returns>List of ProcessVariable</returns>
        private List<SensorType> LoadSensorTypes()
        {
            SensorType sensorType = new SensorType();
            return sensorType.GetAllSensorTypes();
        }

        private void cmbSensorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _sensorTypeSelected = cmbSensorType.SelectedIndex;
            // Fill sensor type details
            fillSensorTypeDetails();
        }
    }
}
