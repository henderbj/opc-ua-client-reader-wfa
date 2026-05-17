using Scada_opc_client_DB_writer.Classes;

namespace Scada_opc_client_DB_writer
{
    public partial class ConfigForm: Form
    {
        //Functions that handle the Location controls in the ConfigForm

        private List<ProcessUnit> _processUnits = new List<ProcessUnit>();
        private int _processUnitSelected = 0;

        // ProcessUnit Methods ********************************************************

        /// <summary>
        /// Populates the ProcessUnit controls in ConfigForm
        /// </summary>
        private void PopulateProcessUnit()
        {

            _processUnits = LoadProcessUnits();

            cmbProcessUnit.DataSource = _processUnits;
            cmbProcessUnit.DisplayMember = "ProcessName";
            cmbProcessUnit.ValueMember = "ProcessId";
            cmbProcessUnit.SelectedIndex = _processUnitSelected;
            fillProcessUnitDetails();
        }

        /// <summary>
        /// Populates the process unit details in the ConfigForm with the selected ProcessUnit
        /// </summary>
        private void fillProcessUnitDetails()
        {
            txtProcessName.Text = _processUnits[_processUnitSelected].ProcessName;
            txtProcessType.Text = _processUnits[_processUnitSelected].ProcessType;
            txtProcessDescription.Text = _processUnits[_processUnitSelected].ProcessDescription;
        }

        /// <summary>
        /// Load Locations from the DB
        /// </summary>
        /// <returns>List of ProcessUnit</returns>
        private List<ProcessUnit> LoadProcessUnits()
        {
            ProcessUnit processUnit = new ProcessUnit();
            return processUnit.GetAllProcessUnits();
        }

        private void cmbProcessUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            _processUnitSelected = cmbProcessUnit.SelectedIndex;
            // Fill process unit details
            fillProcessUnitDetails();
        }
    }
}
