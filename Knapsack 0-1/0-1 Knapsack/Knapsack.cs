using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    static class Knapsack
    {
       public static int[,] GetValueTable(int[] values, int[] weights, int maxWeight)
        {
            int[,] v = new int[values.Count() + 1, maxWeight+1];

            for (int i = 1; i < v.GetLength(0); i++)
            {
                for (int w = 1; w < v.GetLength(1); w++)
                {
                    //since all v[0, w] values and all v[i, 0] values are equal to 0.
                    //we are starting from v[1,1].
                    //index i,w on v[i,w] represent i-1 and w-1 respectively.

                    if (weights[i - 1] > w)
                        v[i, w] = v[i - 1, w];
                    else if (weights[i - 1] <= w)
                        v[i, w] = Math.Max(v[i - 1, w], values[i - 1] + v[i - 1, w - weights[i - 1]]);
                }
            }

            return v;
        }

        public static List<int> GetItemsWithMaxValue(int[] weights, int[] values, int max_weight)
        {
            if (weights.Count() != values.Count())
                return null;

            var v = GetValueTable(values, weights, max_weight);
            var results = new List<int>();
            int i = v.GetLength(0) - 1;
            int w = v.GetLength(1) - 1;
            //int w = max_weight;

            while (i > 0 && w > 0)
            {
                if (v[i, w] != v[i - 1, w])
                {
                    results.Add(i - 1);
                    w = w - weights[i - 1];
                    i = i - 1;
                }
                else
                {
                    i = i - 1;
                }
            }

            return results;
        }


        /*
            public static int[,] GetValueTable(int[] values, int[] weights, int maxWeight)
        {
            int[,] v = new int[values.Count() + 1, maxWeight+1];

            for (int i = 1; i < v.GetLength(0); i++)
            {
                for (int w = 1; w < v.GetLength(1); w++)
                {

                    //since all v[0, w] values and all v[i, 0] values are equal to 0.
                    //we are starting from v[1,1].
                    //index i,w on v[i,w] represent i-1 and w-1 respectively.

                    var t = 0;

                    if (weights[i - 1] > w)
                    {
                        t = v[i - 1, w]; ;
                        v[i, w] = t;
                    }
                    else if (weights[i - 1] <= w)
                    {
                        t = Math.Max(v[i - 1, w], values[i - 1] + v[i - 1, w - weights[i - 1]]);
                        v[i, w] = t;
                    }

                }
            }

            return v;
        }

        public static List<int> GetItemsWithMaxValue(int[] weights, int[] values, int max_weight)
        {
            var v = GetValueTable(values, weights, max_weight);
            var results = new List<int>();
            int i = v.GetLength(0) - 1;
            int w = v.GetLength(1) - 1;
            //int w = max_weight;

            while (i > 0 && w > 0)
            {
                if (v[i, w] != v[i - 1, w])
                {
                    results.Add(i - 1);
                    w = w - weights[i - 1];
                    i = i - 1;
                }
                else
                {
                    i = i - 1;
                }
            }

            return results;
        }
         
         */

    }
}
