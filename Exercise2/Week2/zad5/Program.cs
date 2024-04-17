using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Program
    {
        static void Factorial(int num, out long fNum)
        {
            fNum = 1;
            for (int i = 1; i <= num; i++)
            {
                fNum = fNum * i;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("n= ");
            int n = int.Parse(Console.ReadLine());
           
            
            if (n<0)
            {
                Console.WriteLine("The number is not possitive");
            }
            else
            {
                long fNum;
                Factorial(n, out fNum);
                Console.WriteLine(fNum);
            }
            
        }
    }
}
