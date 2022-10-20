using SE1626_HE151002_MinhND_A1.Model;
using System.Configuration;

namespace SE1626_HE151002_MinhND_A1
{
    internal static class Program
    {
        public static IConfiguration Configuration;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            ModelBase.ConnectDatabase();

            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            var carGUI = new CarGUI();
            carGUI.HandleDestroyed += (object? sender, EventArgs e) => ModelBase.CloseConnection();
            Application.Run(carGUI);
        }

    }
}