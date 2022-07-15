using System;
using Math;

namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();

            Console.WriteLine(math.Add(10, 20));
            Console.WriteLine(math.Multiply(10, 20));

            Console.ReadLine();
        }
    }
}