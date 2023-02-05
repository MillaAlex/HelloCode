// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int QuantityOfNumbers(int number)
{
    int counter = 0;
    while (number > 0)
    {
        number /= 10;
        counter++;
    }
    return counter;
}
Console.WriteLine($"Количество цифр в числе {number} -> {(QuantityOfNumbers(number))}");



// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int Multiplication (int N)
{
    int count = 1;
    for (int i = 1; i <= N; i++)
    {
        count = count * i;        
    }
    return count;
}
Console.WriteLine(Multiplication(n));



// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и 
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] random_array = new int[8];
for (int i = 0; i < random_array.Length; i++)
{
    random_array[i] = new Random().Next(0,2);
    Console.Write(random_array[i]);
}
int[] array = new int[8];
FillArray(array);
ShowArray(array);
void FillArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}
void ShowArray(int[] arr)
{
    foreach (int element in arr)
    {
        Console.Write($"{element} ");
    }
}



int[] BitArray()
{
    int[] array = new int[8];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 2);
    }
    return array;
}
void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"arr[{i}] = {arr[i]}");
    }
}
int[] a = BitArray();
Print(a);