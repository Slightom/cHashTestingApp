using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOrder_App_1
{
    class DelegateTest
    {
        public void MainDelegate()
        {
            //tworzymy instancję klasy i podpinamy funckję zwrotną
            SystemSpecialDelegate system = new SystemSpecialDelegate();
            system.DodajCallback(CallbackLogi);

            system.Logowanie("user", "pass");

            Console.ReadKey();
        }

        static void CallbackLogi(string wiadomosc)
        {
            Console.WriteLine(wiadomosc);
            Console.WriteLine("Została wywołana funkcja zwrotna");
        }
    }
    public class SystemSpecialDelegate
    {
        //publiczna definicja delegaty (będzie klasą zagnieżdżoną)
        public delegate void Logi(string wiadomosc);

        //prywatna zmienna delegata
        private Logi _wyslijLogi;

        //setter dla zmeinnej delegata
        public void DodajCallback(Logi funkcja)
        {
            _wyslijLogi += funkcja;
        }

        public void UsunCallback(Logi funkcja)
        {
            _wyslijLogi += funkcja;
        }

        //przykladowa funkcjonalność naszej klasy
        public bool Logowanie(string user, string password)
        {
            /* jakeiś operacje odpowiedzialne za Autoryzację */

            _wyslijLogi("Nastąpiła próba logowania użytkownika: " + user);

            return true;
        }
    }
}
