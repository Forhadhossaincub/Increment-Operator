using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n = 10;
            n = n + 1;    // 11
            n++;          // 12
            Console.WriteLine(n); // Print 12

            int m = n++;

            Console.WriteLine(m); // Print 12
            Console.WriteLine("m = " + m); // Print 12

            int x = 10;
            int y = 10;

            Console.WriteLine($"x = {x++}, y = {++y}");  //Print x = 10 , y = 11

            var v = 9.9;
            Console.WriteLine(v.GetType());




            Console.ReadKey();
        }
    }
}
