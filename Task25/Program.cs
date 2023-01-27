// Вид 1      Первая группа методов, это методы которые ничего не возвращают и ничего не принимают

// void Method1()
// {
//      Console.WriteLine("Автор..." );
// }

// Method1();

// Вид 2      Это методы которые ничего не возвращяют, но могут принимать какие то аргументы

// void Method2(string msg)
// {
//      Console.WriteLine(msg);
// }
// // Method2("Текст сообщения" );

// void Method21(string msg, int count)
// {
//      int i = 0;
//      while (i < count)
//      {
//           Console.WriteLine(msg);
//           i++;
//      }
// }

// //Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "новый текст" );

// Вид 3          Методы которые что то возвращают, но ничего не принимают

// int Method3()
// {
//      return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// Вид 4           Методы которые что то принимают и что то возвращают

// string Method4(int count, string text)
// {
//      int i = 0;
//      string result = String.Empty;

//       while (i < count)
//       {
//           result = result + text;
//           i++;
//       }
//       return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);


// for

// string Method4(int count, string text)
// {

//       string result = String.Empty;
//        for(int i = 0; i < count; i++)
//        {
//            result = result + text;
//        }
//        return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

// Использование цикла в цикле          Вывод таблицы умножения на экран

// for(int i = 2; i <= 10; i++)
// {
//     for (int j =2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {i * j}" );
//     }
//     Console.WriteLine();
// }

// //===== Работа с текстом
// // Дан текст. В нём нужно все пробелы заменить чёрточками,
// // маленькие буквы «к» заменить большими «К», 
// // а большие «С» заменить на маленькие «с».

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
// + "ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие прусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?";
 

//  // string s = " qwerty "
//  //             012
//  // s [3] // r

//  string Replase(string text, char oldValue, char newValue)
//  {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i= 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
     
//     return result;
//  }

// string newText = Replase(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replase(newText, 'к', 'К');
// newText = Replase(newText,'с', 'С');
// Console.WriteLine(newText);


// // Упорядочить массивы

// // 1. Найти позицию минимального элемента в неотсортированной части массива.
// // 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// // 3. Повторять пока есть неотсортированные элементы.

// int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i+1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);


// String(char)

// string? stroka = Console.ReadLine();
// Console.WriteLine(Convert.ToInt32(stroka[0].ToString()) * 10);

// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [n];
// for (int i = 0; i < array.Length; i++)
//      array[i] = i + 1; // [-10, 10]

// Console.WriteLine($"Результат: [{string.Join(", ", array)}]");     

// Function(void)

// void f(int[] n)
// {
//      n[0] = n[0] + 5;
// }

// int[] n = {1, 2, 3, 4, 5};
// f(n);
// Console.WriteLine(string.Join(" ", n));

// Напишите программу, которая принимает 2 числа и выводит наибольшее

// int f(int a, int b)
// {
//      if (a > b)
//          return a;
//      return b;
// }

// int a = 10, b = 7;
// Console.WriteLine(f(a, b));

// Task 24 Напишите программу, которая принимает на ввод число (А) и выдает сумму чисел от 1 до А

// Console.Write("Введите число: ");
// double n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Результат: {(1 + n) / 2 * n}");

// Task 26 Напишите программу, которая принимает на вход число и выдает количество цифр в числе

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), count = 0;

// while (n > 0)
// {
//      n = n / 10;
//      count++;
// }

//     Console.WriteLine(count);
    
// Task 28 Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), count = 1;
// for (int i = 2; i <= n; i++)
//      count = count * i;

// Console.WriteLine(count);

// Task 25

Console.Write("Введите 1-е число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int m = Convert.ToInt32(Console.ReadLine()), result = 1;
for (int i = 1; i <= m; i++)
    result = result * n;
Console.WriteLine(result);