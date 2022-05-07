// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2 или -1, -7, 567, 89, 223-> 3
Console.Write("Введите числа через пробел: ");
string text = Console.ReadLine();
string[] arr = text.Split(" ");
Console.WriteLine();
Console.Write("Вы ввели следующие числа: ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
int[] mass = new int[arr.Length];
int summ = 0;
for (int i = 0; i < arr.Length; i++)
{
    mass[i] = int.Parse(arr[i]);

    if (mass[i] > 0)
    {
        summ = summ + mass[i];
    } 
}
Console.WriteLine($"Сумма положительных чисел равна {summ}");

// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


Console.Write("Введите число b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine();

if (k1 == k2)
{
    Console.WriteLine("Прямые НЕ пересекаются");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"точка пересечения прямых ({x} ; {y})");
}