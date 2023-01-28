// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Write("Задайте размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
FillArray(array);
Console.WriteLine();
RevertArray(array);

void FillArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 11);
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("\b\b ");
}
void RevertArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -1*arr[i];
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine("\b\b ");
}
