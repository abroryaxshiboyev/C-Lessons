using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HashSet
{
    public class Solution
    {
        public bool ContainsDublicate(int[] nums)
        {
            HashSet<int> set = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    set.Add(nums[i]);
                }
            }
            return false;
        }
    }
}