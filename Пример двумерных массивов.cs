/*using System;

class TwoDimArray
{
    static void Main()
    {
        int[,] nums = { { 1, 2, 3 }, { 4, 5, 6 } };

        Console.Title = "Двумерный массив: ";

        for (int i = 0; i < nums.GetLength(0); i++) // строка
        {
            for (int j = 0; j < nums.GetLength(1); j++) // столбцы
            {
                Console.Write(nums[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}*/

/*using System;

internal class TwoDimArray
{
    private static void Main()
    {
        int[,] nums = new int[3, 5]; //[,] --> двумерный массив + размерность.
        int value = 1;

        Console.Title = "Двумерный массив: ";

        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                nums[i, j] = value;
                Console.Write(nums[i, j] + "\t"); //аналог nums[i][j] в python
                value++;
            }

            Console.WriteLine();
        }
    }
}*/