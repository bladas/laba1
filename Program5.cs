using System;
namespace task_1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double h;
            double area;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
            area = ((a + b) / 2) * h;
            Console.WriteLine(area);
            Console.ReadKey();

        }
    }
}
