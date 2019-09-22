using System;

namespace task_1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(a>b && a>c)
            {
                Console.WriteLine("Max = "+a);
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("Max = " + b);
            }
            else
            {

                Console.WriteLine("Max = " + c);
            }
            Console.ReadKey();
        }

    }
}
