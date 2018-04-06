using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KnockKnockLeo
{
    class Program
    {
        static void Main(string[] args)
        {
            string story = "Hello Leo, follow the white rabbit. . .";
            A(story);
            story = "Knock knock Leo. . .";
            A("\n");
            A(story);
            B();
            Console.ReadKey();

        }

        public static void A(string a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                Thread.Sleep(185);
            }        
        }
        public static void C(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                Thread.Sleep(1);

            }
        }
        public static void B()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Random rand = new Random();
            for (int i = 0; i < 10000; i++)
            {
                char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                char[] lowerCase = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                char[] upperCase = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                char[] specialChar = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' };
                char[] evenMoreSpecial = { (char)156, (char)182, (char)240, (char)248, (char)142, (char)232, (char)240, (char)231, (char)253, (char)254, (char)255, (char)201, (char)202, (char)203, (char)204 };
                string[] whatCipherSaw = { "BLONDE", "BRUNETTE", "REDHEAD" };
                int randomCharType = rand.Next(6);
                int randomNumber;
                switch (randomCharType)
                {

                    case 0:
                        randomNumber = rand.Next(10);
                        C(numbers[randomNumber] + "   ");
                        break;
                    case 1:
                        randomNumber = rand.Next(26);
                        C(lowerCase[randomNumber] + " ");
                        break;
                    case 2:
                        randomNumber = rand.Next(26);
                        C(upperCase[randomNumber] + "  ");
                        break;
                    case 3:
                        randomNumber = rand.Next(12);
                        C(specialChar[randomNumber] + "");
                        break;
                    case 4:
                        randomNumber = rand.Next(15);
                        C(evenMoreSpecial[randomNumber] + "    ");
                        break;
                    case 5:
                        int superRANDO = rand.Next(100);
                        if(superRANDO == 99)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            randomNumber = rand.Next(3);
                            C(whatCipherSaw[randomNumber] + "");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        
                        break;
                }
            }
        }
    }
}
