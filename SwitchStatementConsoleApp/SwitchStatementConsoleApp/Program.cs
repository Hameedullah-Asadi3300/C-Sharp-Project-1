using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatementConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the weekday consoleApp!"); //This is a welcome message at the top of the screen
            Console.WriteLine("What is your favorite number from 1-7 to match the weekdays?"); //This statement asks the user for input
            int weekday = Convert.ToInt32(Console.ReadLine()); //This statement casts the user input to int data type
            switch (weekday) //This is where switch starts and it is named weekday to match the user input
            {
                case 1: //If the input is 1, then it will print Monday
                    Console.WriteLine("Monday"); //The monday will print
                    Console.ReadLine(); //Keeps the console open
                    break; //If the input matches, it will stop further matching

                case 2: //This is case 2 and if the input is two, it will print Tuesday
                    Console.WriteLine("Tuesday");  //The Tuesday will print
                    Console.ReadLine(); //Keeps the console open
                    break; //If the input matches, it will stop further matching

                case 3: //If the input is 1, then it will print Wedensday
                    Console.WriteLine("Wedensday");
                    Console.ReadLine(); //Keeps the console open
                    break; //If the input matches, it will stop further matching 

                case 4: //If the input is 1, then it will print Thursday
                    Console.WriteLine("Thursday");
                    Console.ReadLine(); //Keeps the console open
                    break; //If the input matches, it will stop further matching
                           
                case 5: //If the input is 1, then it will print Friday
                    Console.WriteLine("Friday");
                    Console.ReadLine(); //Keeps the console open
                    break; //If the input matches, it will stop further matching
                           
                case 6: //If the input is 1, then it will print Saturday
                    Console.WriteLine("Saturday");
                    Console.ReadLine(); //Keeps the console open
                    break; //If the input matches, it will stop further matching 

                case 7: //If the input is 1, then it will print Sunday
                    Console.WriteLine("Sunday");
                    Console.ReadLine(); //Keeps the console open
                    break; //If the input matches, it will stop further matching 

                default: //This is default and will pring the following message if the input does not match any of the case above
                    Console.WriteLine(weekday + " is not a day. Please write a number between 1-7."); //It is the value assigned for default
                    Console.ReadLine(); //Keeps the console open
                    break;  //If the input matches, it will stop further matching 
            }
        }
    }
}
