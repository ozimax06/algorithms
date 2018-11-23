using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class Binary
    {

        /*
        157 = 10011101 --->5
        --------------
        157 ÷ 2 = 78 with a remainder of 1
        78 ÷ 2 = 39 0
        39 ÷ 2 = 19 1
        19 ÷ 2 = 9 1
        9 ÷ 2 = 4 1
        4 ÷ 2 = 2 0
        2 ÷ 2 = 1 0
        1 ÷ 2 = 0 1 to convert write this remainder first.
        */

        public static int GetNumberOfOnesInBinary(int n)
        {
            int result = 0;
            LinkedList<int> binaryDigits = new LinkedList<int>();

            while(n/2 != 0)
            {
                var binaryDigit = n % 2;
                binaryDigits.AddLast(binaryDigit);
                n = n / 2;
            }
            binaryDigits.AddLast(1);

            foreach(var i in binaryDigits)
            {
                if (i == 1)
                    result++;
            }

            return result;
        }
    }
}
