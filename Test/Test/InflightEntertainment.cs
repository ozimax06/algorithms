using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class InflightEntertainment
    {
        /*
         Write a method that takes an integer flightLength (in minutes) and 
         an array of integers movieLengths (in minutes) and returns a boolean 
         indicating whether there are two numbers in movieLengths whose sum equals flightLength. 
         */
         public static List<Tuple<int, int>> GetMovies(int[] movies, int flightTime)
         {
            var result = new List<Tuple<int, int>>();

            for(int i=0; i<movies.Count()-1; i++)
            {
                for(int j=i+1; j<movies.Count(); j++)
                {
                    if (movies[i] + movies[j] == flightTime)
                        result.Add(new Tuple<int, int>(movies[i], movies[j]));
                }

            }

            return result;


        }


    }
}
