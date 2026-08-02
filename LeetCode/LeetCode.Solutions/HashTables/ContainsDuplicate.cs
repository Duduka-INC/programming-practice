namespace LeetCode.HashTables;

public class ContainsDuplicate
{
    public bool Solve(int[] nums)
    {
        var counts = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (counts.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                counts.Add(nums[i]);
            }
        }

        return false;
    }

    public bool SolveMyOwn(int[] nums)
    {
        Array.Sort(nums);
        
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                return true;
            }
        }

        return false;
    }
}