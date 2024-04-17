using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    class Program
    {
        static void SplitArray(int[] array, out int[] evenNumbers, out int[] oddNumbers)
        {
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            foreach (var number in array)
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
            }
            evenNumbers = evens.ToArray();
            oddNumbers = odds.ToArray();

        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] evenNumbers;
            int[] oddNumbers;

            SplitArray(numbers, out evenNumbers, out oddNumbers);

            Console.WriteLine("Even numbers : " + string.Join(",", evenNumbers));
            Console.WriteLine("Odd numbers : " + string.Join(",", oddNumbers));

        }
    }
}
