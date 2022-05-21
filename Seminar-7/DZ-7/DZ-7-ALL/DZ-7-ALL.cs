// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3;
int n = 4;
double[,] mass = new double[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = Math.Round(new Random().NextDouble() * (20 - 40),2);
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}

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


// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.
int m = 5, n = 4, summ = 0;
double sred = 0;
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
double size = mass.GetLength(0);
for (int j = 0; j < mass.GetLength(1); j++)
{
    for (int i = 0; i < size; i++)
    {
        summ = summ + mass[i, j];
    }
    sred = summ / size;
    Console.Write(sred + " ");
    summ = 0;
}
