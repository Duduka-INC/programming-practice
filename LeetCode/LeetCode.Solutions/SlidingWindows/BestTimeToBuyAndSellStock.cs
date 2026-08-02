namespace LeetCode.SlidingWindows;

public class BestTimeToBuyAndSellStock
{
    public int Solve(int[] prices)
    {
        var left = 0;
        var max = 0;

        for (int right = 0; right < prices.Length; right++)
        {
            if (prices[right] > prices[left])
            {
                var sum = prices[right] - prices[left];
                if (sum > max)
                {
                    max = sum;
                }
            }
            
            while (prices[right] < prices[left])
                left++;
        }

        return max;
    }
}