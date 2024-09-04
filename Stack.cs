using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    internal class Stack
    {
        private Node Head;
        private int count;

        public Stack()
        {
            count = 0;
        }

        public void Push(int value)
        {
            Node newNod = new Node(value);
            if (count == 0)
            {
                Head = newNod;
                

            }
            else
            {
                newNod.SetNext(Head);
                Head = newNod;
            }
            count++;
        }

        public int? Pop()
        {
            if (count == 0)
            {
                return null;
            }
            else
            {
                int tmp = Head.GetValue();
                Head = Head.GetNext();
                count--;
                return tmp;
            }
        }

        public int? Peak()
        {
            if (count == 0)
            {
                return null;
            }
            else
            {
                return Head.GetValue();
            }
        }

        public int Count()
        {
            return count;
        }


    }
}

