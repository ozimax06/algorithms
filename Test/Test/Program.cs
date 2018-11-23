using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
      
        int sum = 0;
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            Console.Write(a==2?a:b==a+1?b:0);

           
          

          

            Console.ReadLine();


        }

        public static int Fib(int n)
        {
            // Edge case
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n),
                    "Index was negative. No such thing as a negative index in a series.");
            }

            // Base cases
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            return  Fib(n - 1) + Fib(n - 2)+1;
        }
    }
}
                                