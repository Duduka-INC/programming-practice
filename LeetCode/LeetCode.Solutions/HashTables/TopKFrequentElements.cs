namespace LeetCode.HashTables;

public class TopKFrequentElements
{
    public int[] Solve(int[] nums, int k)
    {
        var count = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (count.ContainsKey(num))
            {
                count[num]++;
            }
            else
            {
                count[num] = 1;
            }
        }

        var orderedEnumerable = count.OrderByDescending(kvp => kvp.Value);
        
        var result = new int[k];

        foreach (var kvp in orderedEnumerable)
        {
            if (k > 0)
            {
                result[k - 1] = kvp.Key;
                k--;
            }
            else
            {
                break;
            }
        }
        
        return result;
    }

    public int[] SolveShit(int[] nums, int k)
    {
        var count = new int[2000];

        foreach (int num in nums)
        {
            count[num]++;
        }

        var result = new int[k];
        while (k > 0)
        {
            var index = Array.IndexOf(count, count.Max());
            result[k - 1] =  index;
            count[index] = 0;
            k--;
        }
        
        return result;
    }
}