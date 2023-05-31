using System;

namespace GenericMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum = FindMaximum(10, 5, 8); // Test Case 1 (max num at 1st position)
            Console.WriteLine("Max Number: " + maxNum);
             
            maxNum = FindMaximum(3, 12, 6); // Test Case 2  (max num at 2nd position)
            Console.WriteLine("Max Number: " + maxNum);

            maxNum = FindMaximum(7, 9, 15); // Test Case 3  (Max num at 3rd position)
            Console.WriteLine("Max Number: " + maxNum);
        }

        static int FindMaximum(int num1, int num2, int num3)
        {
            int max = num1;

            if (num2.CompareTo(max) > 0)
                max = num2;

            if (num3.CompareTo(max) > 0)
                max = num3;

            return max;
        }
    }
}
