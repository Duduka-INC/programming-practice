namespace LeetCode.SlidingWindows;

public class PermutationInString
{
    public bool Solve(string s1, string s2)
    {
        var leftIndx = 0;

        var formed = 0;
        var required = 0;

        var charDict = new Dictionary<char, int[]>();
        var window = new Dictionary<int, char>();

        foreach (var c in s1)
        {
            if (charDict.ContainsKey(c))
            {
                charDict[c][0]++;
            }
            else
            {
                charDict[c] = new int[] {1, 0};
            }
        }
        
        required = charDict.Values.Select(s => s[0]).Sum();

        if (s1.Length > s2.Length)
        {
            return false;
        }

        for (int right = 0; right < s2.Length; right++)
        {
            var c =  s2[right];
            window[right] = c;

            if (charDict.ContainsKey(window[right]))
            {
                charDict[window[right]][1]++;
            }
            
            if (right - leftIndx + 1 == s1.Length)
            {
                for (int n = leftIndx; n < right + 1; n++)
                {
                    if (charDict.ContainsKey(window[n]))
                    {
                        if (charDict[window[n]][1] > charDict[window[n]][0])
                        {
                            formed = 0;
                            break;
                        }
                        
                        formed++;
                    }
                    else
                    {
                        formed = 0;
                        break;
                    }
                }
            }
            
            while (right - leftIndx + 2 > s1.Length)
            {
                if (charDict.ContainsKey(window[leftIndx]))
                {
                    charDict[window[leftIndx]][1]--;
                }
                window.Remove(leftIndx);
                leftIndx++;
            }

            if (formed == required)
            {
                return true;
            }
            
        }

        return false;
    }
}