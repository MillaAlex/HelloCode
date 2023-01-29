//recursion - Fibonacci

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}


//cycle WHILE - Fibonacci

int fib1 = 1;
int fib2 = 1;
 
Console.Write("Номер элемента ряда Фибоначчи: ");
int n = Convert.ToInt32(Console.ReadLine());
 
int i = 0;
while (i < n - 2)
{
    int fib_sum = fib1 + fib2;
    fib1 = fib2;
    fib2 = fib_sum;
    i++;
}
Console.Write($"Значение этого элемента: {fib2}");