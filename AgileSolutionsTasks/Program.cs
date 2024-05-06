using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileSolutionsTasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Task1
            //Console.WriteLine("Enter the width of the rectangle:");
            //var width = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the height of the rectangle:");
            //var height = int.Parse(Console.ReadLine());
            //var perimeter = 2 * (width + height);
            //var square = width * height;
            //Console.WriteLine($"Perimeter={perimeter}; /t Square={square}");

            //Task2
            //Console.WriteLine("Enter first number:");
            //var num1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number:");
            //var num2 = double.Parse(Console.ReadLine());
            //var division = num1 / num2;
            //Console.WriteLine($"{num1} / {num2} = {division}");

            //Task3
            //Implicit Casting
            short numShort = 500;
            int numI = numShort;

            int numInt = 100;
            long numLong = numInt;

            //Explicit Casting
            double myDouble = 10.5;
            int myInt = (int)myDouble;

            float myFloat = 10.5f;
            int myIn = (int)myFloat;

            string numString = "100";
            int num = int.Parse(numString);

            //Task4
            bool t = true;
            bool f = false;
            bool conjunction = t && f;
            bool disjunction = t || f;
            bool negation = !t;


            //Task5
            int number1 = 7;
            int number2 = 8;
            int number3 = 9;
            var result = !(number1 <= number2) == (number3 != number3++);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
