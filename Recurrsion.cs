using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day_1
{
    internal class Recurrsion
    {
        //1
        public static int multiply(int a , int b)
        {
            if(b == 0)
            {
                return 0;
            }
            else
            {
               return  a + multiply(a, b - 1);
            }
        }

        //2
        public static int sumOfDigits(int num)
        {
            if(num == 0)
            {
                return 0;
            }
            else
            {
                return num % 10 + sumOfDigits(num / 10);
            }
        }

        //3
        public static int power(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            else
            {
                return a * multiply(a, b - 1);
            }
        }

        //4
        public static int reversed_1(int num)
        {
            return reversed_2(num, 0);
        }
        public static int reversed_2(int num, int rev)
        {
            if(num < 10)
            {
                return rev * 10 + num;
            }
            else
            {
                rev *= 10;
                return reversed_2(num / 10, rev + num % 10);

            }
            
        }

        //5
        public static int findSum(int[] array, int n)
        {
            if(n == 2)
            {
                return array[0] + array[1];
            }
            else
            {
                return array[n - 1] + findSum(array, n - 1);
            }
        }

        //6
        public static int divide(int a, int b)
        {
            if(a - b <= 0)
            {
                return 0;
            }
            else
            {
                return 1 + divide(a - b, b);
            }
        }

        //7
        public static bool isPalindrome(string str, int i = 1)
        {
            if()
            {
                return true
            }
        }
    }
}
