using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOrder_App_1
{
    public class Testowa
    {
        public int pole1;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // equals vs ==
            // EqualsVsComparison();       

            // abstract class and method
            // AbstractTrain();

            // are you a man or a woman?
            // GuessYourSex.AreYouAManOrAWoman2();

            // message dialog box
            // Console.WriteLine("Hello world!");
            // MessageBox.Show("No siema siema");

            // get system info
            // SystemInfoMyClass.PrintAllInfo();


            // DniTygodnia day = DniTygodnia.poniedzialek;
            // Console.WriteLine("Poniedzialek to pierwszy dzień tygodnia? : " + ((int)day == 2));

            //string s = "napis";
            //ModifyString(ref s);
            // string s2;
            // ModifyString2(out s2);
            // Console.WriteLine(s);

            // DelegateTest delegateTest = new DelegateTest();
            // delegateTest.MainDelegate();

            //List<int> l = new List<int>(new[] { 1, 2, 3, 4, 5 });
            //List<int> l = new List<int> { 1, 2, 3, 4, 5 };

            //string napis = "";
            //foreach (var e in l) napis += (e.ToString() + " ");
            //Console.WriteLine("przed: " + napis);
            //for(int i=0; i<l.Count(); i++)
            //{
            //    l.RemoveAt(i);
            //}
            //napis = "";
            //foreach (var e in l) napis += (e.ToString() + " ");
            //Console.WriteLine("po: " + napis);

            Ulamek u1 = new Ulamek(1,2);
            Console.WriteLine(u1.ToString());
            u1 += new Ulamek(6, 4);
            Console.WriteLine(u1.ToString());

            Console.ReadKey();
        }

        private static int Kwadrat(int y)
        {
            return y * y;
        }

        public static void ModifyString(ref string s)
        {
            s += "REF";
        }
        public static void ModifyString2(out string s)
        {
            s = "";
            s += "REF";
        }

        private static void AbstractTrain()
        {
            Cow cow = new Cow();
            Horse horse = new Horse();

            cow.Suck();
            horse.Suck();
            cow.HonkeOnce();
            horse.HonkeOnce();
        }

        private static void EqualsVsComparison()
        {
            object o = "Przykładowa treść";
            object o1 = new string("Przykładowa treść".ToCharArray());
            // znak == - sprawdzenie czy referencja jest taka sama || FALSE
            Console.WriteLine(o == o1);
            // Equals - sprawdzenie czy zawartość jest taka sama || TRUE
            Console.WriteLine(o.Equals(o1));
        }
    }

    #region abstract classes training
    abstract class Mammal
    {
        public abstract void HonkeOnce();
        public void Suck() { Console.WriteLine("drink drink drink"); }
        private void Suck2() { Console.WriteLine("drink2 drink2 drink2"); }
    }

    class Cow : Mammal
    {
        public override void HonkeOnce()
        {
            Console.WriteLine("Muuuuuuu");
        }
    }

    class Horse : Mammal
    {
        public override void HonkeOnce()
        {
            Console.WriteLine("iiiihaahahaha");
        }
    }
    #endregion
}
