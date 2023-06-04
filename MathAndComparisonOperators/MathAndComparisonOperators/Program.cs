using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    internal class Program
    {
        static void Main()
        {
            //Basic Addition operator is used for adding numbers
            int number1 = 15 + 10;
            Console.WriteLine("Fifteen plus ten: " + number1.ToString());
            Console.ReadLine();


            //Combined addition
            int number2 = 5 + 5;
            int number3 = 10 + 20;
            int total1 = number1 + number2;
            Console.WriteLine(total1);
            Console.ReadLine();
            //The output is 40


            //subtraction
            int num5 = 20 - 15;
            Console.WriteLine("Twenty minus fifteen: " + num5.ToString());
            Console.ReadLine();
            //The output is 5


            //Multiplication
            int num6 = 10 - 60;
            Console.WriteLine(num6);
            Console.ReadLine();
            //The output is 50


            //Division
            int num7 = 100 / 5;
            Console.WriteLine(num7);
            Console.ReadLine();
            //The output is 20


            //double data type in division
            double  num8 = 20.54 / 20.54;
            Console.WriteLine(num8);
            Console.ReadLine();
            //The output is 1


            //Modulus operator
            int num9 = 50 % 9;
            Console.WriteLine(num9);
            Console.ReadLine();
            //The output is 5


            //Comparison operators are very useful specially when dealing with users input
            //greater than comparison
            bool  trueOrFalse = 10 > 5;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();
            //The output is true


            //Less than Comparison
            bool num10 = 20 < 10;
            Console.WriteLine(num10.ToString());
            Console.ReadLine();
            //The output is false


            int roomTemperature = 70;
            int currentTemperature = 72;
             bool isWarm = roomTemperature > currentTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();
            //The output is false


            //Greater than or equal to
            int tomatoPrice = 12;
            int currentPrice = 12;
            bool price = tomatoPrice >= currentPrice;
            Console.WriteLine(price);
            Console.ReadLine();
            //The ouptut is true


            //Equality comparison 'Equal to' ==
            decimal curentToyoto = 50.500m;
            decimal pastToyota = 52.500m;
            bool isCheap = curentToyoto == pastToyota;
            Console.WriteLine(isCheap.ToString());
            Console.ReadLine();
            //The output is false


            //Not equal to
            float currentHeight = 1.68f;
            float expectedHeight = 1.75f;
            bool idealHeight = currentHeight != expectedHeight;
            Console.WriteLine(idealHeight.ToString());
            Console.ReadLine();
            //The outut is true
























        }
    }
}
