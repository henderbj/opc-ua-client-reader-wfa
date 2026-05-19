using Scada_DB_reader.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Scada_DB_reader
{
    public partial class ConfigForm : Form
    {
        private Sensor _sensor;
        private SensorType _sensorType;
        private ProcessVariable _processVariable;
        private ProcessUnit _processUnit;
        private Location _location;

        public ConfigForm()
        {
            InitializeComponent();
            ConfigForm_Load();
        }

        private void ConfigForm_Load()
        {
            PopulateSensor();
            fillAllSensorDetails();
        }

        private void fillAllSensorDetails()
        {
            _sensor = getSelectedSensor();
            _sensorType = new SensorType().Find(_sensor.SensorTypeId);
            fillSensorTypeDetails(_sensorType);
            _processVariable = new ProcessVariable().Find(_sensor.VariableId);
            fillProcessVariableDetails(_processVariable);
            _processUnit = new ProcessUnit().Find(_processVariable.ProcessId);
            fillProcessUnitDetails(_processUnit);
            _location = new Location().Find(_processUnit.LocationId);
            fillLocationDetails(_location);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConfigData configData = new ConfigData
            {
                location = _location,
                processUnit = _processUnit,
                processVariable = _processVariable,
                sensorType = _sensorType,
                sensor = _sensor
            };

            AppConfig.SaveConfig(configData);
            this.Close();   // Close the form after saving
        }
    }
}
