using System;
namespace task1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool Result;
            if (n<20 && n%2==1 || n>20 && n%2==0)
            {
                Result = false;
            }
            else
            {
                Result = true;
            }
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
