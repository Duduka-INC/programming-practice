namespace LeetCode.SlidingWindows;

/*
    76. Минимальная подстрока (Minimum Window Substring)
    Даны две строки s и t длиной m и n соответственно.
    Нужно вернуть минимальную подстроку строки s, такую что все символы строки t (включая повторяющиеся) содержатся в этой подстроке.
    Если такой подстроки не существует — вернуть пустую строку "".

    Гарантируется, что тесты составлены так, что ответ единственны
    Примеры
    Пример 1:
    Вход:  s = "ADOBECODEBANC", t = "ABC"
    Выход: "BANC"
    Пояснение:
    Подстрока "BANC" содержит все символы 'A', 'B' и 'C' из строки t.

    Пример 2:
    Вход:  s = "a", t = "a"
    Выход: "a"
    Пояснение:
    Вся строка s и есть минимальное окно.

    Пример 3:
    Вход:  s = "a", t = "aa"
    Выход: ""
    Пояснение:
    В t требуется два символа 'a', но в s есть только один → невозможно.

    Ключевой момент (важно понять)
    Нужно учитывать количество символов, а не просто их наличие
    ("AABC" ≠ "ABC")
    Ищем самую короткую подстроку
    Подстрока — это непрерывный отрезок, не подпоследовательность
*/
public class MinimumWindowSubstring
{
    public string SolveClassic(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || t.Length > s.Length)
            return "";

        var need = new Dictionary<char, int>();
        foreach (var c in t)
        {
            if (!need.ContainsKey(c))
                need[c] = 0;
            need[c]++;
        }

        var window = new Dictionary<char, int>();

        int required = need.Count;
        int formed = 0;

        int left = 0;
        int bestStart = 0;
        int bestLen = int.MaxValue;

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];

            if (need.ContainsKey(c))
            {
                if (!window.ContainsKey(c))
                    window[c] = 0;

                window[c]++;

                if (window[c] == need[c])
                    formed++;
            }

            while (formed == required)
            {
                int len = right - left + 1;
                if (len < bestLen)
                {
                    bestLen = len;
                    bestStart = left;
                }

                char leftChar = s[left];

                if (need.ContainsKey(leftChar))
                {
                    window[leftChar]--;

                    if (window[leftChar] < need[leftChar])
                        formed--;
                }

                left++;
            }
        }

        return bestLen == int.MaxValue ? "" : s.Substring(bestStart, bestLen);
    }
    
    public string SolveMyOwn(string s, string t)
    {
        var leftIndx = 0;
        var rightIndx = 0;
        
        var window = new Dictionary<char, int>();
        var counter = new Dictionary<char,int[]>();
        var startRes = 0;
        var lengthRes = Int32.MaxValue;
        
        foreach (var c in t)
        {
            if (counter.ContainsKey(c))
            {
                counter[c][0]++;
            }
            else
            {
                counter[c] = new  int[] {1, 0};
            }
        }
        
        while ((rightIndx < s.Length &&  leftIndx < s.Length) || counter.All(a => a.Value[1] >= a.Value[0]))
        {
            if (counter.All(a => a.Value[1] >= a.Value[0]))
            {
                while (counter.All(a => a.Value[1] >= a.Value[0]))
                {
                    if (lengthRes > rightIndx - leftIndx)
                    {
                        startRes = leftIndx;
                        lengthRes = rightIndx - leftIndx;
                    }

                    if (counter.Keys.Contains(s[leftIndx]))
                    {
                        counter[s[leftIndx]][1]--;
                    }
                    
                    leftIndx++;
                }

            }
            else
            {
                window[s[rightIndx]] = s[rightIndx];

                if (counter.Keys.Contains(s[rightIndx]))
                {
                    counter[s[rightIndx]][1]++;
                }
                
                rightIndx++;
            }
        }

        if (lengthRes > s.Length)
        {
            return "";
        }
        else
        {
            return  s.Substring(startRes, lengthRes);
        }
    }
}