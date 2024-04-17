using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Program
    {

        static void Swap(ref int n, ref int m)
        {
           int temp = n;
            n = m;
            m = temp;
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before swap a = {0} , b = {1}",a,b);
            Swap(ref a, ref b);
            Console.WriteLine("After swap a = {0} , b = {1}", a, b);


        }
    }
}
