// https://leetcode.com/problems/merge-two-sorted-lists/

//  * Definition for singly-linked list.


ListNode BuildListNode(List<int> list)
 {
    if(list.Count == 0)
        return null;

    var resultListNode = new ListNode(list[0]);
    var currentListNode = resultListNode;

    for(int i = 1; i < list.Count; i++) {
        var listNode = new ListNode(list[i]);
        currentListNode.next = listNode;
        currentListNode = listNode;
    }

    return resultListNode;
 }

void printListNode(ListNode listNode) 
{
    System.Console.Write("[");
    for(var currentListNode = listNode; 
            currentListNode != null; 
            currentListNode = currentListNode.next) {
                System.Console.Write($"{currentListNode.val}, ");
    }
    System.Console.WriteLine("]");
 }

List<int> inputList1 = new List<int>() {1,2,4};
ListNode input1 = BuildListNode(inputList1);

printListNode(input1);

 public class ListNode {
     public int val;
     public ListNode? next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }

public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        return null;
    }
}