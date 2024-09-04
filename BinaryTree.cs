using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    public class BinaryTree
    {
        private TreeNode root ;
        private string Name;

        public BinaryTree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            root = InsertRecursive(root, value);
        }

        private TreeNode InsertRecursive(TreeNode node, int value)
        {
            if (node == null)
            {
                node = new TreeNode(value);
                return node;
            }
            if (value < node.Value)
                node.Left = InsertRecursive(node.Left, value);
            else
                node.Right = InsertRecursive(node.Right, value);
            return node;
        }

        public bool Find(int value)
        {
            return FindRecursive(root, value);
        }

        private bool FindRecursive(TreeNode node, int value)
        {
            if (node == null)
                return false;
            if (node.Value == value)
                return true;
            if (value < node.Value)
                return FindRecursive(node.Left, value);
            else
                return FindRecursive(node.Right, value);
        }


        public int? GetMin()
        {
            return GetMin(root);
        }

        private int? GetMin(TreeNode tmp)
        {
            
            if(tmp == null)
            {
                return null;
            }
            while(tmp.Left != null)
            {
                tmp = tmp.Left;
            }
            return tmp.Value;
        }
    }
}
