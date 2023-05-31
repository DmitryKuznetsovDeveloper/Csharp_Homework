using System.Drawing;

namespace RedBlackTree
{
    public class Three
    {
        public Node Root { get;  set; }

        private bool AddNode(Node node, int value)
        {
            if (node.Value == value) return false;
            else
            {
                if (node.Value > value)
                {
                    if (node.Left != null)
                    {
                        bool result = AddNode(node.Left, value);
                        node.Left = Rebalnce(node.Left);
                        return result;
                    }
                    else
                    {
                        node.Left = new Node();
                        node.Left.Color = ColorNode.Red;
                        node.Left.Value = value;
                        return true;
                    }
                }
                else
                {
                    if (node.Right != null)
                    {
                        bool result = AddNode(node.Right, value);
                        node.Right = Rebalnce(node.Right);
                        return result;
                    }
                    else
                    {
                        node.Right = new Node();
                        node.Right.Color = ColorNode.Red;
                        node.Right.Value = value;
                        return true;
                    }
                }
            }
        }

        private void ColorSwap(Node node)
        {
            node.Right.Color = ColorNode.Blak;
            node.Left.Color = ColorNode.Blak;
            node.Color = ColorNode.Red;
        }

        private Node LeftSwap(Node node)
        {
            Node left = node.Left;
            Node between = left.Right;
            left.Right = node;
            node.Left = between;
            left.Color = node.Color;
            node.Color = ColorNode.Red;
            return left;
        }
        
        private Node RightSwap(Node node)
        {
            Node right = node.Right;
            Node between = right.Left;
            right.Left = node;
            node.Right = between;
            right.Color = node.Color;
            node.Color = ColorNode.Red;
            return right;
        }

        private Node Rebalnce(Node node)
        {
            Node result = node;
            bool needRebalance;
            do
            {
                needRebalance = false;
                if (result.Right != null && result.Right.Color == ColorNode.Red &&
                    (result.Left == null || result.Left.Color == ColorNode.Blak))
                {
                    needRebalance = true;
                    result = RightSwap(result);
                }
                if (result.Left != null && result.Left.Color == ColorNode.Red && 
                    result.Left.Left != null && result.Left.Left.Color == ColorNode.Red)
                {
                    needRebalance = true;
                    result = LeftSwap(result);
                }

                if (result.Left != null && result.Left.Color == ColorNode.Red &&
                    result.Right != null && result.Right.Color == ColorNode.Red)
                {
                    needRebalance = true;
                    ColorSwap(result);
                }

            } while (needRebalance);

            return result;
        }

        public bool Add(int value)
        {
            if (Root != null)
            {
                bool result = AddNode(Root, value);
                Root = Rebalnce(Root);
                Root.Color = ColorNode.Blak;
                return result;
            }
            else
            {
                Root = new Node();
                Root.Color = ColorNode.Blak;
                Root.Value = value;
                return true;
            }
        }
    }
}