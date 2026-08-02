using System.Text;
using LeetCode.Concurrency;
using Xunit;

namespace Tests.Concurrency;

public class PrintZeroEvenOddTests
{
    public static IEnumerable<object[]> TestCases
    {
        get
        {
            for (int i = 0; i < 100; i++)
            {
                yield return new object[]
                {
                    i,
                    BuildString(i)
                };
            }
        }
    }

    private static string BuildString(int i)
    {
        {
            var stringResult = new StringBuilder();
            for (int n = 1; n <= i; n++)
            {
                stringResult.Append($"0{n}");
            }
            return stringResult.ToString();
        }
    }

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Should_Work_Correctly(int n, string expected)
    {
        var solution = new ZeroEvenOdd(n);
        var result = new StringBuilder();
        var sync = new object();

        void Add(int s)
        {
            lock (sync)
            {
                result.Append(s);
            }
        }

        var t1 = new Thread(() => solution.Zero((n) => Add(n)));
        var t2 = new Thread(() => solution.Even((n) => Add(n)));
        var t3 = new Thread(() => solution.Odd((n) => Add(n)));
        
        t1.Start();
        t2.Start();
        t3.Start();
        
        t1.Join();
        t2.Join();
        t3.Join();

        Assert.Equal(expected, result.ToString());
    }
}