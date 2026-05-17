using Microsoft.Data.SqlClient;
using Scada_opc_client_DB_writer;

namespace Scada_opc_client_DB_writer.Classes
{
    internal class ProcessVariable
    {
        public int VariableId { get; set; }
        public int ProcessId { get; set; }
        public string VariableName { get; set; }
        public string EngineeringUnit { get; set; }
        public string? VariableDescription { get; set; }

        internal string connectionString = AppConfig.ConnectionString;

        public List<ProcessVariable> GetAllVariables()
        {
            List<ProcessVariable> processVariableList = new List<ProcessVariable>();
            SqlConnection con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT VariableId, ProcessId, VariableName, EngineeringUnit, VariableDescription FROM dbo.ProcessVariable", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    ProcessVariable processVariable = new ProcessVariable();
                    processVariable.VariableId = Convert.ToInt32(dr["VariableId"]);
                    processVariable.ProcessId = Convert.ToInt32(dr["ProcessId"]);
                    processVariable.VariableName = dr["VariableName"].ToString();
                    processVariable.EngineeringUnit = dr["EngineeringUnit"].ToString();
                    processVariable.VariableDescription = dr["VariableDescription"].ToString();
                    processVariableList.Add(processVariable);
                }
            }
            return processVariableList;
        }
    }
}
