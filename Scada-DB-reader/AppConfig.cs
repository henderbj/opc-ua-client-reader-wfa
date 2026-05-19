using Microsoft.Data.SqlClient;
using System.Xml.Serialization;
using Scada_DB_reader.Classes;

namespace Scada_DB_reader
{
    public static class AppConfig
    {
        public static string ConfigFilePath => "DB_reader_appsettings.xml";

        public static string ConnectionString => "Data Source=deskbook\\SQLEXPRESS;Initial Catalog=SCADA;Integrated Security=True; TrustServerCertificate=True;";

        public static bool Exists() => File.Exists(ConfigFilePath);

        public static ConfigData LoadConfig()
        {
            if (!Exists())
            {
                return null;
            }

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ConfigData));
                using (FileStream fs = new FileStream(ConfigFilePath, FileMode.Open))
                {
                    return (ConfigData)serializer.Deserialize(fs);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void SaveConfig(ConfigData data)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ConfigData));
                using (FileStream fs = new FileStream(ConfigFilePath, FileMode.Create))
                {
                    serializer.Serialize(fs, data);
                }
            }
            catch (Exception)
            {
                // In a real application, we might want to log this error.
            }
        }
    }
}

