using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var fibz = new Program();
            var n = 30;

            fibz.FizzBuzz(n);
            fibz.FizzBuzzLinQ(n);
        }

        public IList<string> FizzBuzzLinQ(int n)
        {
            if (n < 1 && 10000 < n) return null;

            var FizzBuzzList = Enumerable.Range(1, n).Select(i =>
                                                                 (i % 15 == 0) ? "FizzBuzz" :
                                                                 (i % 3 == 0) ? "Fizz" :
                                                                 (i % 5 == 0) ? "Buzz" :
                                                                 i.ToString());
            var rtn = FizzBuzzList.ToList();
            return rtn;
        }

        public IList<string> FizzBuzz(int n)
        {
            if (n < 1 && 10000 < n) return null;

            var rtn = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                {
                    rtn.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    rtn.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    rtn.Add("Buzz");
                }
                else
                {
                    rtn.Add(i.ToString());
                }
            }
            return rtn;
        }
    }
}
