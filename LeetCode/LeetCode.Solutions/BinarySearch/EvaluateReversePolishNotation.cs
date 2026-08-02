using Microsoft.VisualBasic;

namespace LeetCode.BinarySearch;

public class EvaluateReversePolishNotation
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        foreach (var token in tokens)
        {
            if (int.TryParse(token, out int value))
            {
                stack.Push(value);
            }
            else
            {
                var operands = GetOperands(stack);
                stack.Push(Operate(operands, token));
            }
        } 
        
        return  stack.Pop();
    }

    public int Operate(int[] operands, string operation)
    {
        switch (operation)
        {
            case "+":
            {
                return operands[1] + operands[0];
            }
            case "-":
            {
                return operands[1] - operands[0];
            }
            case "*":
            {
                return operands[1] * operands[0];
            }
            case "/":
                return operands[1] / operands[0];
        }
        
        throw new Exception("Unknown operation: " + operation);
    }
    
    public int[] GetOperands(Stack<int> stack)
    {
        if (stack.Count > 1)
        {
            var operand1 = stack.Pop();
            var operand2 = stack.Pop();
            
            return new[] { operand1, operand2 };
        }
        else
        {
            throw new("Only 1 operator in stack.");
        }
    }
}