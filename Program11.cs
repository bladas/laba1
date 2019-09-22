using System;


namespace task_1._11
{
    class Program
    {
        static void Main(string[] args)
        {   
            double a = float.Parse(Console.ReadLine());
            double b = float.Parse(Console.ReadLine());
            double c = float.Parse(Console.ReadLine());
            string product = null;
            if(a<0 && b<0 || a<0 && c<0 || b<0 && c<0 || a>0 && b>0 && c>0)
            {
                product = "Positive";
            }
            else if(a<0 && b>0 && c>0 || a>0 && b<0 && c>0 || a>0 && b>0 && c<0 || a<0 && b<0 && c<0)
            {
                product = "Negative";
            }
            Console.WriteLine(product);
            Console.ReadKey();
        }
    }
}
