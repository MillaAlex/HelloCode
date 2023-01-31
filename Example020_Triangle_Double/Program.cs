// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите первое число: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int n3 = Convert.ToInt32(Console.ReadLine());

// if (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2) Console.Write("Существует");
// else Console.Write("Не существует");

// bool TriangleCheck(int n1, int n2, int n3)
// {
//     if (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2) return true;
//     else return false;
// }
// if (TriangleCheck(n1, n2, n3)) Console.Write("Существует");
// else Console.Write("Не существует");





// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num} -> ");

int[] PrintArray(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 2;
        count++;  
    }
    int[] array = new int[count];
    return array;
}
int[] array = PrintArray(num);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++, num /= 2)
    {
        array[i] = num % 2;
        // Console.Write(array[i]);
    }
}

void ReverseArray(int[] array)
{
    for (int i = array.Length - 1; i >= 0; i--)
    {
        Console.Write($"{array[i]}");
    }
}

FillArray(array);
ReverseArray(array);