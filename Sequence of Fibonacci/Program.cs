using System;

namespace Sequence_of_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Insert a number of SoF: ");
            number = Convert.ToInt32(Console.ReadLine());

            double a = 0, b = 1, c;
            for (int j = 1; j <= number+1; j ++)
            {
                if (j>1)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                else
                {
                    c = a;
                }

                if (j >= number-1 && j <= number+1)
                {
                    Console.WriteLine(c);
                }
            }
            
        }
    }
}
