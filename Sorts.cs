using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    internal class Sorts
    {
        public static int[] BubbleSort(int[] array)
        {
            int n = array.Length;
            int tmp = 0;

            for (int i = 0; i < (n - 1); i++)
            {
                bool isSort = true;
                for (int j = 0; j < (n - 1 - i); j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                        isSort = false;
                    }
                }
                if (isSort) return array;
            }
            return array;
        }


        public static void InsertionSort(int[] array)
        {
            int len = array.Length;
            for (int i = 1; i < len; i++)
            {
                    for (int j = i; j > 0; j--)
                    {
                        if (array[j] > array[j - 1])
                        {
                        break; 
                        }
                        else
                        {
                            int tmp = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = tmp;
                        }

                    }
            }

        }

        public static void SelectionSort(int[] array)
        {
            int tmp = 0;
            int indexMin = 0;
            for (int i = 0; i < array.Length; i++)
            {
                indexMin = IndexMin(array, i);
                tmp = array[i];
                array[i] = array[indexMin];
                array[indexMin] = tmp;
            }
        }

        public  static int IndexMin(int[] array, int index)
        {
            int IndexMin = index;
            for (int i = index + 1; i < array.Length; i++)
            {
                if (array[i] < array[IndexMin])
                {
                    IndexMin = i;
                }
            }
            return IndexMin;
        }
    }


}
