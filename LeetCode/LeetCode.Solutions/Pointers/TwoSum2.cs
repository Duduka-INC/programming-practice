namespace LeetCode.Pointers;

public class TwoSum2
{
    public int[] Solve(int[] nums, int target)
    {
        var rightP = nums.Length - 1;
        var leftP = 0;

        while (leftP < rightP)
        {
            var sum =  nums[leftP] + nums[rightP];
            
            if (sum == target)
            {
                return  new[] { leftP + 1, rightP + 1 };
            }
            
            if (sum > target)
            {
                rightP--;
            }
            else
            {
                leftP++;
            }
        }

        return  new[] { leftP, rightP };
    }
}