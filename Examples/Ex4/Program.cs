// Задача 8:

Console.Clear();

Console.Write("Введите 1 число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= n; i+=2) // i = i + 2
    Console.WriteLine($"{i}");
for (int i = -2; i >= n; i-=2) // i = i + 2
    Console.WriteLine($"{i}");