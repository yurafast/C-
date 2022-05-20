// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого элемента в массиве нет
int m = 4, n = 5;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Введите двухзначное число ");
int index = int.Parse(Console.ReadLine());
//Console.WriteLine(mass[int.Parse(index[0]),int.Parse(index[1])]);
int a = index / 10;
int b = index % 10;
int[] array = new int[2];
array[0] = a;
array[1] = b;

if (array[0] >= m ^ array[1] >= n)
{
    Console.WriteLine("Числа с таким индексом НЕТ");
}

else
{
    Console.WriteLine($"В массиве под индексом [{a},{b}] находится число: {mass[array[0], array[1]]}");
}
