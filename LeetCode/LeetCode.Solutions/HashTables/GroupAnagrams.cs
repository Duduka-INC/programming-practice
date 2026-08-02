namespace LeetCode.HashTables;

public class GroupAnagrams
{
    public List<List<string>> Solve(string[] strs) {
        
        var result = new List<List<string>>();
        foreach (var str in strs)
        {
            bool inGroup = false;
            foreach (List<string> group in result)
            {
                if (IsAnagram(str, group[0]))
                {
                    group.Add(str);
                    inGroup =  true;
                    break;
                }
            }

            if (!inGroup)
            {
                result.Add(new List<string> { str });
            }
        }
        
        return result;
    }
    
    public List<List<string>> SolveClassic(string[] strs) {
        var res = new Dictionary<string, List<string>>();
        foreach (var s in strs) {
            int[] count = new int[26];
            foreach (char c in s) {
                count[c - 'a']++;
            }
            string key = string.Join(",", count);
            if (!res.ContainsKey(key)) {
                res[key] = new List<string>();
            }
            res[key].Add(s);
        }
        return res.Values.ToList<List<string>>();
    }
    
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        
        var frecuencyArr = new int[26];

        for (int i = 0; i < t.Length; i++)
        {
            frecuencyArr[t[i] - 'a']++;
            frecuencyArr[s[i] - 'a']--;
        }

        foreach (int num in frecuencyArr)
        {
            if (num != 0)
                return false;
        }

        return true;
    }
    
    
}