using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day_1
{

    




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
            if(Head == null) { return ""; }
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
            if (Head != null) 
            {
                if (Head.GetValue() == value)
                {
                    Head = Head.GetNext();
                    return;
                }
                Node tmp = Head;
                while (tmp.GetNext() != null)
                {
                    if (tmp.GetNext().GetValue() == value)
                    {
                        tmp.SetNext(tmp.GetNext().GetNext());
                        return;
                    }
                    tmp = tmp.GetNext();

                }
            }
            
        }

        // Method to remove the first value
        // Method to remove all values
        public void RemoveAllValues(int value)
        {
            while (Head != null && Head.GetValue() == value)
            {
                Head = Head.GetNext();
            }
            if (Head == null)
                return;
            Node current = Head;
            Node prev = new Node(-1);
            while (current.GetNext() != null)
            {
                if (current.GetValue() == value)
                {
                    prev.SetNext(current.GetNext());
                }
                prev = current;
                current = current.GetNext();

            }
            if (current.GetValue() == value)
            {
                prev.SetNext(null);
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
            while(tmp.GetNext() != null)
            {
                tmpIndex++;
                if(tmpIndex == index)
                {
                    tmp.SetNext(tmp.GetNext().GetNext());
                    return;
                }
                tmp = tmp.GetNext();
            }
        }

        // Method to find by value
        public int Find(int a)
        {
            
            int tmpIndex = 0;
            Node tmp = Head;
            while (tmp != null)
            {
                
                if (tmp.GetValue() == a)
                {

                    return tmpIndex;
                }
                tmpIndex++;
                tmp = tmp.GetNext();
            }
            return -1;
        }

        // Method to get a value by  index
        public int Get(int index)
        {
            int tmpIndex = 0;
            Node tmp = Head;
            while (tmpIndex < index)
            {
                if (tmp == null)
                {
                    return -1;
                }
                tmpIndex++;
                tmp = tmp.GetNext();
            }
            if (tmp == null)
            {
                return -1;
            }
            return tmp.GetValue();

        }
    }


}
