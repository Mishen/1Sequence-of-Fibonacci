using System;

namespace Sequence_of_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
         
            double a = 0, b = 1, c ;
            //Console.WriteLine(a);
            for (int j = 1; j <= 100; j ++)
            {
                if (j > 1)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(a);
                }
            }
            
        }
    }
}
