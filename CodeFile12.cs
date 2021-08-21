/*using System;

class Methods
{
    static void fillRnd(int[] nums)
    {
        Random rnd = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rnd.Next(1, 101);
        }
    }

    static void showArray(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write("| {0}", nums[i]);
        }

        Console.WriteLine("|");
    }

    static void showArray(int[,] nums)
    {
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                Console.Write("{0,3}", nums[i, j]);
            }

            Console.WriteLine();
        }
    }

    static int findMax(int[] nums)
    {
        int s = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > s) s = nums[i];
        }

        return s;
    }

    static void Main()
    {
        int[] A = { 1, 2, 3, 4, 5 };
        int[,] B = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[] C = new int[10];
        int max_s = findMax(A);

        Console.WriteLine("Одномерный массив A: ");
        showArray(A);

        fillRnd(C);
        Console.WriteLine("Одномерный массив C: ");
        showArray(C);

        Console.WriteLine("Двумерный массив B: ");
        showArray(B);

        Console.WriteLine($"Максимальный элемент массива A - {max_s}.");
        
    }
}*/