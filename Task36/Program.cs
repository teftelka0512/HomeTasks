 // Task 36   Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
 
 void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array [i] = new Random().Next(1, 101);
}

int SummaOddInArray(int[] array)
{
    int summa = 0;
    for (int i = 1; i < array.Length; i+=2)
      summa = summa + array[i];
    return summa;
}
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]"); 
Console.WriteLine($"Результат: {SummaOddInArray(array)}"); 

