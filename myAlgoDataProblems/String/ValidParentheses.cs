using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAlgoDataProblems.String
{
    public class ValidParentheses
    {
        //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        public string opening = "{([";
        public string closing = "})]";
        public bool isValid(string s)
        {

  //          {}

            var closingStack = new Stack<char>();
            //[]

            for (int i = 0; i < s.Length; i++)
            {
                if (opening.Contains(s[i])) { 
                    closingStack.Push(closing[opening.IndexOf(s[i])]);
                
                }

                else if (closingStack.Count == 0 || closingStack.Pop() != s[i])
                {
                    return false;
                }
                Console.WriteLine(closingStack);
            }
            Console.WriteLine(closingStack);
            return closingStack.Count == 0;
        }

        //space = O(n) 
        //memory  = O(n)

    }
}
