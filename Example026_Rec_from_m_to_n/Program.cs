// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumbers(M, N));

string PrintNumbers(int start, int end)
{
    if (start == end) return Convert.ToString(start);    
    return (start + " " + PrintNumbers(start + 1, end));
}





// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

Console.WriteLine(PrintNumbers(N, sum));

int PrintNumbers(int N, int sum)
{
    if (N == 0) return (sum); 
    sum = sum + N % 10;
    N = N / 10; 
    return (PrintNumbers(N, sum));
}





// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int count = 0;
int result = 1;
Console.WriteLine(NumToDegree(A, B, count, result));

int NumToDegree(int A, int B, int count, int result)
{
    if (count == B) return result;
    result = result * A; 
    count++; 
    return (NumToDegree(A, B, count, result));
}





Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int PowNum(int a, int b)
{
    if (b == 1) return a;
    return a * PowNum(a, b - 1);
}

Console.WriteLine(PowNum(A, B));