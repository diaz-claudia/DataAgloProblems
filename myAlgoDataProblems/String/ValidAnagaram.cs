using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAlgoDataProblems.String
{
    public class ValidAnagaram
    {
      
        public bool IsAnagram(string s, string t)
        {
            // case: for if they are not the same length = false 
            if (s.Length != t.Length)
            { return false; }

            char[] str = s.ToCharArray();
            char[] test = t.ToCharArray();
           // Array.Sort(str);
            //Array.Sort(test);

            return Enumerable.SequenceEqual(str, test);


            // sort them 
            // check if they are equal 
            // true if they are 
            // return false if not 
        }
    }
}
