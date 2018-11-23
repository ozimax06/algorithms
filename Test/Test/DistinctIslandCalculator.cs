using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /*
     Given a 2D array of ints, where '1's represent land and '0's represent water on a map, 
     determine how many distinct islands it has (two horizontally or vertically neighboring cells
     belong to the same island).  
     */
    public static class DistinctIslandCalculator
    {

        public static int GetTotalDistinctIslands(int[,] arr)
        {
            int sum = 0;

            for(int i=0;i < arr.GetLength(0); i++)
            {
                for(int j=0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 1)
                    {
                        var distinct = true;

                        if (j + 1 < arr.GetLength(1) - 1)
                        {
                            if (arr[i, j + 1] != 0)
                            {
                                distinct = false;
                                continue;
                            }
                        }
                        if (j - 1 > 0)
                        {
                            if (arr[i, j - 1] != 0)
                            {
                                distinct = false;
                                continue;
                            }
                        }
                        if (i + 1 < arr.GetLength(0) - 1)
                        {
                            if (arr[i + 1, j] != 0)
                            {
                                distinct = false;
                                continue;
                            }
                        }
                        if (i - 1 > 0)
                        {
                            if (arr[i - 1, j] != 0)
                            {
                                distinct = false;
                                continue;
                            }
                        }

                        if (distinct)
                            sum++;
                    }
                   

                }
            }


            

            return sum;
        }
    }
}
