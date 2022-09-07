using System;

public class ContainsDuplicate
{
	

		//Given an array of integers, find if the array contains any duplicates.
		//Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.

		public bool checkArray(int[] array)
        {
			if( array.Length < 2)
            {
				return false;
            }
			var hash = new HashSet<int>();

			for(int i=0; i < array.Length; i++)
            {
				if(hash.Contains(array[i]))
                {
					return true;
                }
                else
                {
					hash.Add(array[i]);
				}

            }
			return false;

		}


	public bool ContainsDuplicate2(int[] nums)
	{
		Array.Sort(nums);
		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] == nums[i + 1])
			{
				return true;
			}
		}
		return false;
	}
	// O(n)
	//
	//https://leetcode.com/problems/first-unique-character-in-a-string/
	//Given a string, find the first non-repeating character in it and return its index.If it doesn't exist, return -1.

	//check 

	//https://leetcode.com/problems/first-unique-character-in-a-string/
	//Given a string, find the first non-repeating character in it and return its index.If it doesn't exist, return -1.
	// O(1)

	//Given two strings, write a method to decide if one is a permutation
	//of the other.

	//Two strings that are permutations should have the same characters
	//but in different orders.
	//1.2, 1.4 CTCI



}
