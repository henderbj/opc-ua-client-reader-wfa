namespace Scada_opc_client_DB_writer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            if (AppConfig.Exists())
            {
                var (opcServer, tagName) = AppConfig.Load();
                Application.Run(new Form1(opcServer, tagName));
            }
            else
            {
                Application.Run(new ConfigForm());
            }
        }
    }
}