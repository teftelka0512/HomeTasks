// Console.WriteLine("Hello, World!");

//Task8

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count;
if (n < 0)
{
    count = -2;
    while (count >= n)
    {
        Console.Write($"{count} ");
        count = count - 2;
    }
}
else
{
    count = 2;
     while (count <= n)
     {
        Console.Write($"{count} ");
        count = count + 2;
     }
}


// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 2; i <=n; i += 2) 
//      Console.WriteLine($"{i} ");