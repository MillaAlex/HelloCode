Console.Write("Enter username: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hurray, this is Masha!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}