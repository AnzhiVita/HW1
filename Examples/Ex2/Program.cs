// Задача 4

Console.Clear();

Console.Write("Введите 1 число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3 число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n;

if (n2 > max)
    max = n2;
if (n3 > max)
    max = n3;

Console.WriteLine($"max = {max}");
