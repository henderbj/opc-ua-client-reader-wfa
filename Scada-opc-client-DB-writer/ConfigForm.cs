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
        }
    }
}
