using System;

namespace task1000
{
    internal class task1000
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string[] numbers = inputString.Split(' ');
            Console.WriteLine(Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]));
        }
    }
}
