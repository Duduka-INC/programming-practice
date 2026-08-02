using LeetCode.LinkedLists;
using Xunit;

namespace Tests.LinkedList;

public class AddTwoNumbersTests
{
    public static IEnumerable<object[]> TestCases =>
        new List<object[]>
        {
            new  object[] { new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4))), new ListNode(7,  new ListNode(0, new ListNode(8))) },
            new object[] { new ListNode(1, new ListNode(2)), new ListNode(2, new ListNode(3)), new ListNode(3, new ListNode(5)) },
        };

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Solve_ReturnsExpected(ListNode l1, ListNode l2, ListNode expected)
    {
        var task = new AddTwoNumbersNew();

        var result = task.Solve(l1, l2);

        Assert.Equal(expected, result);
    }
}