using System;
using System.Collections.Generic;
using System.Numerics;
namespace Katas2
{
    class Program
    {
        static void Main(string[] args)
        {

           
        }


        //
        public static BigInteger perimeter(BigInteger n)
        {
            BigInteger[] fibo = new BigInteger[(int)n + 1];
            fibo[0] = 1;
            fibo[1] = 1;
            BigInteger sum = 0;
            for (int i = 2; i <= fibo.Length - 1;)
            { fibo[i] = fibo[i - 1] + fibo[i - 2]; i++; }
            for (int k = 0; k <= fibo.Length - 1; k++)
                sum += fibo[k];
            BigInteger res = sum * 4;
                return res;
        }
        //
        public static bool IsPrime(int n)
        {
            { 
                if (n <= 2 || n % 2 == 0) return n == 2;
                for (int i = 3; i <= Math.Sqrt(n); i += 2) if (n % i == 0) return false;
                return true;
            }
        }
        //
        public static int[] SortNumbers(int[] nums)
        {
            if (nums != null)
            {
                Array.Sort(nums);
                return nums;
            }
            else return new int[0];
        }
        //
        public static int Litres(double time) => (int)Math.Round(time * 0.5, MidpointRounding.ToZero);
        //
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null || a.Length == 0 || b.Length == 0)
                return false;
            Array.Sort(b);
            int[] c = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                c[i] = a[i] * a[i];
            Array.Sort(c);
            for (int k = 0; k < a.Length;)
            {
                if (b[k] != c[k])
                    return false;
                k++;
            }
            return true;
        }
        //
        public static string sumStrings(string a, string b)
        {

            string str1 = string.Empty;
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsNumber(a[i]))
                    str1 += a[i];
            }

            string str2 = string.Empty;
            for (int k = 0; k < b.Length; k++)
            {
                if (char.IsNumber(b[k]))
                    str2 += b[k];
            }
            if (b == "")
                return str1;
            else if (a == "")
                return str2;
            else
            {

                BigInteger number1 = BigInteger.Parse(str1);
                BigInteger number2 = BigInteger.Parse(str2);
                BigInteger result = number1 + number2;

                return result.ToString();
            }
        }
        //
        public static string ReverseWords(string str)
        {
            string[] arr = str.Split();
            Array.Reverse(arr);
            string stri = "";
            for (int i = 0; i < arr.Length; i++)
            {stri += arr[i]; stri += " ";};
            string strik = "";
            for (int k = 0; k < stri.Length - 1; k++)
                strik += stri[k];

            return stri;


        }
        //









    }
}
