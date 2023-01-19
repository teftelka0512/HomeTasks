// Console.WriteLine("Hello, World!");

// Task4

Console.Write("Введите 1-е число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int p = Convert.ToInt32(Console.ReadLine()), max = n;
if (n >= m && n >= p)
    Console.WriteLine(n);
else if (m >= n && m >= p)
    Console.WriteLine(m);
else
    Console.WriteLine(p);    

// if (max < m)
//     max = m;
// if (max < p)
//     max = p;
// Console.WriteLine(max);