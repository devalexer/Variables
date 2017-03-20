using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            string welcome = "Hello World";
            Console.WriteLine(welcome);

            int yearColumbusSailedOceanBlue = 1492;
            Console.WriteLine(yearColumbusSailedOceanBlue);

            bool dogAtHome = true;
            Console.WriteLine("It is " + dogAtHome + " that I have a dog at home.");

            string today = DateTime.Now.ToString();
            Console.WriteLine("Today is " + today);

            decimal value = 5.45m;
            Console.WriteLine($"I spent {value:C} on a cheeseburger.");

            char letter = 'x';
            Console.WriteLine($"{letter} marks the spot");



            Console.WriteLine("What is the first random number that entered your head?");
            string rawInput = Console.ReadLine();
            int value0 = 0;
            bool output = int.TryParse(rawInput, out value0);
            if (output)
            {
                Console.WriteLine($"The number you chose was {value0:C}");
            }


            Console.WriteLine("What is the first random number that entered your head?");
            string userInput = Console.ReadLine();
            int value1 = 0;
            bool processednumber = int.TryParse(rawInput, out value1);
            if (processednumber)
            {
                Console.WriteLine($"The number you chose was {value1:C}");
            }
            else
                while (false)
                {

                }
        }
    }
}


