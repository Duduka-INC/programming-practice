namespace LeetCode.Stack;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        var mapping = new Dictionary<char, char>()
        {
            { '}', '{' },
            { ']', '[' },
            { ')', '(' }
        };

        var stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            var ch = s[i];

            if (mapping.ContainsValue(ch))
            {
                stack.Push(ch);
            }
            else
            {
                if (stack.Count > 0 && stack.Peek() == mapping[ch])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }
        
        return stack.Count == 0;
    }
}