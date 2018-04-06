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
            

        }

        public static void A(string a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                Thread.Sleep(200);
            }
            
            
        }
    }
}
