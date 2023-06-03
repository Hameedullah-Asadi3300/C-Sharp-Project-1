using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Academy of Learning Career College");  //This will print the first message
            Console.WriteLine("Student Daily Report");    //This will print the second message
            Console.WriteLine("What is your name?");     //This will print the Third message
            string name = Console.ReadLine();   //This will keep the console open
            Console.WriteLine("What course are you on?");    //This statement will print the fourth message
            string course = Console.ReadLine();   //This statement will keep the console open
            Console.WriteLine("What page number");    //This statement will print the fifth message
            int pagenumber = Convert.ToInt32(Console.ReadLine());   //This statement cast/convert string to int
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\""); //This statement will print sixth message
            string needHelp = Console.ReadLine();    //This statement will keep the console open
            bool needHelpBool = bool.Parse(needHelp);   //This statement casts/converts the string to boolean logic
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics."); //This statement prints seventh message
            string positive = Console.ReadLine();     //This statement keeps the console open
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific."); //This statement prints eigth message
            string feedback = Console.ReadLine();    //This statement keeps the console open
            Console.WriteLine("How many hours did you study today?");    //This statement prints the ninth message
            string hours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(hours);    //This statement casts/converts string to int
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");  //This statement prints the last and thenth message
            Console.ReadLine(); //This ststament keeps the console open
        }
    }
}
