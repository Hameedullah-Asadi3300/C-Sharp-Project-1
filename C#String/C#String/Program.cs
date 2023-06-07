using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_String
{
    internal class Program
    {
        static void Main()
        {
            
            //The escape character \"text\" puts the direct quoute inside the double quotation mark
            string quotationMark = "The Unites states President Joe Biden said: \"Failure at some point in your life is inevitable, but giving up is unforgivable.\"";
            Console.WriteLine(quotationMark);
            Console.ReadLine();


            //The escape chracter \n breaks the line
            string lineBreak = "Thanks you very much for your kind hospitality. \nHave a good evening!";
            Console.WriteLine(lineBreak);
            Console.ReadLine();


            //The escape character double backslash gives one backslash inside the string
            string doubleBackSlash = "Users\\Ahmed\\Desktop\\MyPics"; //We can also use @ at the begining and outside the openein quotation mark which tells the compiler that everything inside that is part of string
            // Ex: @"Users\\Ahmed\\Desktop\\MyPics";
            Console.WriteLine(doubleBackSlash);
            Console.ReadLine();


            //The .ToUpper(): method changes the letters to capital
            string name = "Hameedullah Asadi";
            name =  name.ToUpper();
            Console.WriteLine(name);
            Console.ReadLine();


            //The .ToLower method changes the letters to lowercase
            string City = "Alabama";
            City = City.ToLower();
            Console.WriteLine(City);
            Console.ReadLine();

            //Strings are immutable after it is created


            //Conacatenation
            Console.WriteLine("What is your first name?");
            string fName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("What s your last name?");
            string lName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("your full name is " + fName + " " + lName + ".");
            Console.ReadLine();


            //To uppercase method
            string state = "NewYork";
            state = state.ToUpper();
            Console.WriteLine(state);
            Console.ReadLine();





        }
    }
}
