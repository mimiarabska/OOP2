using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {

        static void MinMaxAvr(int[] array , out int max, out int min, out double average)
        {
             max = array[0];
             min = array[0];
            int sum = 0;

            foreach (var number in array)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
                sum = sum + number;
            }
            average = (double)sum / array.Length;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int min, max;
            double average;
            


        }
    }
}
