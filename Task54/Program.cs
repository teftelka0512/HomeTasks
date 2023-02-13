// Task 53        Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// void FillMatrix(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = new Random().Next(1, 11);
// }
// }
// }

// void ScreenMatrix(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// Console.Write($"{matrix[i, j]} \t");
// }
// Console.WriteLine();
// }
// }


// void ReleaseMatrix(int[,] matrix)
// {
// int temp = 0;
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// temp = matrix[0, j];
// matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
// matrix[matrix.GetLength(0) - 1, j] = temp;
// }
// }


// Console.Clear();
// Console.Write("Ведите размеры массива: ");
// int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// FillMatrix(matrix);
// ScreenMatrix(matrix);
// Console.WriteLine();
// ReleaseMatrix(matrix);
// ScreenMatrix(matrix);

// Task 55        Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// void FillMatrix(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = new Random().Next(1, 11);
// }
// }
// }
// void ScreenMatrix(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// Console.Write($"{matrix[i, j]} \t");
// }
// Console.WriteLine();
// }
// }

// void ReleaseMatrix(int[,] matrix)
// {
// int temp = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < i; j++)
// {
// temp = matrix[i, j];
// matrix[i, j] = matrix[j, i];
// matrix[j, i] = temp;
// }
// }
// }

// Console.Clear();
// Console.Write("Ведите размеры массива: ");
// int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// while (size[0] != size[1])
// {
//      Console.Write("Вы ошиблись!\nВведите размеры массива: ");

// size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// }
//  int[,] matrix = new int[size[0], size[1]];
// FillMatrix(matrix);
// ScreenMatrix(matrix);
// Console.WriteLine();
// ReleaseMatrix(matrix);
// ScreenMatrix(matrix);

// Task 57       Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// bool checkElement(int[] array, int number)
// {
// foreach (int element in array)
// {
// if (number == element)
// return false;
// }
// return true;
// }

// int FillMatrix(int[,] matrix, int[] HelpArray)
// {
// int k = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// int number = new Random().Next(1, 11);
// matrix[i, j] = number;
// if (checkElement(HelpArray, number) == true)
// {
// HelpArray[k] = number;
// k++;
// }
// }
// }
// return k;
// }

// void ScreenMatrix(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// Console.Write($"{matrix[i, j]} \t");
// }
// Console.WriteLine();
// }
// }

// void ReleaseMatrix(int[,] matrix, int[] array, int count)
// {
// for (int k = 0; k < count; k++)
// {
// int countUnieq = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     if (array[k] == matrix[i, j])
//         countUnieq++;
// }
// }
// Console.WriteLine($"Число {array[k]} встречается {countUnieq} раз");
// }
// }

// Console.Write("Ведите размеры массива: ");
// int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// int[] HelpArray = new int[size[0] * size[1]];
// int k = FillMatrix(matrix, HelpArray);
// ScreenMatrix(matrix);
// Console.WriteLine();
// ReleaseMatrix(matrix, HelpArray, k);

// Task 59        Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// void SwapFirstLastString(int[,] matrix)
// {
//     int minValue = matrix[0, 0], minRow = 0, minColumn = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] < minValue)
//             {
//                 minValue = matrix[i, j];
//                 minRow = i;
//                 minColumn = j;
//             }
//         }
//     }
//     Console.WriteLine($"Минимум {minValue} на позиции({minRow + 1}, {minColumn + 1})");
//     Console.WriteLine();
//     Console.WriteLine("Конечный массив");
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i != minRow && j != minColumn)
//                 Console.Write($"{matrix[i, j]} \t");
//         }
//         if (i != minRow)
//             Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[coord[0], coord[1]];
// Console.WriteLine("Начальный массив");
// InputMatrix(matrix);
// SwapFirstLastString(matrix);

// Task 54

	void InputMatrix(int[,] matrix)
	{
	    for (int i = 0; i < matrix.GetLength(0); i++)
	    {
	        for (int j = 0; j < matrix.GetLength(1); j++)
	            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
	    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}


Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный двумерный массив: ");
PrintMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);
Console.WriteLine("Конечный двумерный массив: ");
PrintMatrix(matrix);