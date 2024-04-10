using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad1
            Console.Write("Въведете цяло число:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum = " + sum);

            //zad2
            Console.WriteLine("Въведете просто число:");
            int num = int.Parse(Console.ReadLine());
            var prime = true;
            if (num <= 1)
            {
                prime = false;
                Console.WriteLine("The number is not prime");
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {

                if (num % i == 0)
                {
                    prime = false;
                    break;
                }

            }
            if (prime)
            {
                Console.WriteLine("The number is prime");
            }
            else
            {
                Console.WriteLine("The number is not a prime");
            }

            //zad3
            Console.WriteLine("Enter array:");
            string[] input = Console.ReadLine().Split(',');
            decimal result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                result = result + decimal.Parse(input[i]);
            }
            Console.WriteLine(result);

            //zad4
            Console.WriteLine("Enter array:");
            string[] euroInput = Console.ReadLine().Split(',');
            Console.WriteLine("Enter array:");
            string[] usdInput = Console.ReadLine().Split(',');

            decimal[] euroToLv = new decimal[euroInput.Length];
            decimal[] usdToLv = new decimal[usdInput.Length];

            for (int i = 0; i < euroInput.Length; i++)
            {
                euroToLv[i] = Decimal.Parse(euroInput[i]) * 1.95m;
            }
            for (int i = 0; i < usdInput.Length; i++)
            {
                usdToLv[i] = Decimal.Parse(usdInput[i]) * 1.8m;
            }
            bool areEqual = true;
            if (euroToLv.Length == usdToLv.Length)
            {
                for (int i = 0; i < euroToLv.Length; i++)
                {
                    if (euroToLv[i] != usdToLv[i])
                    {
                        areEqual = false;
                        break;
                    }
                }

            }
            else
            {
                areEqual = false;
            }

            Console.WriteLine("Are equal: " + areEqual);

            //zad5
            Console.WriteLine("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", year);
            }

            //zad6

            Console.WriteLine("Enter year:");
            int year1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month:");
            int month = int.Parse(Console.ReadLine());

            var isLeap=((year1 % 4 == 0 && year1 % 100 != 0) || year1 % 400 == 0) ? true : false;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31");break;
                case 2: Console.WriteLine(isLeap ? "29" : "28"); break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30");break;
            }





        }
    }
}
