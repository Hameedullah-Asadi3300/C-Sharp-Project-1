using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    internal class Program
    {
        static void Main()
        {
            //This operator evaluates if both of values are ture
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);


            //This operator evaluates if one of the value is true
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);


            //This operator evaluates if the first value equals to the second 
            Console.WriteLine(true == true);
            Console.WriteLine(true == false);
            Console.WriteLine(false == false);


            //This operator evaluates if the first value is not equal to the second value
            Console.WriteLine(true != true);
            Console.WriteLine(true != false);
            Console.WriteLine(false != false);


            //This operator will evaluate if one of the value is ture, bit not both as follows
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);
            Console.ReadLine();
        }
    }
}
