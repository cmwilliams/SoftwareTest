using System;

namespace SoftwareTest.Helpers
{
    public class LinkedList<T>
    {

        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }
        public int Count { get; set; }

        public void AddToLinkedList(T item)
        {
            var node = new Node<T> {Item = item};

            if (First == null)
            {
                First = node;
                Last = node;
            }
            else
            {
                Last.Next = node;
                Last = node;
            }

            Count++;
        }
    }
}