using Scada_DB_reader.Classes;

namespace Scada_DB_reader
{
    public partial class ConfigForm: Form
    {
        //Functions that handle the ProcessVariable controls in the ConfigForm

        private List<ProcessVariable> _processVariables = new List<ProcessVariable>();
        private int _processVariableSelected = 0;

        // ProcessVariable Methods ********************************************************

        /// <summary>
        /// Populates the ProcessVariable controls in ConfigForm
        /// </summary>
        //private void PopulateProcessVariable()
        //{

        //    _processVariables = LoadProcessVariables();

        //    cmbProcessVariable.DataSource = _processVariables;
        //    cmbProcessVariable.DisplayMember = "VariableName";
        //    cmbProcessVariable.ValueMember = "VariableId";
        //    if(_processVariables.Count > 0)
        //    { 
        //        cmbProcessVariable.SelectedIndex = _processVariableSelected;
        //        fillProcessVariableDetails();
        //    }
        //}

        /// <summary>
        /// Populates the process variable details in the ConfigForm with the selected ProcessVariable
        /// </summary>
        private void fillProcessVariableDetails(ProcessVariable processVariable)
        {
            txtVariableName.Text = processVariable.VariableName;
            txtEngineeringUnit.Text = processVariable.EngineeringUnit;
            txtVariableDescription.Text = processVariable.VariableDescription;
        }

        /// <summary>
        /// Load ProcessVariables from the DB
        /// </summary>
        /// <returns>List of ProcessVariable</returns>
        //private List<ProcessVariable> LoadProcessVariables()
        //{
        //    ProcessVariable processVariable = new ProcessVariable();
        //    return processVariable.GetAllVariables();
        //}

        //private void cmbProcessVariable_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    _processVariableSelected = cmbProcessVariable.SelectedIndex;
        //    // Fill process variable details
        //    fillProcessVariableDetails();
        //}
    }
}
