// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// int QuantityOfNumbers(int number)
// {
//     int counter = 0;
//     while (number > 0)
//     {
//         counter++;
//         number /= 10;
//     }
//     return counter;
// }
// Console.WriteLine($"Количество цифр в числе {number} -> {(QuantityOfNumbers(number))}");



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

// int[] random_array = new int[8];
// for (int i = 0; i < random_array.Length; i++)
// {
//     random_array[i] = new Random().Next(0,2);
//     Console.WriteLine(random_array[i]);
// }

