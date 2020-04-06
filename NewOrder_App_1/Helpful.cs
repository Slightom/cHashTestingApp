using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOrder_App_1
{
    public enum DniTygodnia : byte { poniedzialek=1, wtorek, sroda, czwartek, piatek, sobota, niedziela };
    class Helpful
    {
        
    }

    public struct Ulamek
    {
        public Ulamek(int v1, int v2) : this()
        {
            this.Licznik = v1;
            this.Mianownik = v2;
        }

        public int Licznik { get; set; }
        public int Mianownik { get; set; }

        public void Uprosc()
        {
            int a = Licznik;
            int b = Mianownik;

            //NWD
            int c;
            while(b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }

            Licznik /= a;
            Mianownik /= a;

            //znaki
            if(Licznik*Mianownik < 0)
            {
                Licznik = -Math.Abs(Licznik);
                Mianownik = Math.Abs(Mianownik);
            }
            else
            {
                Licznik = Math.Abs(Licznik);
                Mianownik = Math.Abs(Mianownik);
            }
        }

        public override string ToString()
        {
            return Licznik.ToString() + "/" + Mianownik.ToString();
        }

        #region Operatory dla ulamkow
        public static Ulamek operator +(Ulamek u1, Ulamek u2)
        {
            Ulamek wynik = new Ulamek(u1.Licznik*u2.Mianownik + u2.Licznik*u1.Mianownik, u1.Mianownik*u2.Mianownik);
            wynik.Uprosc();
            return wynik;
        }

        #endregion
    }


}
