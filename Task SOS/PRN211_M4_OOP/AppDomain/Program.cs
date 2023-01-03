using System.Diagnostics;
using System.Reflection;

namespace AppDomains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDomain appDomain = AppDomain.CurrentDomain;
            Console.WriteLine($"Friendlyname = {appDomain.FriendlyName}");

            Assembly[] assemblies = appDomain.GetAssemblies();
            foreach (Assembly assembly in assemblies)
                Console.WriteLine($"Assembly name = {assembly.GetName()}, Version = {assembly.GetName().Version}");

            var processes = Process.GetProcesses();
            foreach (Process process in processes)
                Console.WriteLine($"Process: Id = {process.Id}, Name={process.ProcessName}");

        }
    }
}