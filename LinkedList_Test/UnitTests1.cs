using System;
using System.IO;
using LinkedList;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("A")]
        [TestCase("B")]
        public void NodeClass_CreatingNewNodeWithString_ReturnsNodeWithValue(string value)
        {
            Node node = new Node(value);
            Assert.AreEqual(node.Value, value);
        }

        [Test]
        public void LinkedListHelper_GivenHeadNodeFromALinkedList_RemoveNodesWithMoreThanTwoInstances()
        {
            var linkedList = new SinglyLinkedList();

            linkedList.Add("B");
            linkedList.Add("A");
            linkedList.Add("B");
            linkedList.Add("E");
            linkedList.Add("E");
            linkedList.Add("B");
            linkedList.Add("E");

            LinkedListHelpers.RemoveNodesWithMoreThanTwoInstances(linkedList.Head);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                linkedList.PrintList();
                var result = sw.ToString().Trim();
                Assert.AreEqual(result, "E->B->E->B->A->");
            }
        }

        [Test]
        public void LinkedListHelper_LinkedListWithNoDuplicates_ReturnsList()
        {
            var linkedList = new SinglyLinkedList();

            linkedList.Add("A");
            linkedList.Add("E");
            linkedList.Add("B");

            LinkedListHelpers.RemoveNodesWithMoreThanTwoInstances(linkedList.Head);

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                linkedList.PrintList();
                var result = sw.ToString().Trim();
                Assert.AreEqual(result, "B->E->A->");
            }
        }
    }
}