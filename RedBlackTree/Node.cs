using System.Drawing;
using System.Runtime.CompilerServices;

namespace RedBlackTree
{
    public class Node
    {
        public int Value { get;  set; }
        public ColorNode Color { get;  set; }
        public Node Left { get;  set; }
        public Node Right { get;  set; }
    }

    public enum ColorNode
    {
        Red,
        Blak
    }
}