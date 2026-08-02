using LeetCode.ExpandCenter;

namespace Tests.ExpandCenter;

public class LongestPalindromicSubstringTests
{
    public static IEnumerable<object[]> ExactCases =>
        new List<object[]>
        {
            new object[] { "a", "a" },
            new object[] { "aa", "aa" },
            new object[] { "aba", "aba" },
            new object[] { "abba", "abba" },
            new object[] { "cbbd", "bb" },
            new object[] { "aaaa", "aaaa" },
            new object[] { "bananas", "anana" },
            new object[] { "forgeeksskeegfor", "geeksskeeg" },
            new object[] { "abaxyzzyxf", "xyzzyx" }
        };

    public static IEnumerable<object[]> MultipleValidCases =>
        new List<object[]>
        {
            new object[] { "babad", new[] { "bab", "aba" } },
            new object[] { "ab", new[] { "a", "b" } },
            new object[] { "abcd", new[] { "a", "b", "c", "d" } }
        };

    [Theory]
    [MemberData(nameof(ExactCases))]
    public void Should_Return_Exact_Palindrome(string input, string expected)
    {
        var solution = new LongestPalindromicSubstring();

        var result = solution.Solve(input);

        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(MultipleValidCases))]
    public void Should_Return_One_Of_Valid_Palindromes(string input, string[] expected)
    {
        var solution = new LongestPalindromicSubstring();

        var result = solution.Solve(input);

        Assert.Contains(result, expected);
    }
}