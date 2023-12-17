using System;

public class ListNode
{
    public int value;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.value = val;
        this.next = next;
    }
}

public class LinkedListOperations
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        ListNode firstNode = head;
        ListNode secondNode = head.next;

        firstNode.next = SwapPairs(secondNode.next);
        secondNode.next = firstNode;

        return secondNode;
    }

    public void PrintLinkedList(ListNode head)
    {
        ListNode current = head;
        while (current != null)
        {
            Console.Write(current.value + " ");
            current = current.next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        LinkedListOperations linkedList = new LinkedListOperations();

        ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
        Console.WriteLine("Input 1:");
        linkedList.PrintLinkedList(head1);
        head1 = linkedList.SwapPairs(head1);
        Console.WriteLine("Output 1:");
        linkedList.PrintLinkedList(head1);

        ListNode head2 = null;
        Console.WriteLine("\nInput 2:");
        linkedList.PrintLinkedList(head2);
        head2 = linkedList.SwapPairs(head2);
        Console.WriteLine("Output 2:");
        linkedList.PrintLinkedList(head2);

        ListNode head3 = new ListNode(1);
        Console.WriteLine("\nInput 3:");
        linkedList.PrintLinkedList(head3);
        head3 = linkedList.SwapPairs(head3);
        Console.WriteLine("Output 3:");
        linkedList.PrintLinkedList(head3);
    }
}