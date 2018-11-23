using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class LongestConsecutive
    {
        /*Given an unsorted array of integers, find the length
         *of the longest consecutive elements sequence*/

        public static int GetLongestConsecutive(int[] arr)
        {
            var maxCount = 0;

            for(int i=0; i < arr.Count()-1; i++)
            {
               

                if(arr[i] < arr[i + 1])
                {
                    var count = 0;

                    while(i < arr.Count()-1 && arr[i] < arr[i + 1])
                    {
                        count++;
                        i++;
                    }

                    if (maxCount < count)
                        maxCount = count;                   
                }              
            }
            return maxCount;
        }
    }
}
