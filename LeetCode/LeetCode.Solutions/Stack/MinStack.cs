namespace LeetCode.Stack;

public class MinStack
{
    private Stack<int> stack;
    private int min;
    private int top;
    
    public MinStack()
    {
        stack = new Stack<int>();
        min = int.MaxValue;
        top = 0;
    }
    
    public void Push(int val) {
        stack.Push(val);
        if  (min > val) {
            min = val;
        }
    }
    
    public void Pop()
    {
        stack.Pop();
    }
    
    public int Top()
    {
        return stack.Peek();
    }
    
    public int GetMin()
    {
        return min;
    }
}