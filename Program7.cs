using System;
namespace task_1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = float.Parse(Console.ReadLine());
            double n = float.Parse(Console.ReadLine()); ;
            double nDigit;

            nDigit = (number /  Math.Pow(10,n - 1))%10;


            Console.WriteLine(nDigit);
            Console.ReadKey();
        }

      
    }
}
