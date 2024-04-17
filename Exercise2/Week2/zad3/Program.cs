using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        static void EvenOrOdd(int num, out bool even, out bool odd)
        {
            even = num % 2 == 0;
            odd = !even;
            //if (num % 2 == 0)
            //{
            //    even = true;
            //    odd = false;
            //}
            //if (num % 2 != 0)
            //{
            //    even = false;
            //    odd = true;
            //}
        }
        static void Main(string[] args)
        {
            int n = 5;
            bool even, odd;
            EvenOrOdd(n, out even, out odd);
            Console.WriteLine("The number is even? {0} " , even);
            Console.WriteLine("The number is odd?  {1} ", odd);

        }
    }
}
