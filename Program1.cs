using System;


namespace task_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "-100";
            string b = "128";
            string c = "-3540";
            string d = "64876";
            string f = "2147";
            string e = "-1141583228";
            string g = "-1223372036854775808";
            int a1 = Convert.ToInt32(a);
            int b1 = Convert.ToInt32(b);
            int c1 = Convert.ToInt32(c);
            int d1 = Convert.ToInt32(d);
            // int f1 = Convert.ToInt32(f);
            // int e1 = Convert.ToInt32(e);
            // int g1 = Convert.ToInt32(g);
          
            Console.WriteLine(a1+"\n"+ b1 + "\n" + c1 + "\n" + d1 + "\n" + f  + "\n" + e + "\n" + g);
            Console.ReadLine();
        }
    }
}
