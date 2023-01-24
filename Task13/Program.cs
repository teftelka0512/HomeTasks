// Console.WriteLine("Hello, World!");

// Task 13

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
    Console.WriteLine("Третьей цифры нет!");
else
{
    while ( n >= 999)
    {
        n = n / 10;
    }
    Console.WriteLine(n);
    Console.WriteLine(n % 10);
}
