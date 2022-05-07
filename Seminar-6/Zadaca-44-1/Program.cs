// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число N: ");
int n=int.Parse(Console.ReadLine());
int[] mass = new int[n];
mass[0] = 0;
mass[1] = 1;
Console.Write(mass[0] + " " + mass[1]+ " ");
for (int i = 2; i < n; i++)
{
    mass[i] = mass[i - 1] + mass[i - 2];
    Console.Write(mass[i] + " ");
}
Console.WriteLine();
