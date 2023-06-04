using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //Prints the welcome screen
            Console.WriteLine("Person 1");   //Prints together with the welcome screen in second line
            Console.WriteLine("Hourly Rate?"); //Asks for input of the user
            string hourlyRate1 = Console.ReadLine();    //hourlyRate1 assigns a value/input 
            Console.WriteLine("Hours worked per week?");  //Asks the user about total hours working per week
            string hours1 = Console.ReadLine(); //This console.ReadLine is assigned to hours1
            int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) * 52; //get the salary of person 1, casts to int32 and then multiplies by 52 as weeks numbers in a year

            Console.WriteLine("Person 2");  //Prints on screen
            Console.WriteLine("Hourly rate?");  //Asks for input
            string hourlyRate2 = Console.ReadLine();   //This console.ReadLine is assigned to hourlyRate2
            Console.WriteLine("Hours worked per week"); //Prints on screen
            string hours2 = Console.ReadLine(); //This console.ReadLIne is assigned to hours2
            int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2) * 52;  //is a varaiable of salary2, casts the input to int32 data type and multiplies it by 50


            Console.WriteLine("Annual salary of Person 1"); //prints on screen
            Console.WriteLine(salary1); //prints the annual salary
            Console.WriteLine("Annual salary of person 2"); //prints on screen
            Console.WriteLine(salary2); //prints the annual salary
            Console.WriteLine("Does person 1 make more money than person 2?");  //prints on screen
            bool highPaid = salary1 > salary2;  //comparison of salary1 and salary2
            Console.WriteLine(highPaid); //prints the comparison output as true/false. here the output is true
            Console.WriteLine("Person 1 makes more money than Person 2"); //prints the final program statement
            Console.ReadLine(); //keeps the console open




          



        }
    }
}
