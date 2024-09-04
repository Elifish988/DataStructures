using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    public class Node
    {
        private int Value;
        private Node Next;

        public Node(int value)
        {
            Value = value;
            Next = null;
        }

        public int GetValue()
        {
            return Value;
        }

        public Node GetNext()
        {
            return Next;
        }

        public void SetValue(int value)
        {
            this.Value = value;
        }



        public void SetNext(Node next)
        {
            this.Next = next;
        }
    }
}
