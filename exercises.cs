using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{

    //שאלות סיבוכיות להגשה
    internal class exercises
    {
        //1
        // 3n + 2
        public static int CalculateOddSum(int[] array)
        {
            int sum = 0;
            foreach(int num in array)
            {
                if(num %2 == 1)
                {
                    sum += num;
                }
            }
            return sum;
        }

        //2
        //9n +3
        public static int[] FindMaximumTwo(int[] array)
        {
            
            int[] MaximumTwo = new int[2];
            for (int i = 1; i < array.Length; i++)
            {
                int sum = MaximumTwo[0] + MaximumTwo[1];
                if (array[i - 1] + array[i] > sum)
                {
                    MaximumTwo[0] = array[i - 1];
                    MaximumTwo[1] = array[i];
                }
                
            }
            return MaximumTwo;
        }


        //3
        //5n + 1
        public static bool ContainsNumber(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return true;
                }
            }
            return false;
        }

        //4
        //
        public static int IndexMiValu(int[] Triplets)
        {
            int min = 0;
            for (int i = 1; i < Triplets.Length; i++)
            {
                if (Triplets[i] < Triplets[min])
                {
                    min = Triplets[i];
                }
            }
            return min;
        }
        public static int SumOfAllTriplets(int[] array)
        {
            int[] SumOfAllTriplets = { array[0], array[1], array[2] };
            for (int i = 3; i < array.Length; i++)
            {
                if(array[IndexMiValu(array)] < array[i])
                {
                    array[IndexMiValu(array)] = array[i];
                }
            }
            return SumOfAllTriplets[0] + SumOfAllTriplets[0] + SumOfAllTriplets[0];
        }





    }
}
