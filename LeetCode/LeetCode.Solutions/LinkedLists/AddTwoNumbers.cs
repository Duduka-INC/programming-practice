namespace LeetCode.LinkedLists;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
    
    public bool Equals(ListNode? other)
    {
        if (other == null) return false;

        var a = this;
        var b = other;

        while (a != null && b != null)
        {
            if (a.val != b.val)
                return false;

            a = a.next;
            b = b.next;
        }

        return a == null && b == null;
    }

    public override bool Equals(object? obj)
        => Equals(obj as ListNode);

    public override int GetHashCode() => val;
}

public class AddTwoNumbers
{
    public ListNode Solve(ListNode l1, ListNode l2) {
        var l1Number = BuildNumber(TraverseReverse(l1));

        var l2Number = BuildNumber(TraverseReverse(l2));

        long summ = l1Number + l2Number;

        var listNode = MakeListNode(summ);
        return ReverseListNode(listNode);
    }
    
    public List<long> TraverseReverse(ListNode node)
    {
        if (node == null)
        {
            return new List<long>();
        }
    
        var result = TraverseReverse(node.next);
        result.Add(node.val);
    
        return result;
    }
    
    public ListNode ReverseListNode(ListNode current)
    {
        ListNode next = current.next;
        ListNode previous = null;

        while (current != null)
        {
            next = current.next;
            current.next =  previous;
            previous = current;
            current = next;
        }
            
        return previous;
    }
    
    public ListNode MakeListNode(long number)
    {
        if (number == 0)
        {
            return new ListNode(0, null);
        }
            
        ListNode list = null;
        ListNode tail = null;
            
        while (number > 0)
        {
            int num = (int)(number % 10);
            list = new ListNode(num, tail);
            tail = list;
            
            number = number / 10;
        }
        
        return list;
    }
    
    long BuildNumber(List<long> arr)
    {
        long result = 0;

        foreach (var digit in arr)
        {
            result = result * 10 + digit;
        }

        return result;
    }
    

    void Traverse(ListNode node, List<int> acc)
    {
        if (node == null)
        {
            return;
        }
        acc.Add(node.val);
        Traverse(node.next, acc);
    } 

    void TraverseReverse(ListNode node, List<int> acc)
    {
        if (node == null)
        {
            return;
        }
    
        TraverseReverse(node.next, acc);
        acc.Add(node.val);
    } 

    List<int> TraverseReversePure(ListNode node)
    {
        if (node == null)
        {
            return new List<int>();
        }
    
        var result = TraverseReversePure(node.next);
        result.Add(node.val);
    
        return result;
    } 
}