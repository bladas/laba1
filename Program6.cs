using System;

namespace task_1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int LastDigit;
            LastDigit = n % 10;
            Console.WriteLine(LastDigit);
            Console.ReadKey();
        }
    }
}
