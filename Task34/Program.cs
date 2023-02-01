// Task 31

// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     array [i] = new Random().Next(-9, 10); // [-9,9]
// }

// void ReleaseArray(int[] array)
// {
//     int summaPositive = 0, summaNegative = 0;
//     foreach (int element in array)
//     {
//         if (element  > 0)
//             summaPositive += element;
//         else
//             summaNegative += element;
//     }
//     Console.WriteLine($"Сумма положительных чисел равна: {summaPositive}"); 
//     Console.WriteLine($"Сумма отрицательных чисел равна: {summaNegative}"); 
// }


// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); 
// ReleaseArray(array);

// Task 32
//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.



// void InputArray(int[] array)
// {
//      for (int i = 0; i < array.Length; i++)
//      array [i] = new Random().Next(-9, 10); // [-9,9]
// }


// void ReleaseArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//          array[i] *= (-1); // array[i] * (-1);
// }
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); 
// ReleaseArray(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");

// Task 33
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// void InputArray(int[] array)

// {
//      for (int i = 0; i < array.Length; i++)
//      array [i] = new Random().Next(-9, 10); // [-9,9]
// }


// string ReleaseArray(int[] array, int number)
// {
//      foreach (int element in array)
//      {
//           if (element == number)
//           return "yes";
//      }
//      return "no";
// }


// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.Write("Ввидите число которое вы ищите внутри массива: ");
// int number =  Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ReleaseArray(array, number));


// Task 35
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

// void InputArray(int[] array)

// {
//       for (int i = 0; i < array.Length; i++)
//       array [i] = new Random().Next(-100, 101); // [-100; 100];
// }

// int ReleaseArray(int[] array)
// {
//      int count = 0;
//      foreach (int element in array)
//      {
//           if (element >= 10 && element <= 99)
//           count++; // count = count + 1;
//      }
//      return count;
// }


// // Console.Write("Введите кол-во элементов массива: ");
// // int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [123];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); 
// Console.WriteLine(ReleaseArray(array));


// Task 37
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

//  void InputArray(int[] array)

// {
//      for (int i = 0; i < array.Length; i++)
//      array [i] = new Random().Next(-9, 10); // [-9,9]
// }


// void ReleaseArray(int[] array)
// {
//      for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
//      Console.Write($"{array[i] * array[array.Length - i - 1]} "); 
// }


// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int [n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); 
// ReleaseArray(array);


// Task 34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

 void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array [i] = new Random().Next(100, 1000);
}

int CountEvenInArray(int[] array)
{
     int count = 0;
     foreach (int element in array)
     {
          if (element % 2 == 0)
          count++; // count = count + 1;
     }
     return count;
}

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); 
Console.WriteLine($"Результат: {CountEvenInArray(array)}"); 
