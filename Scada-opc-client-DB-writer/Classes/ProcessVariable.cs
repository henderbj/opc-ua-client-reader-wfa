using Microsoft.Data.SqlClient;
using System.Data;

namespace Scada_opc_client_DB_writer.Classes
{
    public class ProcessVariable
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

        public ProcessVariable FindOrCreate(int ProcessId, string VariableName, string EngineeringUnit, string? VariableDescription)
        {
            ProcessVariable processVariable = new ProcessVariable();
            SqlConnection con = new SqlConnection(connectionString);
            VariableName = VariableName.Trim();
            EngineeringUnit = EngineeringUnit.Trim();
            VariableDescription = VariableDescription?.Trim();
            var cmd = new SqlCommand("usp_FindOrCreateProcessVariable", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProcessId", ProcessId);
            cmd.Parameters.AddWithValue("@VariableName", VariableName);
            cmd.Parameters.AddWithValue("@EngineeringUnit", EngineeringUnit);
            cmd.Parameters.AddWithValue("@VariableDescription", VariableDescription ?? (object)DBNull.Value);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    processVariable.VariableId = Convert.ToInt32(dr["VariableId"]);
                    processVariable.ProcessId = Convert.ToInt32(dr["ProcessId"]);
                    processVariable.VariableName = dr["VariableName"].ToString();
                    processVariable.EngineeringUnit = dr["EngineeringUnit"].ToString();
                    processVariable.VariableDescription = dr["VariableDescription"].ToString();
                }
            }
            return processVariable;
        }
    }
}
