using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());

            bool luckynum = number == 12;
            do
            {       
                switch (number)
                {
                    case 52:
                        Console.WriteLine("You choose wrong number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 72:
                        Console.WriteLine("You choose wrong number.");
                        Console.WriteLine("Guess a number again");
                        number = Convert.ToInt32(Console.ReadLine());   
                        Console.ReadLine();
                        break;

                    case 62:
                        Console.WriteLine("You choose wrong number.");
                        Console.WriteLine("Guess a number again");
                        number = Convert.ToInt32(Console.ReadLine());       
                        Console.ReadLine();
                        break;

                    case 32:
                        Console.WriteLine("You choose wrong number.");
                        Console.WriteLine("Guess a number again");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.ReadLine();
                        break;

                    case 12:
                        Console.WriteLine("You guessed the number 12. That is right. \nThanks you!");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Please choose a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.ReadLine();
                        break;
                        }               
                }
            while (!luckynum) ;
            Console.ReadLine();
        }
    }     
        }
