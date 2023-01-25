// Console.WriteLine("Hello, World!");

// Task17

// Console.Write("Введите координату X: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// double y = Convert.ToDouble(Console.ReadLine());
// if (x>0 && y>0)
//     Console.WriteLine("I");
// else if (x<0 && y>0)
//     Console.WriteLine("II");
// else if (x<0 && y<0)
// Console.WriteLine("III");
// else
// Console.WriteLine("IV");

// Task 18

// Console.Write("Введите номер четверти: ");    
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 1 || n > 4)
// {
//     Console.Write("Вы ошиблись!\nВведите число: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// if (n == 1)
//     Console.WriteLine("x(0, +∞) and y(0, +∞");
// else if (n == 2)
//     Console.WriteLine("x -∞, 0 and y 0, +∞");
// else if (n == 3)
//     Console.WriteLine("x -∞, 0 and y -∞, 0");
// else
//     Console.WriteLine("x(0, +∞) and y(-∞, 0)");


// Task 19
Console.Write("Введите 5-е число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 10000 || n > 99999)
{
     Console.Write("Вы ошиблись!\nВведите 5-е число: ");
     n = Convert.ToInt32(Console.ReadLine());
}
int n1 = n /10000;
int n2 = (n / 1000) % 10;
int n4 = (n % 100) / 10;
int n5 = n % 10;
if (n1 == n5 && n2 == n4)
    Console.WriteLine($"Ваше число: {n} - палиндром");
else
    Console.WriteLine($"Ваше число: {n} - НЕ палиндром");