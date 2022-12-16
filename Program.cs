using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  sum = 0, n1, n2;
            Console.Write("Enter Your n1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Your n2: ");
            n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                int j = 1;

                while (i > 5 && j < i)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                    j++;
                   
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
                
                sum = 0;

            }
            Console.ReadKey();

        }

    }
}
