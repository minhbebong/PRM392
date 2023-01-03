using Microsoft.Extensions.Configuration;
using PRN211_Assignment2.Models;
using System.DirectoryServices.ActiveDirectory;

namespace PRN211_Assignment2
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

            Program.Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            for (int i = 0; i < 3; i++)
            {
                Program.MusicStoreContext = new MusicStoreContext();
                if (Program.MusicStoreContext == null)
                {
                    MessageBox.Show($"Connect DB Error: Retry {i + 1} / 3 times in 5s");
                    Thread.Sleep(5000);
                }
                else break;
            }

            Application.Run(new MainGUI());
        }

        public static IConfiguration? Configuration { get; set; }

        public static MusicStoreContext? MusicStoreContext { get; set; }

        public class CSettings
        {
            public string? CartId { get; set; }
            public User? User { get; set; }
        }

        public static CSettings Settings { get; set; } = new CSettings();
    }
}