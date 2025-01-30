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
    public ListNode DeleteDuplicates(ListNode head) {
        HashSet<int> h = new HashSet<int>();

        ListNode temp = head;
        ListNode newHead = null;
        ListNode tail = null;

        while(temp != null){
            if(!h.Contains(temp.val)){
                ListNode node = new ListNode(temp.val);
                if(newHead == null){
                    newHead = node;
                    tail = node;
                } else {
                    tail.next = node;
                    tail = node; 
                }

                h.Add(temp.val);
            }

            temp = temp.next;
        }
        return newHead;
    }
}