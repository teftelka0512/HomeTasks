	// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
	// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
	// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
	// лучше обойтись исключительно массивами.
	// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
	// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
	// [“Russia”, “Denmark”, “Kazan”] → []



// string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
// string[] array2 = new string[array1.Length];
// void SecondArrayWithIF(string[] array1, string[] array2)
// {
//     int count = 0;
//     for (int i = 0; i < array1.Length; i++)
//     {
//     if(array1[i].Length <= 3)
//         {
//         array2[count] = array1[i];
//         count++;
//         }
//     }
// }
// void PrintArray(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// SecondArrayWithIF(array1, array2);
// PrintArray(array2);


// using System;
					
// public class Program
// {
// 	public static void Main()
// 	{
// 		string[] arr1 = {"Hello", "2", "world", ":-)"};
// 		string[] arr2 = {"1234", "1567", "-2", "computer science"};
// 		string[] arr3 = {"Russia", "Denmark", "Kazan"};
		
// 		int MAX_WORD_LENGTH = 3;
		
// 		string[] GetShortWordsArray(string[] array)
// 		{
// 			int length = array.Length;			
// 			string[] result = new string[length];
// 			int count = 0;
			
// 			for (int i = 0; i < length; i++)
// 			{
// 				if(array[i].Length <= MAX_WORD_LENGTH)
// 				{
// 					result[count] = array[i];
// 					count++;
// 				}
// 			}
// 			Array.Resize(ref result, count);
			
// 			return result;
// 		}
		
// 		void PrintArray(string[] array)
// 		{
// 			if(array.Length == 0)
// 			{
// 				Console.WriteLine("Array is empty");
// 			}
// 			else
// 			{
// 				Array.ForEach(array, (str) => Console.Write($"{str} "));
// 				Console.WriteLine();
// 			}
// 		}
		
// 		void PrintTask(string[] array)
// 		{
// 			Console.WriteLine("Source array:");
// 			PrintArray(array);
// 			string[] shortArray = GetShortWordsArray(array);
// 			Console.WriteLine($"Result array (words are less or equal than {MAX_WORD_LENGTH} symbols)");
// 			PrintArray(shortArray);
// 			Console.WriteLine();
// 		}
		
// 		PrintTask(arr1);
// 		PrintTask(arr2);
// 		PrintTask(arr3);
// 	}
// }

using System;
using static System.Console;

Clear();

string[] array = AskArray();
string[] result = FindLessThan(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindLessThan(string[] input, int n) {
    string[] output = new string[CountLessThan(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLessThan(string[] input, int n) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}

string[] AskArray() {
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}