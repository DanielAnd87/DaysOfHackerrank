using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfHackerrank
{
    class Program
    {

        static long L = 2000000;
        static bool[] notPrime = new bool[L];

        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

            findPrimes(2);

            notPrime[0] = true;
            notPrime[1] = true;
            //notPrime[2] = true;
            for (int i = 3; i < 200; i += 2)
            {
                for (int j = 1; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {
                        continue;
                    };
                }
                //notPrime[i] = false;
                findPrimes(i);
            }

            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int response = Convert.ToInt32(Console.ReadLine());
                string text = "";
                long now = DateTime.Now.Millisecond;
                text = notPrime[response] ? "Not prime" : "Prime";
                
                Console.WriteLine(text);
                long past = DateTime.Now.Millisecond;
                Console.WriteLine(past-now);
                past = DateTime.Now.Millisecond;

                text = !IsPrime(response) ? "Not prime" : "Prime";
                now = DateTime.Now.Millisecond;

                Console.WriteLine(text);
                Console.WriteLine(now-past);
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }


        static void findPrimes(int adding)
        {

            for (long b = adding * 2; b < L; b += adding)
            {
                notPrime[b] = true;
            }
        }
    }
    }
