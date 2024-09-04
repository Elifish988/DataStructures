using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    public class NodePro
    {
        public int Value { get; set; }
        public NodePro Prev { get; set; }
        public NodePro Next { get; set; }

        public NodePro(int value)
        {
            Value = value;
            Next = this;
            Prev = this;
        }
    }


    internal class CircularDoubleLinkedList
    {
        public NodePro Head;
        public int Count;

        public CircularDoubleLinkedList()
        {
            Head = null;
            Count = 0;
        }


        public void AddLast(int value)
        {
            NodePro newNode = new NodePro(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                NodePro Tail = Head.Prev;
                Tail.Next = newNode;
                newNode.Prev = Tail;
                newNode.Next = Head;
                Head.Prev = newNode;
            }
            Count++;

        }

        // next to try alone:
        // display 
        // remove (value)
        // remove (index)
        // find
        // addAfterIndex
    }
}
