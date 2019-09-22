using System;


namespace task_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float  b;
            float  c;
            float  average;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            average = (a + b + c) / 3;

            Console.WriteLine(average);
            Console.ReadKey();
        }
    }
}
