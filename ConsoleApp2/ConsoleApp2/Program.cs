using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string input2;
            double a, b;

            Console.WriteLine("Hey there! What are you in the mood for this weekend?\n" +
                "Here are your options (Please choose a number!);\n" +
                "1. Action packed (Less than Rambo, more than Finding Nemo)\n" +
                "2. Chillin like a villian\n" +
                "3. Dangerous (Pick this, you won't be mad)\n" +
                "4. Food better than grandmas");
            input = Console.ReadLine();
            a = Convert.ToDouble(input);

            if (a == 1 || a == 2 || a == 3 || a == 4)
            {
                Console.WriteLine("Awesome, how many people are going with you?");
                
            }
            else
            {
                Console.WriteLine("Please choose a number 1-4!");
            }

            
            input2 = Console.ReadLine();
            b = Convert.ToDouble(input2);

            if ((a == 1) && (b == 0))
            {
                Console.WriteLine("You should travel to the upcoming races by walking");
            }else if ((b <= 4) && (a == 1))
            {
                Console.WriteLine("You should travel to the upcoming races by carpooling");
            }else if((b >= 5) && (b <=10) && (a == 1))
            {
                Console.WriteLine("You should travel to the upcoming races by bus");
            }else if(b >=11 && (a == 1))
            {
                Console.WriteLine("You should travel to the upcoming races by plane");
            }

            if ((a == 2) && (b == 0))
            {
                Console.WriteLine("You should walk down to the river and canoe");
            }
            else if ((b <= 4) && (a == 2))
            {
                Console.WriteLine("You should travel to the river for some canoeing by carpooling");
            }
            else if ((b >= 5) && (b <= 10) && (a == 2))
            {
                Console.WriteLine("You should travel to the river for some canoeing by bus");
            }
            else if ((b >= 11) && (a == 2))
            {
                Console.WriteLine("You should travel to the river for some canoeing by plane");
            }

            if ((a == 3) && (b == 0))
            {
                Console.WriteLine("You should walk to the ocean and (carefully) swim with sharks");
            }
            else if ((b <= 4) && (a == 3))
            {
                Console.WriteLine("You should travel to the ocean and (carefully) swim with sharks by carpooling");
            }
            else if ((b >= 5) && (b <= 10) && (a == 3))
            {
                Console.WriteLine("You should travel to the ocean and (carefully) swim with sharks by bus");
            }
            else if ((b >= 11) && (a == 3))
            {
                Console.WriteLine("You should travel to the ocean and (carefully) swim with sharks by plane");
            }

            if ((a == 4) && (b == 0))
            {
                Console.WriteLine("You should travel to the local buffet");
            }
            else if ((b <= 4) && (a == 4))
            {
                Console.WriteLine("You should travel to the local buffet by carpooling");
            }
            else if ((b >= 5) && (b <= 10) && (a == 4))
            {
                Console.WriteLine("You should travel to the local buffet by bus");
            }
            else if ((b >= 11) && (a == 4))
            {
                Console.WriteLine("You should travel to the local buffet by plane");
            }
            
            Console.WriteLine("Enjoy your weekend, goodbye!");
            Console.ReadLine();








        }
    }
}
