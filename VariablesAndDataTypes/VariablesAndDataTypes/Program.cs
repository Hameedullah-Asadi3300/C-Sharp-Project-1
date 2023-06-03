using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////This is a simple program
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();


            //Second Program
            Console.WriteLine("What is your favorite food?");
            String YourFavoriteFood = Console.ReadLine();
            Console.WriteLine("Your favorite food is " + YourFavoriteFood);
            Console.ReadLine();


            //Third program using int data type
            Console.WriteLine("What is your favorite number?");
            String favoriteNumber = Console.ReadLine();
            Console.WriteLine("Your favorite number is: " + favoriteNumber);
            Console.ReadLine();


            //This little programs is about math operation and data type conversion
            Console.WriteLine("What is your favorite number?");
            string favoriteNum = Console.ReadLine();
            int favNums = Convert.ToInt32(favoriteNum);
            int total = favNums + 5;
            Console.WriteLine("Your favorite number plus 5 is: " + total);
            Console.ReadLine();


            //boolean data type
            Console.WriteLine();
            bool isStudying = false;

            ////byte data type
            byte hoursWorked = 42;
            sbyte todaysTemperature = 18;
            char randomLetter = 'n';
            char questionMark = '\u2103'; //This is unicode for "?" mark//
            Console.WriteLine(questionMark);
            Console.ReadLine();

            //decimal data type
            decimal moneyInBank = 100.5m; //At the end of the decimal, 'm' is used so the compiler knows.

            //double data type
            double heightInCentimeter = 211.30202092;  //15 digits in length

            //float data type
            float secondsLeft = 2.62f;    //only 7 digits in length

            //short data type
            short temperatureInMars = -341; //short is for -32 thousand and positive 32 thousand digits in length

            //string data type
            string myFullName = "Hameedullah Asadi";



            //Casting from int to string
            int currentAge = 30;
            string yearsOld = currentAge.ToString();


            //casting boolean to int
            bool isRaining = true;
            string rainStatus = Convert.ToString(isRaining);
            Console.WriteLine(isRaining);
            Console.ReadLine();

            //End

        }

    }
}
