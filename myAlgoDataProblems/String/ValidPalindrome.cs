using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAlgoDataProblems.String
{
    public class ValidPalindrome
    {

        public bool IsPalindrome(string s)
        {


            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                while (i < j && !Char.IsLetterOrDigit(s[i]))
                {
                    Console.WriteLine(Char.IsLetterOrDigit(s[i]));
                    Console.WriteLine(i);
                    // this checking for characters that are spaces, commas,etc, and if they are just increment the index and keep checkin g
                    i++;
                }

                while (i < j && !Char.IsLetterOrDigit(s[j]))
                { j--; }

                // here is where the checking is done with valid indexes meaning index that are filtered to not be spaces, commas,etc. 
                if (Char.ToLower(s[i]) != Char.ToLower(s[j]))
                { return false; }


            }

            return true;
        }
    }
}
