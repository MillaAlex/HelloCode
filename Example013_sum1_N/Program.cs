// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());

int Sum(int sum)
{
    int count = 0;
    for (int i = 1; i <= sum; i++)
    {
        count += i;
    }
    return count;
}

Console.WriteLine($"Сумма чисел от 1 до {A} равна {Sum(A)}");