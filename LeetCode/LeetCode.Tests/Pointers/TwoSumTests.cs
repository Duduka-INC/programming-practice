using System.Collections.Generic;
using LeetCode.Pointers;
using Xunit;

namespace Tests.Pointers;

public class TwoSumTests
{
    public static IEnumerable<object[]> TestCases =>
        new List<object[]>
        {
            new object[] { new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 } },
            new object[] { new[] { 3, 2, 4 }, 6, new[] { 1, 2 } },
            new object[] { new[] { 3, 3 }, 6, new[] { 0, 1 } }
        };

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Solve_ReturnsExpected(int[] nums, int target, int[] expected)
    {
        var task = new TwoSum();

        var result = task.Solve(nums, target);

        Assert.Equal(expected, result);
    }
}