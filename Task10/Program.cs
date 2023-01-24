// Console.WriteLine("Hello, World!");

// Task1

// int n = new Random().Next(10,100); //[10,99]
// Console.WriteLine($"Случайное число: {n} ");
// int n1 = n/10;
// int n2 = n%10;
// if (n1>n2)
//     Console.WriteLine(n1);
// else
//     Console.WriteLine(n2);

// Task2

// int n = new Random().Next(100,1000); //[100,999]
// Console.WriteLine($"Случайное число: {n} ");
// int n1 = n/100;
// int n3 = n%10;
// Console.WriteLine(n1*10+n3);

// Task3

// Console.Write("Введите 1-е число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-е число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n%m == 0)
//     Console.WriteLine("yes");
//     else
//     Console.WriteLine($"no,{n%m}" );

// Task4

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n%161 == 0)   // if (n%7 == 0 && n%23 == 0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// Task4

// Console.Write("Введите 1-е число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-е число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// if (n*n == m || m*m == n)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// Task10

Console.Write("Введите 3-е число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<100 || n>999)
    Console.Write("Вы ошиблись!\nВведите 3-е число: ");
else
    Console.WriteLine(n%100/10);


