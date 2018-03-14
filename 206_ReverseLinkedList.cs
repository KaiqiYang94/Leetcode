// ToOffer_5
//Reverse a singly linked list.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReversedList;
    
    public ListNode ReverseList(ListNode head) {
        var tail = ReverseListRecursively(head);
        
        // remember! make the tail.next to null
        tail.next = null;
        return ReversedList;
    }
    
    // return a tail of the reversed List
    public ListNode ReverseListRecursively(ListNode head)
    {
        if(head == null || head.next == null)
        {
            ReversedList = head;
            return head;
        }
        
        ListNode tail = ReverseListRecursively(head.next);
        tail.next = head;
        
        return head;
    }
}