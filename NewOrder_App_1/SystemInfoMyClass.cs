using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOrder_App_1
{
    public class SystemInfoMyClass
    {
        static private string system = "Informacje o systemie: "
            + "\nWersja systemu: " + Environment.OSVersion
            + (Environment.Is64BitOperatingSystem ? ", 64 bitowy" : "")
            + "\nWersja Microsoft .NET Framework: " + Environment.Version
            + "\nNazwa komputera: " + Environment.MachineName
            + "\nKatalog systemowy: " + Environment.SystemDirectory;

        static private string user = "Informacje o bieżącym użytkowniku:"
            + "\nNazwa użytkownika: " + Environment.UserName
            + "\nKatalogi specjalne użytkownika:"
            + "\nKatalog 'Moje Dokumenty' = " + Environment.GetFolderPath(Environment.SpecialFolder.Personal)
            + "\nKatalog 'Pulpit' = " + Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            + "\nKatalog 'Autostart' = " + Environment.GetFolderPath(Environment.SpecialFolder.Startup)
            + "\nKatalog domowy użytkownika = " + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        static private string zmienne = "";
            
        public static void PrintSystemInfo()
        {
            Console.WriteLine("SystemInfo\n-------\n");
            Console.WriteLine(system + "\n");
        }

        public static void PrintUserInfo()
        {
            Console.WriteLine("UserInfo");
            Console.WriteLine(user + "\n");
        }

        public static void PrintEnvironmentVariables()
        {
            System.Collections.IDictionary zmienneSrodowiskowe = Environment.GetEnvironmentVariables();
            foreach (System.Collections.DictionaryEntry zmienna in zmienneSrodowiskowe)
            {
                zmienne += zmienna.Key + " = " + zmienna.Value + "\n";
            }

            Console.WriteLine("\nZmienne środowiskowe:\n" + zmienne);
        }

        public static void PrintLogicalDrivers()
        {
            string[] dyski = Environment.GetLogicalDrives();
            string driverinfo = "\nDyski: ";

            foreach (string dysk in dyski) driverinfo += dysk + " ";
            Console.WriteLine(driverinfo + "\n");
        }

        public static void PrintAllInfo()
        {
            PrintSystemInfo();
            PrintUserInfo();
            PrintEnvironmentVariables();
            PrintLogicalDrivers();
        }
    }
}
