using System;

namespace LinkedList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var newLinkedList = new SinglyLinkedList();

            newLinkedList.Add("B");
            newLinkedList.Add("A");
            newLinkedList.Add("B");
            newLinkedList.Add("E");
            newLinkedList.Add("E");
            newLinkedList.Add("B");
            newLinkedList.Add("E");

            Console.WriteLine("Before calling method -> " + newLinkedList.Count);

            LinkedListHelpers.RemoveNodesWithMoreThanTwoInstances(newLinkedList.Head);

            Console.WriteLine("=====");

            newLinkedList.PrintList();

            Console.WriteLine("\n=====");

            Console.WriteLine("After calling method -> " + newLinkedList.Count);
        }
    }
}