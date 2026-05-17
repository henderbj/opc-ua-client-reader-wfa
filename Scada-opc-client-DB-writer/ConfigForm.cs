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
    }
}
