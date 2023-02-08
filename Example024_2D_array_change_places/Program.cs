// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int[,] CreateArray()
{
    Random random = new Random();
    int[,] array = new int[random.Next(3, 6), random.Next(3, 6)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 6);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine();
    }
}
int[,] ToFindMin(int[,] array)
{
    int min = array[0, 0];
    int minIndx1 = 0;
    int minIndx2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min )
             {
                min = array[i, j];
                minIndx1 = i;
                minIndx2 = j;
             }
        }
    Console.WriteLine($"Min element: {min}");
    Console.WriteLine($"Index Min element: [{minIndx1}, {minIndx2}]");
    int[,] arra2 = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0, k = 0; i < array.GetLength(0); i++, k++)
        for (int j = 0, t = 0; j < array.GetLength(1); j++, t++)
        {
            if (i == minIndx1)
            {
                i++;
            }
            if (j == minIndx2)
            {
                j++;
            }
            if (i == array.GetLength(0) || j == array.GetLength(1)) continue;
            arra2[k, t] = array[i, j];
        }
    return arra2;
}

int[,] arr = CreateArray();
PrintArray(arr);
Console.WriteLine();

int[,] arr2 = ToFindMin(arr);

PrintArray(arr2);
