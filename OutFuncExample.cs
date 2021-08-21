/*using System;

class OutFunctionExample
{
    static int _max(int[] nums, out int index)
    {
        index = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[index]) index = i;
        }

        return nums[index];
    }

    static void Main()
    {
        int[] nums = { 15, 45, 36, 17, 9, 90, 88, 116, 23 };
        
        foreach (int element in nums)
        {
            Console.Write("|{0}", element);
        }

        Console.WriteLine('|');

        int value, k;
        value = _max(nums, out k); // out используется для неинициализированных переменных.

        Console.WriteLine($"Максимальное число --> {value}.");
        Console.WriteLine($"Индекс элемента --> {k}.");
    }
}*/