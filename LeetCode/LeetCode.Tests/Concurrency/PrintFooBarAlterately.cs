using System.Text;
using LeetCode.Concurrency;
using Xunit;

namespace Tests.Concurrency;

public class PrintFooBarAlterately
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
                    string.Concat(Enumerable.Repeat("foobar", i))
                };
            }
        }
    }

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Should_Work_Correctly(int n, string expected)
    {
        var solution = new FooBar(n);
        var result = new StringBuilder(n * 6);
        var sync = new object();

        void Add(string s)
        {
            lock (sync)
            {
                result.Append(s);
            }
        }

        var t1 = new Thread(() => solution.Foo(() => Add("foo")));
        var t2 = new Thread(() => solution.Bar(() => Add("bar")));

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Assert.Equal(expected, result.ToString());
    }
}