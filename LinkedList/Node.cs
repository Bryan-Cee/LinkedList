namespace LinkedList
{
    public class Node
    {
        public string Value { get; set; }
        public Node Next { get; set; }
        public Node(string data)
        {
            this.Value = data;
            this.Next = null;
        }
    }
}