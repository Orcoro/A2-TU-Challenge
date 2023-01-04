using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static bool IsDivisible(int a, int b)
        {
            return a % b == 0;
        }

        public static bool IsEven(int a)
        {
            return a % 2 == 0;
        }

        public static bool IsMajeur(int age)
        {
            if (age < 0 || age > 140)
                throw new ArgumentException();
            if (age < 18 && age > 0)
                return false;
            return age >= 18;
        }

        public static bool IsPrimary(int a)
        {
            if (a < 2)
                return false;
            for (int i = 2; i < a; i++)
                if (IsDivisible(a, i))
                    return false;
            return true;
        }
        public static List<int> GetAllPrimary(int a)
        {
            List<int> result = new List<int>();

            for (int i = 2; i <= a; i++)
                if (IsPrimary(i))
                    result.Add(i);
            return result;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static int Power(int a, int b)
        {
            int result = 1;

            for (int i = 0; i < b; i++)
                result *= a;
            return result;
        }

        public static int IsInOrder(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a > b)
                return -1;
            return 0;
        }

        public static int IsInOrderDesc(int a, int b)
        {
            return -IsInOrder(a, b);
        }
        
        public static bool IsListInOrder(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
                if (list[i] > list[i + 1])
                    return false;
            return true;
        }

        public static bool IsListInOrderDesc(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
                if (list[i] < list[i + 1])
                    return false;
            return true;
        }

        public static List<int> Sort(List<int> toSort)
        {
            while (!IsListInOrder(toSort))
                for (int i = 0; i < toSort.Count - 1; i++)
                    if (toSort[i] > toSort[i + 1]) {
                        int temp = toSort[i];
                        toSort[i] = toSort[i + 1];
                        toSort[i + 1] = temp;
                    }
            return toSort;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> Order)
        {
            while (!IsListInOrder(toSort))
                for (int i = 0; i < toSort.Count - 1; i++)
                    if (toSort[i] > toSort[i + 1])
                    {
                        int temp = toSort[i];
                        toSort[i] = toSort[i + 1];
                        toSort[i + 1] = temp;
                    }
            return toSort;
        }
    }
}