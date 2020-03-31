using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOrder_App_1
{
    public class GuessYourSex
    {
        public static void AreYouAManOrAWoman()
        {
            char choice;
            do
            {
                Console.WriteLine("What's your name?");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (name.Length == 0)
                {
                    Console.Error.WriteLine("\n\n\t*** Error: Name didn't entered!\n\n");
                    return;
                }
                bool woman = (name.ToLower()[name.Length - 1] == 'a');
                if (name == "Kuba" || name == "Barnaba") woman = false;

                Console.WriteLine("Let me guess... You're a " + (woman ? "woman." : "man."));
                Console.WriteLine("Press '0' to exit");
                choice = (char)Console.Read();
            } while (choice != '0');

        }
        public static void AreYouAManOrAWoman2()
        {
            char[] name = new char[20];


            int index = 0;
            char sign, choice;
            string nameTmp;


            do
            {
                Console.WriteLine("What's your name?");
                Init(ref name, ref index);
                do
                {
                    Console.SetCursorPosition(0, 1);
                    ClearCurrentConsoleLine();
                    Console.Write("Name: ");
                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write(name[i]);
                    }

                    Console.SetCursorPosition(6 + index, Console.CursorTop);
                    sign = Console.ReadKey().KeyChar;
                    switch (sign)
                    {
                        case '\r': break;
                        case '\b':
                            {
                                if (index == 0) break;

                                name[--index] = '_';
                                break;
                            }
                        default:
                            {
                                name[index++] = sign;
                                break;
                            }
                    }
                } while (sign != '\r');

                nameTmp = GetName(name);

                if (nameTmp.Length == 0)
                {
                    Console.Error.WriteLine("\n\n\t*** Error: Name didn't entered!\n\n");
                    return;
                }
                bool woman = (nameTmp[nameTmp.Length - 1] == 'a');
                if (nameTmp == "kuba" || nameTmp == "barnaba") woman = false;

                Console.WriteLine("Let me guess... You're a " + (woman ? "woman." : "man."));
                Console.WriteLine("Press '0' to exit");
                choice = Console.ReadKey().KeyChar;
                Console.Clear();
            } while (choice != '0');


        }

        private static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        private static string GetName(char[] name)
        {
            string tmp = new string(name);
            int index = 0;

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == '_' || name[i] == '\r')
                {
                    index = i;
                    break;
                }
            }

            return tmp.Substring(0, index).ToLower();
        }

        private static void Init(ref char[] name, ref int index)
        {
            for (int i = 0; i < 20; i++)
            {
                name[i] = '_';
            }

            index = 0;
        }

       
    }
}
