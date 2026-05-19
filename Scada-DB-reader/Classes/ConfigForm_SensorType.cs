using Scada_DB_reader.Classes;

namespace Scada_DB_reader
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
        //private void PopulateSensorType()
        //{

        //    _sensorTypes = LoadSensorTypes();

        //    cmbSensorType.DataSource = _sensorTypes;
        //    cmbSensorType.DisplayMember = "SensorTypeName";
        //    cmbSensorType.ValueMember = "SensorTypeId";
        //    if(_sensorTypes.Count > 0)
        //    { 
        //        cmbSensorType.SelectedIndex = _sensorTypeSelected;
        //        fillSensorTypeDetails();
        //    }
        //}

        /// <summary>
        /// Populates the sensor type details in the ConfigForm with the selected SensorType
        /// </summary>
        private void fillSensorTypeDetails(SensorType sensorType)
        {
            txtSensorTypeName.Text = sensorType.SensorTypeName;
            txtSensorTypeDescription.Text = sensorType.SensorTypeDescription;
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
    }
}
