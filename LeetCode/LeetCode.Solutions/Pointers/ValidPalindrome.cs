using System.Text;

namespace LeetCode.Pointers;

public class ValidPalindrome
{
    public bool Solve(string s)
    {
        var stringBuilder = new StringBuilder(s.Length);
        s = s.ToLower();
        
        foreach (var c in s)
        {
            if ((c >= 'a' && c <= 'z') || (c >= '0' &&  c <= '9'))
            {
                stringBuilder.Append(c);
            }
        }
        string newStr = stringBuilder.ToString();

        if (newStr.Length == 0)
        {
            return true;
        }
        
        var left = 0;
        var right = newStr.Length - 1;
        
        while (left <= right)
        {
            if (left == right)
            {
                return true;
            }

            if ((right - left == 1 && newStr.Length % 2 == 0) && newStr[left] == newStr[right])
            {
                return true;
            }
            
            if (newStr[left] != newStr[right])
            {
                return false;
            }
            else
            {
                left++;
                right--;
            }
        }

        return false;
    }
}