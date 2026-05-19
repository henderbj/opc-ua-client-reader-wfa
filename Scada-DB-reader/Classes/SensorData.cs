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

        public List<SensorData> findAll(int sensorId)
        {
            List<SensorData> sensorDataList = new List<SensorData>();
            SqlConnection con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM dbo.SensorData WHERE SensorId = @SensorId", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@SensorId", sensorId);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    SensorData sensorData = new SensorData();
                    sensorData.SensorId = Convert.ToInt32(dr["SensorId"]);
                    sensorData.MeasuredValue = Convert.ToSingle(dr["MeasuredValue"]);
                    sensorData.TimeStamp = Convert.ToDateTime(dr["TimeStamp"]);
                    sensorDataList.Add(sensorData);
                }
            }
            return sensorDataList   ;
        }

        public List<SensorData> findAllAfter(int sensorId, DateTime lastTime)
        {
            List<SensorData> sensorDataList = new List<SensorData>();
            SqlConnection con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("SELECT * FROM dbo.SensorData WHERE SensorId = @SensorId AND TimeStamp > @LastTime", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@SensorId", sensorId);
            cmd.Parameters.AddWithValue("@LastTime", lastTime);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    SensorData sensorData = new SensorData();
                    sensorData.SensorId = Convert.ToInt32(dr["SensorId"]);
                    sensorData.MeasuredValue = Convert.ToSingle(dr["MeasuredValue"]);
                    sensorData.TimeStamp = Convert.ToDateTime(dr["TimeStamp"]);
                    sensorDataList.Add(sensorData);
                }
            }
            return sensorDataList   ;
        }
    }
}
