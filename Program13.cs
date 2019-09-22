using System;


namespace Task_1._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int faktorial = 1;

            for(int i = 1;n>=i ; ++i)
            {
                faktorial = faktorial * i;
            }
            Console.WriteLine(faktorial);
            Console.ReadLine();
        }
    }
}
