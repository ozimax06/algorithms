using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class BBB
    {
        /*
         * var list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

        exp: list 1,2,3,4,5
        n=1 --> output = 4
        n=3 --> output = 2 
        */
        public static int getLastElement(LinkedList<int> list, int n)
        {
            var result = -1;

            LinkedListNode<int> lastItem = list.Last;

            for(int i=0; i<n; i++)
            {
                lastItem = lastItem.Previous;
            }

            result = lastItem.Value;


            return result;
        }


        /*
         determine minimum number of coins required to make the exact amoun of change
         assume that coins are [1,5,10,25] in order so for exp 23 reurns 5
         10, 10, 1,1,1
         */

        public static int Change(int x, int[] coins)
        {
            int numberOfChanges = 0;

            for(int i=coins.Count()-1; i>=0; i--)
            {
                if(x >= coins[i])
                {
                    numberOfChanges = numberOfChanges += (x / coins[i]);
                    x = x % coins[i];
                }
            }

            return numberOfChanges;
        }

        public static int ChangeRecursion(int x, int[] coins)
        {
            int numberOfChanges = 0;

            for (int i = coins.Count() - 1; i >= 0; i--)
            {
                if (x >= coins[i])
                {
                    numberOfChanges = numberOfChanges += (x / coins[i]);
                    x = x % coins[i];
                }
            }

            return numberOfChanges;
        }


    }
}



