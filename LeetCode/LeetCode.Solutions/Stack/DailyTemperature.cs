namespace LeetCode.Stack;

public class DailyTemperature
{
    public int[] DailyTemperatures(int[] temperatures) {
        var n = temperatures.Length;
        var stack = new Stack<int>();
        
        var result = new int[n];
        for (int i = n - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && temperatures[stack.Peek()] <= temperatures[i])
            {
                stack.Pop();
            }

            result[i] = stack.Count == 0 ? 0 : stack.Peek() - i;

            stack.Push(i);
        }
        
        return  result;
    }
}