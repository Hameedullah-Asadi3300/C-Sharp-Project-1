using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConsoleApp
{
    internal class Program
    {
        static void Main()
        {
        
            int roomTemperature = 35;  //The int data type variable/roomTemperture stores the value of 35

            Console.WriteLine("What is your name?");  //Prints on console
            string name = Console.ReadLine();    //gets the input from the user and assign it a string data type in variable name
            Console.WriteLine("Hi, " + name + ", what is the temperature where you live in?"); //It concatenate the user's name say hi
            int currentTemerature = Convert.ToInt32(Console.ReadLine()); //casts the string/user's input to int32
            if (currentTemerature == roomTemperature)    //branch starts. It compare the booh temperature with equal operator
            {
                Console.WriteLine("It is exactly the room temperature"); //Prints on console
            }
            else if (currentTemerature > roomTemperature)   //Comapre if the currentTemperature is greater than roomTemperature in number
            {
                Console.WriteLine("The current temperaure is hot than the room tempearture."); //Prints if the else if applies
            }
            else if (currentTemerature < roomTemperature) //Compare the current Teperature if it is less than roomTemperature in number
            {
                Console.WriteLine("The current temperature is not hot than the room temperature."); //Prints if the second else if applies
            }
            else  //This is the else statement
            {
                Console.WriteLine("Something went wrong"); //Prints if applies
            }
            Console.ReadLine(); //Keeps the console open
        }
    }
}
