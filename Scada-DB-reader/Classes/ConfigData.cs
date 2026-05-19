using System;

namespace Scada_DB_reader.Classes
{
    [Serializable]
    public class ConfigData
    {
        public string opcServer { get; set; }
        public string tagName { get; set; }
        public Location location { get; set; }
        public ProcessUnit processUnit { get; set; }
        public ProcessVariable processVariable { get; set; }
        public SensorType sensorType { get; set; }
        public Sensor sensor { get; set; }
    }
}
