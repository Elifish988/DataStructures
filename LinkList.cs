using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

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




    public class LinkedList
    {
        Node Head;

        public LinkedList()
        {
            this.Head = null;
        }

        public LinkedList(int value)
        {
            this.Head = new Node(value);
        }

        // Method to add to  the end of the list
        public void Add(int value)
        {
            Node tmp = Head;
            if(Head == null)
            {
                Head = new Node(value); 
                return;
            }
            while(tmp.GetNext() != null)
            {
                tmp = tmp.GetNext();
            }
            tmp.SetNext(new Node(value));
        }


        public string Display()
        {
            if(Head == null) { return "empty list"; }
            string result = Head.GetValue().ToString();
            Node tmp = Head.GetNext();
            while(tmp != null)
            {
                result += " -> " + tmp.GetValue().ToString();
                tmp = tmp.GetNext();

            }
            return result;
        }

        public int Length()
        {
            int sum = 0;
            if (Head == null) { return sum; }
            Node tmp = Head;
            while(tmp != null)
            {
                sum++;
                tmp = tmp.GetNext();
            }
            return sum;
            
        }

        // Method to remove the first value
        public void RemoveValue(int value)
        {
            if(Head.GetValue() == value)
            {
                Head = Head.GetNext();
                return;
            }
            Node tmp = Head;
            while (tmp.GetNext() != null)
            {
                if(tmp.GetNext().GetValue() == value)
                {
                    tmp.SetNext(tmp.GetNext().GetNext());
                    return;
                }
                tmp = tmp.GetNext();
                
            }
        }

        // Method to remove the first value
        public void RemoveAllValues(int value)
        {
            Node tmp = Head;
            if (Head.GetValue() == value)
            {
                Head = Head.GetNext();
            }
            while (tmp.GetNext() != null)
            {
                if (tmp.GetNext().GetValue() == value)
                {
                    tmp.SetNext(tmp.GetNext().GetNext()); 
                }
                tmp = tmp.GetNext();

            }
        }

        // Method to remove the value in an index
        public void RemoveIndex(int index)
        {
            if(index == 0)
            {
                Head = Head.GetNext();
            }
            int tmpIndex = 0;
            Node tmp = Head;
            while(tmp != null)
            {

            }
        }

        // Method to find by value
        //public Find(data)
        //{

        //}

        // Method to get a value by  index
        //public Get(data)
        //{

        //}
    }


}
