using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /*
      Write a method that, given a sentence like the one above, along with the position of an opening parenthesis,
      finds the corresponding closing parenthesis.
     */
    public static class ParanthesisMatcher
    {
        public static int GetClosingParanthesisIndex(String str, int index)
        {
            Stack<char> s = new Stack<char>();

            if(str[index] != '(')
            {
                return -1;
            }
            else
            {
                s.Push('(');
            }

            for(int i= index+1; i < str.Count(); i++)
            {
                if (str[i] == '(')
                {
                    s.Push('(');
                }
                else if(str[i] == ')')
                {
                    s.Pop();
                    if (s.Count() == 0)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
