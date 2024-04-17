using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    class Program
    {
        static void Replace( ref int[] array , int targetValue, int newValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ( array[i] == targetValue)
                {
                    array[i] = newValue;
                }
            }

        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 ,2};
            Console.WriteLine("Before replace : " + string.Join(",", arr));
            int targetValue = 2;
            int newValue = 13;
            Replace(ref arr, targetValue, newValue);
            Console.WriteLine("After replace : " + string.Join(",", arr));


        }
    }
}
