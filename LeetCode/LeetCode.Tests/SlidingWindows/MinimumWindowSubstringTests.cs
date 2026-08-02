using LeetCode.SlidingWindows;

namespace Tests.SlidingWindows;

public class MinimumWindowSubstringTests
{
    public static IEnumerable<object[]> TestCases =>
        new List<object[]>
        {
            new object[] { "ADOBECODEBANC", "ABC", "BANC" },
            new object[] { "a", "a", "a" },
            new object[] { "a", "aa", "" },
            new object[] { "ab", "b", "b" },
            new object[] { "ab", "a", "a" },
            new object[] { "ab", "ab", "ab" },
            new object[] { "ab", "abc", "" },
            new object[] { "abc", "cba", "abc" },
            new object[] { "aa", "aa", "aa" },
            new object[] { "aaa", "aa", "aa" },
            new object[] { "aaflslflsldkalskaaa", "aaa", "aaa" },
            new object[] { "bba", "ab", "ba" },
            new object[] { "bdab", "ab", "ab" },
            new object[] { "cabwefgewcwaefgcf", "cae", "cwae" },
            new object[] { "acbbaca", "aba", "baca" },
            new object[] { "acbbaca", "aa", "aca" },
            new object[] { "aaabdabcefaecbef", "abc", "abc" },
            new object[] { "aaaaaaaaaaaabbbbbcdd", "abcdd", "abbbbbcdd" },
            new object[] { "abc", "d", "" },
            new object[] { "xyz", "xyz", "xyz" }
        };

    [Theory]
    [MemberData(nameof(TestCases))]
    public void SolveClassic_Should_Work_Correctly(string s, string t, string expected)
    {
        var solution = new MinimumWindowSubstring();

        var actual = solution.SolveClassic(s, t);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [MemberData(nameof(TestCases))]
    public void SolveMyOwn_Should_Work_Correctly(string s, string t, string expected)
    {
        var solution = new MinimumWindowSubstring();

        var actual = solution.SolveMyOwn(s, t);

        Assert.Equal(expected, actual);
    }
}