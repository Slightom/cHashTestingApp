using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
             GuessYourSex.AreYouAManOrAWoman2();
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
