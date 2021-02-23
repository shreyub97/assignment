using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0, counter = 0, n = 5;
            for(int i = 0; i <n; i++)
            {
                value = i + 1;
                counter = n - 1;
                for(int j = 0; j <= i; j++)
                {
                    Console.WriteLine(value + " ");
                    value = value + counter;
                    counter = counter - 1;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
