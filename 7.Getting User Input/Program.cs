using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Getting_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            //use write not weriteline
            Console.Write("Enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
            Console.Write("How old are you ");
            //The values from the user are always a string
            string age = Console.ReadLine();
            Console.WriteLine("You are " + age + " of age");

            Console.ReadLine();

        }
    }
}
