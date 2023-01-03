using SE1626_Group6_A2.Models;

namespace SE1626_Group6_A2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            User user = new User();
            Application.Run(new MainGUI(null));

        }
    }
}