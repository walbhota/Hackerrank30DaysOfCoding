//Task
//A Node class is provided for you in the editor.A Node object has an integer data field,data , and a Node instance
//pointer,next , pointing to another node(i.e.: the next node in a list).

//A removeDuplicates function is declared in your editor, which takes a pointer to the head node of a linked list as
//a parameter.Complete removeDuplicates so that it deletes any duplicate nodes from the list and returns the head of the updated list.

//Note: The head pointer may be null, indicating that the list is empty.Be sure to reset your next pointer when
//performing deletions to avoid breaking the list.

//Explanation

//N = 6, and our non-decreasing list is {1,2,2,3,3,4}. The values 2 and 3 both occur twice in the list, so we remove
//the two duplicate nodes. We then return our updated (ascending) list, which is {1,2,3,4}.


using System;
using System.Collections.Generic;
class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }

}
class Solution
{

    public static Node removeDuplicates(Node head)
    {
        //Write your code here
        Node start = head;

        while (start.next != null)
        {
            if (start.data == start.next.data)
            {
                start.next = start.next.next;
            }
            else
            {
                start = start.next;
            }
        }
        return head;
    }

    public static Node insert(Node head, int data)
    {
        Node p = new Node(data);


        if (head == null)
            head = p;
        else if (head.next == null)
            head.next = p;
        else
        {
            Node start = head;
            while (start.next != null)
                start = start.next;
            start.next = p;

        }
        return head;
    }
    public static void display(Node head)
    {
        Node start = head;
        while (start != null)
        {
            Console.Write(start.data + " ");
            start = start.next;
        }
    }
    static void Main(String[] args)
    {

        Node head = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            head = insert(head, data);
        }
        head = removeDuplicates(head);
        display(head);
    }
}
