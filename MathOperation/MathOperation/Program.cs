using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperation
{
    internal class Program
    {
        static void Main()
        {
            //Addition
            int num1 = 10;
            int num2 = 10;
            int total = num1 + num2;
            Console.WriteLine(total);
            Console.ReadLine();
            //The output is 20

            //Subtraction
            int num3 = 30;
            int num4 = 5;
            int difference = num3 - num4;
            Console.WriteLine(difference);
            Console.ReadLine();
            //The output is 25

            //Multiplication
            int num5 = 5;
            int num6 = 10;
            int output = num5 * num6;
            Console.WriteLine(output);
            Console.ReadLine();
            //The output is 50

            //Division
            int num7 = 100;
            int num8 = 5;
            int result = num7 / num8;
            Console.WriteLine(result);
            Console.ReadLine();
            //The ouptut is 20

            //Modulos operator
            int num9 = 8;
            int num10 = 3;
            int remainder = num8 % num10;
            Console.WriteLine(remainder);
            Console.ReadLine();
            //The output is 2

            //Determining the odd and even number
            int num11 = 7;
            int remainder1 = num11 % 2;
            Console.WriteLine(remainder1);
            Console.ReadLine();


            //Math operation with different data types
            int num12 = 8;
            float num13 = 5.5f;
            float useFloat  = num12 + num13;
            Console.WriteLine(useFloat);
            Console.ReadLine();


            //Math Casting - This is called implicit casting
            double num14 = 7.03230923;     //This is 15 digits long
            float num15 = 5.9f;            //This is 7 digits long
            double useDouble = num14 + num15;  //We must use double data type, so the compiler is able to compile it
            Console.WriteLine(useDouble);      //If we use float in third statement, the compiler will not know it
            Console.ReadLine();


            //Math Casting - Explicit casting
            double num16 = 7.03230923;
            float num17 = 5.9f;
            float total3 = (float)num16 + num17;   //This is explicit casting/conversion
            Console.WriteLine(total3);
            Console.ReadLine();


            //Math operation - Casting int to Decimal
            decimal num18 = 7.03230923m;
            int num19 = 5;
            decimal total4 = num18 + num19;
            Console.WriteLine(total4);
            Console.ReadLine();


            //or
            decimal num20 = 7.03230923m;
            sbyte num21 = 5;
            decimal total5 = num18 + num19;
            Console.WriteLine(total5);
            Console.ReadLine();



            //Math with string
            string firstName = "Hameedullah";
            string lastName = "Asadi";
            Console.WriteLine(firstName + " " + lastName);   //It concatenates the variables
            Console.ReadLine();



            //Implicit conversion of data types
            string fName = "Hameedullah";
            int lNumber = 20;
            Console.WriteLine(fName + lNumber);
            Console.ReadLine();


            










        }
    }
}
