using Microsoft.Data.SqlClient;
using System.Data;

namespace Scada_opc_client_DB_writer.Classes
{
    public class Sensor
    {
        public int SensorId { get; set; }
        public int VariableId { get; set; }
        public int SensorTypeId { get; set; }
        public string SensorName { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public DateTime InstallationDate { get; set; }

        internal string connectionString = AppConfig.ConnectionString;

        public List<Sensor> GetAllSensors()
        {
            List<Sensor> sensorList = new List<Sensor>();
            SqlConnection con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT SensorID, VariableID, SensorTypeID, SensorName, Manufacturer, Model, SerialNumber, InstallationDate FROM Sensor", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Sensor sensor = new Sensor();
                    sensor.SensorId = Convert.ToInt32(dr["SensorId"]);
                    sensor.VariableId = Convert.ToInt32(dr["VariableId"]);
                    sensor.SensorTypeId = Convert.ToInt32(dr["SensorTypeId"]);
                    sensor.SensorName = dr["SensorName"].ToString();
                    sensor.Manufacturer = dr["Manufacturer"].ToString();
                    sensor.Model = dr["Model"].ToString();
                    sensor.SerialNumber = dr["SerialNumber"].ToString();
                    sensor.InstallationDate = Convert.ToDateTime(dr["InstallationDate"]);
                    sensorList.Add(sensor);
                }
            }
            return sensorList;
        }

        public Sensor FindOrCreate(int VariableId, int SensorTypeId, string SensorName, string Manufacturer, string Model, string SerialNumber, DateTime InstallationDate)
        {
            Sensor sensor = new Sensor();
            SqlConnection con = new SqlConnection(connectionString);
            SensorName = SensorName.Trim();
            Manufacturer = Manufacturer.Trim();
            Model = Model.Trim();
            SerialNumber = SerialNumber.Trim();
            var cmd = new SqlCommand("usp_FindOrCreateSensor", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@VariableId", VariableId);
            cmd.Parameters.AddWithValue("@SensorTypeId", SensorTypeId);
            cmd.Parameters.AddWithValue("@SensorName", SensorName);
            cmd.Parameters.AddWithValue("@Manufacturer", Manufacturer);
            cmd.Parameters.AddWithValue("@Model", Model);
            cmd.Parameters.AddWithValue("@SerialNumber", SerialNumber);
            cmd.Parameters.AddWithValue("@InstallationDate", InstallationDate);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    sensor.SensorId = Convert.ToInt32(dr["SensorId"]);
                    sensor.VariableId = Convert.ToInt32(dr["VariableId"]);
                    sensor.SensorTypeId = Convert.ToInt32(dr["SensorTypeId"]);
                    sensor.SensorName = dr["SensorName"].ToString();
                    sensor.Manufacturer = dr["Manufacturer"].ToString();
                    sensor.Model = dr["Model"].ToString();
                    sensor.SerialNumber = dr["SerialNumber"].ToString();
                    sensor.InstallationDate = Convert.ToDateTime(dr["InstallationDate"]);
                }
            }
            return sensor;
        }
    }
}
