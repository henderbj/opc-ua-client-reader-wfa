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
        }
    }
}
