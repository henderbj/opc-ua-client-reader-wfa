using Microsoft.Data.SqlClient;
using System.Xml.Linq;

namespace Scada_opc_client_DB_writer
{
    public static class AppConfig
    {
        public static string ConfigFilePath => "appsettings.xml";

        public static string ConnectionString => "Data Source=deskbook\\SQLEXPRESS;Initial Catalog=SCADA;Integrated Security=True; TrustServerCertificate=True;";

        public static bool Exists() => File.Exists(ConfigFilePath);

        public static (string opcServer, string tagName) Load()
        {
            if (!Exists())
            {
                return ("", "");
            }
            var doc = XDocument.Load(ConfigFilePath);
            var root = doc.Element("Config");
            string opcServer = root.Element("OpcServer")?.Value ?? "";
            string tagName = root.Element("TagName")?.Value ?? "";
            return (opcServer, tagName);
        }
    }
}

