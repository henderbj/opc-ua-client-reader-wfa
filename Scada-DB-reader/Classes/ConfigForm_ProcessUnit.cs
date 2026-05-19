using Scada_DB_reader.Classes;

namespace Scada_DB_reader
{
    public partial class ConfigForm: Form
    {
        //Functions that handle the Location controls in the ConfigForm

        /// <summary>
        /// Populates the process unit details in the ConfigForm with the selected ProcessUnit
        /// </summary>
        private void fillProcessUnitDetails(ProcessUnit processUnit)
        {
            txtProcessName.Text = processUnit.ProcessName;
            txtProcessType.Text = processUnit.ProcessType;
            txtProcessDescription.Text = processUnit.ProcessDescription;
        }
    }
}
