using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class IsomorphicStrings
    {
        /*
          Given two strings s and t, determine if they are isomorphic. 
          Two strings are isomorphic if the characters in s can be replaced to get t.
          For example,"egg" and "add" are isomorphic, "foo" and "bar" are not.
         */
        public static bool IsIsomorphic(string str1, string str2)
        {
            var result = true;

            Dictionary<char, char> map = new Dictionary<char, char>();

            if (str1.Count() != str2.Count())
                return false;

            for(int i=0; i< str1.Count(); i++)
            {
                if (!map.ContainsKey(str1[i]))
                {
                    map.Add(str1[i], str2[i]);
                }
                else
                {
                    var ch = ' ';
                    map.TryGetValue(str1[i], out ch);
                    if(ch != str2[i])
                    {
                        result = false;
                    }

                }
            }


            return result;
        }
    }
}
