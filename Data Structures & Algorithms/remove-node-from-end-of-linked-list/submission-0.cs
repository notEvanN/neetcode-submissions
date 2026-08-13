/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode d = new ListNode(0,head);
        ListNode l = d;
        ListNode r = head;
        while (n>0) {
            r = r.next;
            n--;
        }
        while (r != null) {
            l = l.next;
            r = r.next;
        }
        l.next = l.next.next;
        return d.next;
    }
}
