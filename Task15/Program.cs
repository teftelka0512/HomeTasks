//Console.WriteLine("Hello, World!");

// Task 15

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 6 || n == 7)
    Console.WriteLine("Выходной день! ");
else
    Console.WriteLine("Будний день! ");