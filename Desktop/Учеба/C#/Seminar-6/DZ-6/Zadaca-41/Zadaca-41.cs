// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
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