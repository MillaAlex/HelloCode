string NumbersRec(int a, int b)    //Recoursing
{
    if (a <= b) return ($"{a} " + NumbersRec(a + 1, b));
    else return String.Empty;
}
Console.WriteLine(NumbersRec(1, 10));


string NumbersFor(int a, int b)    //cycle FOR
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += ($"{i} ");
    }
    return result;
}
Console.WriteLine(NumbersFor(1, 10));


string NumbersRec(int a, int b)    //Recoursing a>b
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return String.Empty;
}
Console.WriteLine(NumbersRec(1, 10));


string NumbersFor(int a, int b)    //cycle FOR a>b
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}
Console.WriteLine(NumbersFor(10, 1));