using System;
using System.Windows.Forms;

namespace OpcUaWinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Enable visual styles for WinForms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the main form
            Application.Run(new Form1());
        }
    }
}