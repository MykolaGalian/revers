using System;

namespace revers_arr_
{
    public class LinkedListNode
    {
        Node head;
        Node tail;
        public void Add(Node n)
        {
            if (head == null)
            {
                head = n;
                tail = head;
            }
            else
            {
                tail.Next = n;
                tail = tail.Next;
            }

        }

        public void PrintNodes()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Item);
                temp = temp.Next;
            }
        }

        public void ReverseLinkedList()
        {
            this.ReverseLinkedList(this.head);
        }
        public void ReverseLinkedList(Node item)
        {
            if (item == null || item.Next == null) //if head is null or we are at the tail
            {
                this.head = item; //we are at the tail or empty list, set the new head to the tail
                return;
            }

            ReverseLinkedList(item.Next);
            var nextItem = item.Next; //get the next item out, dealing with references don't want to override it
            item.Next = null;         //once you get the next item out, you can delete the *reference* i.e. link to it
            nextItem.Next = item;     //set the item you got out link to next item to the current item i.e. reverse it
        }

       
    }
}