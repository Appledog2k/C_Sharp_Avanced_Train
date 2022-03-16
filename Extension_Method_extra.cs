
using System;
//create extension method for existing method

namespace Extension_method
{

    // extenssion method 1
    static class MyLibExtension
    {
        public static void Print(this string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            System.Console.WriteLine(s);
        }
        // extension method 2

        public static double Square(this double x) => x * x;

        // extension method 3
        public static double SquareRoot(this double x) => Math.Sqrt(x);
    }



}