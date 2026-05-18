using Microsoft.Data.SqlClient;
using Scada_opc_client_DB_writer;
using System.Data;

namespace Scada_opc_client_DB_writer.Classes
{
    internal class SensorType
    {
        public int SensorTypeId { get; set; }
        public string SensorTypeName { get; set; }
        public string SensorTypeDescription { get; set; }

        internal string connectionString = AppConfig.ConnectionString;

        public List<SensorType> GetAllSensorTypes()
        {
            List<SensorType> sensorTypeList = new List<SensorType>();
            SqlConnection con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT SensorTypeID, SensorTypeName, SensorTypeDescription FROM dbo.SensorType", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    SensorType sensorType = new SensorType();
                    sensorType.SensorTypeId = Convert.ToInt32(dr["SensorTypeId"]);
                    sensorType.SensorTypeName = dr["SensorTypeName"].ToString();
                    sensorType.SensorTypeDescription = dr["SensorTypeDescription"].ToString();
                    sensorTypeList.Add(sensorType);
                }
            }
            return sensorTypeList;
        }

        public SensorType FindOrCreate(string SensorTypeName, string SensorTypeDescription)
        {
            SensorType sensorType = new SensorType();
            SqlConnection con = new SqlConnection(connectionString);
            SensorTypeName = SensorTypeName.Trim();
            SensorTypeDescription = SensorTypeDescription.Trim();
            var cmd = new SqlCommand("usp_FindOrCreateSensorType", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SensorTypeName", SensorTypeName);
            cmd.Parameters.AddWithValue("@SensorTypeDescription", SensorTypeDescription);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    sensorType.SensorTypeId = Convert.ToInt32(dr["SensorTypeId"]);
                    sensorType.SensorTypeName = dr["SensorTypeName"].ToString();
                    sensorType.SensorTypeDescription = dr["SensorTypeDescription"].ToString();
                }
            }
            return sensorType;
        }
    }
}
