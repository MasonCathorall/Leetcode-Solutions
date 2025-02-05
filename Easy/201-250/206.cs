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
    public ListNode ReverseList(ListNode head) {
        var dummy = new ListNode(-1);

        var current = head;

        while(current != null){
            var next = current.next;

            current.next = dummy.next;
            dummy.next = current;

            current = next;
        }

        return dummy.next;
    }
}