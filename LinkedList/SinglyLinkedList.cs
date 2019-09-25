using System;

namespace LinkedList
{
    public class SinglyLinkedList
    {
        public Node Head { get; set; }
        public int Count { get; set; }

        public SinglyLinkedList()
        {
            this.Head = null;
        }

        public void Add(string data)
        {
            var newNode = new Node(data);
            newNode.Next = this.Head;
            this.Head = newNode;

            this.Count++;
        }

        public void PrintList()
        {
            var tempHead = this.Head;
            this.Count = 0;

            while (tempHead != null)
            {
                Console.Write(tempHead.Value + "->");
                tempHead = tempHead.Next;
                Count++;
            }
        }

        public void Clear()
        {
            this.Head = null;
        }
    }
}
