namespace LinkedListReversal
{
    public class List
    {
        private Node Head { get; set; }

        public void FillListFirst(int value)
        {
            for (int i = 1; i <= value; i++)
            {
                AddFirst(i);
            }
        }

        public void AddFirst(int value)
        {
            Node node = new Node();
            node.Value = value;
            if (Head != null) node.Next = Head;
            Head = node;
        }

        public void AddLast(int value)
        {
            Node node = new Node();
            node.Value = value;
            if (Head == null) Head = node;
            else
            {
                Node last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }

                last.Next = node;
            }
        }

        public void RemoveFirst()
        {
            if (Head != null) Head = Head.Next;
        }

        public void RemoveLast()
        {
            if (Head != null)
            {
                Node node = Head;
                while (node.Next != null)
                {
                    if (node.Next.Next == null)
                    {
                        node.Next = null;
                        return;
                    }

                    node = node.Next;
                }

                Head = null;
            }

        }

        public bool Contains(int value)
        {
            Node node = Head;
            while (node != null)
            {
                if (node.Value == value) return true;
                node = node.Next;
            }

            return false;

        }

        public void ReverList()
        {
            if(Head == null)return;
            Node prev = null, current = Head, next = null;
            while (current.Next != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            current.Next = prev;
            Head = current;
        }
        
        public void Print()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write($"{current.Value}  ");
                current = current.Next;
            }

            Console.WriteLine();
        }

        private class Node
        {
            public Node Next { get; set; }
            public int Value { get; set; }
        }
    }
}