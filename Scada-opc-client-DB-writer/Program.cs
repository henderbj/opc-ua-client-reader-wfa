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
            var config = AppConfig.LoadConfig();
            if (config != null)
            {
                Application.Run(new Form1(config));
            }
            else
            {
                Application.Run(new ConfigForm());
                config = AppConfig.LoadConfig();
                Application.Run(new Form1(config));
            }
        }
    }
}