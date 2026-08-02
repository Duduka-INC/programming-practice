using System.Text;
using LeetCode.Concurrency;
using Xunit;

namespace Tests.Concurrency;

public class PrintInOrderTests
{
    [Fact]
    public void Should_Print_In_Order()
    {
        var foo = new Foo();
        var result = new StringBuilder();
        var sync = new object();

        void Add(string s)
        {
            lock (sync)
            {
                result.Append(s);
            }
        }

        var t2 = new Thread(() => foo.Second(() => Add("second")));
        var t3 = new Thread(() => foo.Third(() => Add("third")));
        var t1 = new Thread(() => foo.First(() => Add("first")));

        t2.Start();
        t3.Start();
        t1.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Assert.Equal("firstsecondthird", result.ToString());
    }
}