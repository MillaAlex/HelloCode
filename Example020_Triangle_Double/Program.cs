// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2) Console.Write("Существует");
else Console.Write("Не существует");

bool TriangleCheck(int n1, int n2, int n3)
{
    if (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2) return true;
    else return false;
}
if (TriangleCheck(n1, n2, n3)) Console.Write("Существует");
else Console.Write("Не существует");





// // Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// // 45 -> 101101
// // 3  -> 11
// // 2  -> 10

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
    }
}

void ReverseArray(int[] array)
{
    for (int i = array.Length - 1; i >= 0; i--) Console.Write($"{array[i]}");
}

FillArray(array);
ReverseArray(array);




// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Если N = {num} -> ");

int[] Fibonacci(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
    }
    return array;
}
Console.Write(string.Join(" ", Fibonacci(num)));





// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

int[] FirstArray()
{
    Random random = new Random();
    int[] array = new int[random.Next(1, 10)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 25);
    }
    return array;
}

int[] array = FirstArray();

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}
// Console.WriteLine(string.Join(" ", CopyArray(FirstArray())));

int[] copyArray = CopyArray(array);

void PrintArray(int[] array)
{   
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.Write($"Первый массив: ");
PrintArray(array);
Console.Write($"Второй массив: ");
PrintArray(copyArray);
