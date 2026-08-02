namespace LeetCode.BinarySearch;

public class SearchInsertPosition
{
    public int Solve(int[] nums, int target)
    {
        var max = nums.Length - 1;
        var min = 0;

        var idx = 0;
        
        while (min < max) 
        {
            idx = CalcBinaryPointer(min, max);

            var guess = nums[idx];
            
            if (guess == target)
            {
                return idx;
            }
            
            if (guess > target)
            {
                max = idx - 1;
            }
            else
            {
                min = idx + 1;
            }
        }

        return min;
    }
    
    public int CalcBinaryPointer(int min, int max)
    {
        return min + (max - min) / 2;
    }
}