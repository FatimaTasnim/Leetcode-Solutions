/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode result = new ListNode(0);
        ListNode curr = result;
        int carry = 0, sum;
        
        while(l1 != null || l2 != null) {
            sum = 0;
            if(l1!=null) sum = l1.val;
            if(l2!=null) sum += l2.val;
            sum += carry;
            carry = sum/ 10;
            curr.next = new ListNode(sum % 10);
            curr = curr.next; 
         
            if(l1 != null)l1 = l1.next; 
            if(l2 != null)l2 = l2.next;             
        }
        if(carry > 0)curr.next = new ListNode(carry);
        
        return result.next;
    }
}