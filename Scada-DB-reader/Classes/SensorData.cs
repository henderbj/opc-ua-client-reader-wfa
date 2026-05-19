using Microsoft.Data.SqlClient;
using System.Data;

namespace Scada_DB_reader.Classes
{
    public class SensorData
    {
        public long DataId { get; set; }
        public long SensorId { get; set; }
        public float MeasuredValue { get; set; }
        public DateTime TimeStamp { get; set; }

        internal string connectionString = AppConfig.ConnectionString;

        public SensorData Insert(int sensorId, float measuredValue, DateTime timeStamp)
        {
            SensorData sensorData = new SensorData();
            SqlConnection con = new SqlConnection(connectionString);
            sensorData.SensorId = sensorId;
            sensorData.MeasuredValue = measuredValue;
            sensorData.TimeStamp = timeStamp;
            var cmd = new SqlCommand("INSERT INTO dbo.SensorData (SensorId, MeasuredValue, TimeStamp) VALUES (@SensorId, @MeasuredValue, @TimeStamp)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@SensorId", sensorData.SensorId);
            cmd.Parameters.AddWithValue("@MeasuredValue", sensorData.MeasuredValue);
            cmd.Parameters.AddWithValue("@TimeStamp", sensorData.TimeStamp);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    sensorData.SensorId = Convert.ToInt32(dr["SensorId"]);
                    sensorData.MeasuredValue = Convert.ToSingle(dr["MeasuredValue"]);
                    sensorData.TimeStamp = Convert.ToDateTime(dr["TimeStamp"]);
                }
            }
            return sensorData;
        }
    }
}
