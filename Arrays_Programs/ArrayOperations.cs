using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Programs
{
    public class Arrayoperations
    {
        static void Main(string[] args)
    {
        int[] numbers = new int[5] { 45, 78, 99, 34, 59 };
        int[] nums = new int[5];
        Console.WriteLine("Original array");

        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("sorted array");
        Array.Sort(numbers);
            

        Array.Reverse(numbers);
        Array.Clear(numbers, 2, 2);
        Array.Copy(numbers, 1, nums, 0, 3);
        Array.Copy(numbers, nums, numbers.Length);
        int index = Array.IndexOf(numbers, 34);
        Console.WriteLine($"index of 34 is {index}");
        foreach (int i in nums)
        {
            Console.WriteLine(i);
        }
    }

    }
}

