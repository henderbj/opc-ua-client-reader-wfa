using Microsoft.Data.SqlClient;
using System.Data;

namespace Scada_DB_reader.Classes
{
    public class ProcessUnit
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

        public ProcessUnit FindOrCreate(string ProcessName, string ProcessType, string? ProcessDescription, int LocationId)
        {
            ProcessUnit processUnit = new ProcessUnit();
            SqlConnection con = new SqlConnection(connectionString);
            ProcessName = ProcessName.Trim();
            ProcessType = ProcessType.Trim();
            ProcessDescription = ProcessDescription?.Trim();
            var cmd = new SqlCommand("usp_FindOrCreateProcessUnit", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProcessName", ProcessName);
            cmd.Parameters.AddWithValue("@ProcessType", ProcessType);
            cmd.Parameters.AddWithValue("@ProcessDescription", ProcessDescription ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@LocationId", LocationId);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    processUnit.ProcessId = Convert.ToInt32(dr["ProcessId"]);
                    processUnit.ProcessName = dr["ProcessName"].ToString();
                    processUnit.ProcessType = dr["ProcessType"].ToString();
                    processUnit.ProcessDescription = dr["ProcessDescription"].ToString();
                    processUnit.LocationId = Convert.ToInt32(dr["LocationId"]);
                }
            }
            return processUnit;
        }
    }
}