namespace LeetCode.HashTables;

public class ValidAnagram
{
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