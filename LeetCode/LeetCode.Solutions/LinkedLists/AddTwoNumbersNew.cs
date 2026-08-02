namespace LeetCode.LinkedLists;

public class AddTwoNumbersNew
{
    public ListNode Solve(ListNode l1, ListNode l2)
    {
        var node1 = l1;
        var node2 = l2;

        ListNode result = null;
        
        ListNode current = null;
        ListNode next = null;

        int carry = 0;

        while (node1 != null ||  node2 != null || carry != 0)
        {
            var term1 = 0;
            var term2 = 0;
            
            if (node1 != null)
            {
                term1 = node1.val;
                node1 = node1.next;
            }

            if (node2 != null)
            {
                term2 = node2.val;
                node2 = node2.next;
            }

            int sum = term1 + term2 + carry;
            int digit = sum % 10;

            
            next = new ListNode(digit);
            
            if (result == null)
            {
                result = next;
            }
            if (current != null)
            {
                current.next = next;
            }

            current = next;
            carry = sum / 10;
        }
        
        return result;
    }
}