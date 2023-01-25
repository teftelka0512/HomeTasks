// Console.WriteLine("Hello, World!");

// Task 20

// Console.Write("Введите X1: ");  
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y1: ");  
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите X2: ");  
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y2: ");  
// double y2 = Convert.ToDouble(Console.ReadLine());
//  double l = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)), 2);
// Console.WriteLine(l);

// Task 21

Console.Write("Введите X1: ");  
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y1: ");  
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z1: ");  
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X2: ");  
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y2: ");  
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z2: ");  
double z2 = Convert.ToDouble(Console.ReadLine());
double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"Результат: {Math.Round(S, 2)}");