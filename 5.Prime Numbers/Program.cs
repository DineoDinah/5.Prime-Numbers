using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Prime_Numbers
{
    internal class Program
    {
        static int[] Prime = new int[30];

        static void SieveOfEratosthenes(int n)
        {
            Prime[0] = 1;
            for (int i = 3; i*i <= n; i += 2)
            {
                if (Prime[i / 2] == 0)
                {
                    for (int j = 3 * i; j <= n; j += 2 * i)
                        Prime[j / 2] = 1;
                }
            }
        }

        static void Main(string[] args)
        {

            int n =30;
            SieveOfEratosthenes(30);
            for (int i = 1; i <= n; i++)
            {
                if (i == 2)
                    Console.Write(i + " ");
                else if (i % 2 == 1 && Prime[i / 2] == 0)
                    Console.Write(i + " ");

            }

        }
    }
}
