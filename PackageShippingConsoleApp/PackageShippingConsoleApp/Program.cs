using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageShippingConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            int packageWeight = 50;
            int packageWidth = 1;
            int packageHeight = 2;
            int packagelength = 50;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below:"); //Prints the welcome message to the console app
            Console.WriteLine("Please enter the pakage weight.");   //Prints to the console app which directs the user
            int weight = Convert.ToInt32(Console.ReadLine());   //Converts the user's input to int32 data type
           if (weight > packageWeight)    //This is branching which evaluates if the weight is more than packageWeight
            {
                Console.WriteLine("We are sorry, the package is too heavy to be shipped via Package Express. Have a good day."); //It will print if the if is true
            }


           //PACKAGE WIDTH
            Console.WriteLine("Please enter the package width.");   //Prints to the console app which directs the user 
            int  width = Convert.ToInt32(Console.ReadLine());    //Converts the user's input to string


            //PACKAGE HEIGHT
            Console.WriteLine("please enter the package height.");  //Prints to the console app which directs the user 
            string height = Convert.ToString(Console.ReadLine());   //Converts the user's input to string


            //PACKAGE LENGTH
            Console.WriteLine("Please enter the package length.");  //Prints to the console app which directs the user 
            int length = Convert.ToInt32(Console.ReadLine());   //Converts the user's input to int32 data type
            if (length > packagelength)      //This is branching which evaluates if  the length is more than packagelength
            {
                Console.WriteLine("We are sorry, the package is too big to be shipped via Package Express"); //It will print if the if is true
            }
            decimal quote = (packageHeight * packageWidth * packagelength) * packageWeight / 100;

            Console.WriteLine("Your estimated total for shipping this package is: $ " + quote + ". " + " \nHave a safe trip. \nThank you!"); //Prints the total amount to be paid
            Console.ReadLine(); //Keeps the console open
        }
    }
}
