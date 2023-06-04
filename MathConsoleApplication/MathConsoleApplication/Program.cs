using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathConsoleApplication
{
    internal class Program
    {
        static void Main()
        {
            //Multiplication 
            double num1 = 100.0000;    //First value of double data type
            double num2 = 50;      //Second value of double data type
            double num3 = num1 * num2;     //Third variable which multiplies value 1 and value 2
            Console.WriteLine(num3);       //Prints the output on screen
            Console.ReadLine();     //Keeps the console open




            //Addition
            int num4 = 40;    //First Value of int data type
            int num5 = 25;     //second value of int data type
            int num6 = num4 + num5; //Third variable which multiplies the two above variables
            Console.WriteLine(num6);    //Prints the ouput
            Console.ReadLine(); //Keeps the console open



            //Divisoon
            float num7 = 5; //First variable of float data type
            float num8 = 12.5f; //Second variable of float data type
            float num9 = num7 / num8;   //Third variable which divides two mentioned values above
            Console.WriteLine(num9);    //Prints the output
            Console.ReadLine(); ;   //Keeps the console open


            //Boolean logic of greather than compairosn
            int num10 = 60;  //First variable
            int num11 = 50;  //Second variable
            bool num12 = num11 > num10;  //Boolean statement
            Console.WriteLine(num12.ToString()); //casts boolean string and prints the output
            Console.ReadLine();  //Keeps the console open



            //Remainder
            int num13 = 15;
            int num14 = 7;
            int num15 = num13 % num14;
            Console.WriteLine(num15);
            Console.ReadLine();

















        }
    }
}
