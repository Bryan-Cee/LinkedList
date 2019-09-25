using System;
using System.Collections.Generic;

namespace LinkedList
{
    static public class LinkedListHelpers
    {
        public static Node RemoveNodesWithMoreThanTwoInstances(Node head)
        {
            Dictionary<string, int> Occurence = new Dictionary<string, int>();
            Node Current = head;
            Node Previous = head;

            // Keeps track of how many time the value
            // of a node exists within the linked list
            while (head != null)
            {
                string CurrentData = head.Value;

                if (Occurence.ContainsKey(CurrentData))
                {
                    Occurence[CurrentData]++;
                }
                else
                {
                    Occurence.Add(CurrentData, 1);
                }

                if (Occurence[CurrentData] > 2)
                {
                    // Skip the reference to the node that
                    // exists more than twice and reference 
                    // the node after it thus removing it from 
                    // the SinglyLinkedList
                    Previous.Next = head.Next;
                }
                else
                {
                    Previous = head;
                }

                head = head.Next;
            }

            return Current;
        }
    }
}
