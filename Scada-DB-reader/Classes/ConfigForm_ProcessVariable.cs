using Scada_DB_reader.Classes;

namespace Scada_DB_reader
{
    public partial class ConfigForm: Form
    {
        //Functions that handle the ProcessVariable controls in the ConfigForm

        /// <summary>
        /// Populates the process variable details in the ConfigForm with the selected ProcessVariable
        /// </summary>
        private void fillProcessVariableDetails(ProcessVariable processVariable)
        {
            txtVariableName.Text = processVariable.VariableName;
            txtEngineeringUnit.Text = processVariable.EngineeringUnit;
            txtVariableDescription.Text = processVariable.VariableDescription;
        }
    }
}
