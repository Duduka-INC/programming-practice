using System.Text;

namespace LeetCode.ExpandCenter;

public class LongestPalindromicSubstring
{
    public string Solve(string s)
    {
        var result = "";
        for (int i = 0; i < s.Length; i++)
        {
            var evenVal = Expand(i, i, s);
            var oddVal = Expand(i, i + 1, s);

            if (int.Max(evenVal.Length, oddVal.Length) > result.Length)
            {
                if (evenVal.Length > oddVal.Length)
                {
                    result = evenVal;
                }
                else
                {
                    result = oddVal;
                }
            }
        }

        return result;
    }

    public string Expand(int leftInd, int rightInd, string s)
    {
        while (leftInd >= 0 && rightInd < s.Length)
        {
            if (s[leftInd] != s[rightInd])
            {
                break;
            }
            else
            {
                leftInd--;
                rightInd++;
            }
        }

        leftInd++;
        rightInd--;
        
        return s.Substring(leftInd, rightInd - leftInd + 1);
    }
}