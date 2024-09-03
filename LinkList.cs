using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Day_1
{

    public class Node
    {
        private int _value;
        private Node _next;

        public int GetValue()
        {
            return _value;
        }

        public void SetValue(int value)
        {
            this._value = value;
        }

        public Node GetNext()
        {
            return _next;
        }

        public void SetNext(Node next)
        {
            this._next = next;
        }



    }


    public class LinkList
    {

    }

    
}
