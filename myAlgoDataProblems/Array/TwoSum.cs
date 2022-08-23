using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAlgoDataProblems.Array
{
    public class TwoSum
    {

        /*
        Test code to test in program class
        

        using MyAlgoDataProblems.Array;

            int[] array = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum twoSum = new TwoSum();
            int[] answer = twoSum.TwoSumProblem(array, target);

            Console.WriteLine(answer);



         */


        public int[] TwoSumProblem(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int index = i + 1; index < nums.Length; index++)
                {
                    if (target - nums[i] == nums[index])
                    {
                        int[] result = { i, index };
                        return result;
                    }
                }

            }
            return null;
        }


        // arr =  [2, 7, 11, 15 ]
        //target = 9
        public int[] TwoSum_1(int[] nums, int target)
        {
            var map = new Dictionary<int, int>(); //key, second value
            //{2,0},
            //{7,1},
            //{11,2}
            //{15,3}

            for (int i = 0; i < nums.Length; i++)
            {
                var compliment = target - nums[i];

                if (map.ContainsKey(compliment))
                {
                    return new int[] { map[compliment], i };
                    //[] give me the value of this key
                }

                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }

            }
            return null;
        }

    }
}
