using System;


namespace task_1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool Result;
            if (n % 9 == 0 || n % 11 == 0 || n % 13 == 0)
            {
                Result = true;
            }
            else
            {
                Result = false;
            }
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
