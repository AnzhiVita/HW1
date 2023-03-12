// Задача 2

Console.Clear();
Console.Write("Введите 1 число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n > n2)
    Console.WriteLine($"max = {n}");
else
    Console.WriteLine($"max = {n2}");