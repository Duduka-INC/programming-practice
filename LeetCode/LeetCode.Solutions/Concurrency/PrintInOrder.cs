namespace LeetCode.Concurrency;

/*
1114. Print in Order
Easy
Topics Concurrency
Companies

Suppose we have a class:
public class Foo {
  public void first() { print("first"); }
  public void second() { print("second"); }
  public void third() { print("third"); }
}
The same instance of will be passed to three different threads. Thread A will call , thread B will call , and thread C will call . Design a mechanism and modify the program to ensure that is executed after , and is executed after .Foofirst()second()third()second()first()third()second()

Note:
We do not know how the threads will be scheduled in the operating system, even though the numbers in the input seem to imply the ordering. The input format you see is mainly to ensure our tests' comprehensiveness.
Example 1:

Input: nums = [1,2,3]
Output: "firstsecondthird"
Explanation: There are three threads being fired asynchronously. The input [1,2,3] means thread A calls first(), thread B calls second(), and thread C calls third(). "firstsecondthird" is the correct output.
Example 2:
Input: nums = [1,3,2]
Output: "firstsecondthird"
Explanation: The input [1,3,2] means thread A calls first(), thread B calls third(), and thread C calls second(). "firstsecondthird" is the correct output.
 */

public class Foo
{

    private SemaphoreSlim _secondGate;
    private SemaphoreSlim _thirdGate;
    public Foo() {
        _secondGate = new SemaphoreSlim(0, 1);
        _thirdGate = new SemaphoreSlim(0, 1);
    }

    public void First(Action printFirst) {
        printFirst();
        _secondGate.Release();
    }

    public void Second(Action printSecond) {
        _secondGate.Wait();
        printSecond();
        _thirdGate.Release();
    }

    public void Third(Action printThird) {
        _thirdGate.Wait();
        printThird();
    }
}

