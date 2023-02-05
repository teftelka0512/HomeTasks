// Task 39         Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// void InputArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// array[i] = new Random().Next(1, 11); // [1, 10]
// }


// void ReleaseElement(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp;
//     }
// }
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); 
// ReleaseElement(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");


// Task 40       Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// Console.Write("Введите 1-е число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-е число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 3-е число: ");
// int c= Convert.ToInt32(Console.ReadLine());
// if (a + b > c && b + c > a && a + c > b)
//   Console.WriteLine("YES");
// else
//   Console.WriteLine("NO");

  // Task 42     Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// String result = String.Empty;
// while (n > 0)
// {
//     result = Convert.ToString(n % 2) + result;
//     n = n / 2;
// }
// Console.WriteLine(result);

// Task 44        Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a0 = 0, a1 = 1, x;
// for (int i = 0; i < n; i++)
// {
//     Console.Write($"{a0} ");
//     x = a0 + a1;
//     a0 = a1;
//     a1 = x;

// }


// Task 45       Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] a = {1, 2, 3, 4, 5};
// int[] b = new int[a.Length];

// for (int i = 0; i < a.Length; i++)
// b[i] = a[i];

// b[0] = 100;
// Console.WriteLine(string.Join(" ", a));
// Console.WriteLine(string.Join(" ", b));

// Task 41       Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
for (int i = 0; i < n; i++)
{
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 0)
count++; // count = count + 1;
}
Console.WriteLine($"Результат: {count}");