// Task 63      Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// string rec(int n)
// {
//     if (n == 1)
//         return "1 ";
//     return rec(n - 1) + $"{n} ";
// }


// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));

// 2-ой вариант
// void rec(int n)
// {
//     if (n == 1)
//         Console.Write("1 ");
//     else if (n > 1)
//     {
//         Console.Write($"{n} ");
//         rec(n - 1);
//     }
// }


// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// rec(n);


// Task 65       Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// string rec(int a, int b)
// {
//     if (a == b)
//         return $"{a} ";
//     return rec(a, b - 1) + $"{b} ";
// }


// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n, m));

// Task 67      Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// int rec(int a)
// {
//     if (a / 10 == 0 || a < 10 || a % 10 == a)
//         return a;
//     return rec(a / 10) + a % 10;
// }


// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));

// Task 69       Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// int rec(int a, int b)
// {
//     if (b == 0 && a != 0)
//         return 1;
//     return rec(a, b - 1) * a;
// }
// Console.Clear();
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(a, b));


// Task 66          Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

static int SumNumbers(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2;            // Если m = 0
    else if (n == 0) return (m * (m + 1)) / 2;       // Если n = 0
    else if (m == n) return m;                       // Если m = n
    else if (m < n) return n + SumNumbers(m, n - 1); // Если m < n
    else return n + SumNumbers(m, n + 1);            // Если m > n
}

Console.Clear();
Console.Write("m = ");
int M = int.Parse(Console.ReadLine());
Console.Write("n = ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"{SumNumbers(M, N)}");
Console.ReadLine();