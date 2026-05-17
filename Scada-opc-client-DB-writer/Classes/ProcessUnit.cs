using Microsoft.Data.SqlClient;
using Scada_opc_client_DB_writer;

namespace Scada_opc_client_DB_writer.Classes
{
    internal class ProcessUnit
    {
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public string ProcessType { get; set; }
        public string? ProcessDescription { get; set; }
        public int LocationId { get; set; }

        internal string connectionString = AppConfig.ConnectionString;

        public List<ProcessUnit> GetAllProcessUnits()
        {
            List<ProcessUnit> processUnitList = new List<ProcessUnit>();
            SqlConnection con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT ProcessId, ProcessName, ProcessType, ProcessDescription, LocationId FROM dbo.ProcessUnit", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    ProcessUnit processUnit = new ProcessUnit();
                    processUnit.ProcessId = Convert.ToInt32(dr["ProcessId"]);
                    processUnit.ProcessName = dr["ProcessName"].ToString();
                    processUnit.ProcessType = dr["ProcessType"].ToString();
                    processUnit.ProcessDescription = dr["ProcessDescription"].ToString();
                    processUnit.LocationId = Convert.ToInt32(dr["LocationId"]);
                    processUnitList.Add(processUnit);
                }
            }
            return processUnitList;
        }
    }
}
