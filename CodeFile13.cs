/*using System;

class Void_and_Return_Methods
{
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
    static void showArray(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write("| {0}", nums[i]);
        }

        Console.WriteLine("|");
    } // метод работает с УЖЕ ГОТОВЫМ массивом, ничего не возвращает!
    static int findMax(int[] nums)
    {
        int s = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > s) s = nums[i];
        }

        return s;
    }

    static int[] constructArray(int n) // конструктор массива, метод САМ СОЗДАЁТ массив и возвращает его!
    {
        int[] nums = new int[n];
        int val = 5;
        for (int i = 0; i < n; i++)
        {
            nums[i] = val;
            val = val + 5;
        }

        return nums;
    }

    static int[,] constructArray(int r, int c)
    {
        int[,] nums = new int[r, c];
        int val = 1;
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                nums[i, j] = val;
                val++;
            }
        }

        return nums;
    }

    static void Main()
    {
        Console.Title = "Работа с массивами.";
        int[] A;
        int[,] B;
        
        A = constructArray(5);
        B = constructArray(3, 3);
        int max_ = findMax(A);

        Console.WriteLine("Печать массива A: ");
        showArray(A);

        Console.WriteLine("Печать массива B: ");
        showArray(B);

        Console.WriteLine("Максимальный элемент массива A - {0}.", max_);
        
    }
}*/