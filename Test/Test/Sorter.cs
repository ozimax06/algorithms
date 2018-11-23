using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class Sorter
    {
        //O(n^2)
        public static int[] BasicSort(int[] arr)
        {
            for(int i=0; i<arr.Count(); i++)
            {
                var min = arr[i];
                int j =0;

                for(j = i+1; j<arr.Count(); j++)
                {
                    if (arr[j] < min)
                        min = arr[j];

                    if (min < arr[i])
                    {
                        var temp = arr[i];
                        arr[i] = min;
                        arr[j] = temp;
                    }
                }
                
              
            }
            return arr;
        }

        //Buble Sort
        /*
         First Pass:
            ( 5 1 4 2 8 ) –> ( 1 5 4 2 8 ), Here, algorithm compares the first two elements, and swaps since 5 > 1.
            ( 1 5 4 2 8 ) –>  ( 1 4 5 2 8 ), Swap since 5 > 4
            ( 1 4 5 2 8 ) –>  ( 1 4 2 5 8 ), Swap since 5 > 2
            ( 1 4 2 5 8 ) –> ( 1 4 2 5 8 ), Now, since these elements are already in order (8 > 5), algorithm does not swap them.

            Second Pass:
            ( 1 4 2 5 8 ) –> ( 1 4 2 5 8 )
            ( 1 4 2 5 8 ) –> ( 1 2 4 5 8 ), Swap since 4 > 2
            ( 1 2 4 5 8 ) –> ( 1 2 4 5 8 )
            ( 1 2 4 5 8 ) –>  ( 1 2 4 5 8 )
            Now, the array is already sorted, but our algorithm does not know if it is completed. The algorithm needs one whole pass without any swap to know it is sorted.

            Third Pass:
            ( 1 2 4 5 8 ) –> ( 1 2 4 5 8 )
            ( 1 2 4 5 8 ) –> ( 1 2 4 5 8 )
            ( 1 2 4 5 8 ) –> ( 1 2 4 5 8 )
            ( 1 2 4 5 8 ) –> ( 1 2 4 5 8 )
         */

        public static int[] BubleSort(int[] arr)
        {
            bool swapped = true;

            while (swapped)
            {
                swapped = false;
                for(int i=0; i<arr.Count()-1; i++)
                {
                    if(arr[i] > arr[i + 1])
                    {
                        //swap elements and mark swapped true
                        var temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }
            }
            return arr;
        }




    }


}
