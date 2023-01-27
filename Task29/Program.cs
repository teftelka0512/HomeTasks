// Task 29

Console.Write("Введите кол-во элементов массива: ");
 int n = Convert.ToInt32(Console.ReadLine());
 int[] array = new int [n];
 for (int i = 0; i < array.Length; i++)
      array[i] = i + 1;

 Console.WriteLine($"Результат: [{string.Join(", ", array)}]");     
