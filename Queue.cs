using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    internal class Queue
    {
        private Node Head;
        private Node Tail;
        private int count;

        public Queue()
        {
            count = 0;
        }

        public void Enqueue(int value)
        {
            Node newNod = new Node(value);
            if(count == 0)
            {
                Head = newNod;
                Tail = newNod;
                
            }
            else
            {
                Tail.SetNext(newNod);
                Tail = newNod;
            }
            count++;
        }

        public int? Dequeue()
        {
            if(count == 0)
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
