// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
int m = 3, n = 3;

int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}

void Print(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Print(array);
Console.WriteLine();
int temp;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int k = j + 1; k < array.GetLength(1); k++)
        {
            if (array[i, j] < array[i, k])
            {
                temp = array[i, k];
                array[i, k] = array[i, j];
                array[i, j] = temp;
            }
        }
    }
}


Print(array);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.
// int m = 3, n = 4;
int m = 3, n = 4;

int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}
Console.WriteLine("Первоначальный массив");

void Print(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Print(array);
Console.WriteLine();

int[] summ = new int[array.GetLength(1)];

for (int a = 0; a < array.GetLength(0); a++)
{
    for (int b = 0; b < array.GetLength(1); b++)
    {
        summ[a] = summ[a] + array[a, b];
    }
    Console.WriteLine($"Сумма {a + 1} cтроки равна: {summ[a]}");
}
int temp;
for (int i = 0; i < summ.Length; i++)
{
    for (int j = 0; j < summ.Length-1; j++)
    {
        if(summ[j]>summ[j+1])
        {
            temp=summ[j+1];
            summ[j+1]=summ[j];
            summ[j]=temp;
        }
    }
}
Console.Write($"Минимальная сумма строки равна: {summ[1]}");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

Console.Clear();
Console.WriteLine("Матрица А");
Console.Write("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Матрица B");
Console.Write("Введите кол-во строк: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int b = int.Parse(Console.ReadLine());
int[,] arrayB = new int[a, b];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        arrayB[i, j] = new Random().Next(0, 10);
        Console.Write(arrayB[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Матрица C");
int[,] arrayC = new int[array.GetLength(0), arrayB.GetLength(1)];
int Sum=0;
if (n != b)
{
    Console.WriteLine($"Матрицы не совместимы,т.к. {n} не равно {b}");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < arrayB.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Sum = Sum+ (array[i,k]*arrayB[k,j]);
        }
        arrayC[i,j]=Sum;
        Sum=0;
    }
}
for (int i = 0; i < arrayC.GetLength(0); i++)
{
    for (int j = 0; j < arrayC.GetLength(1); j++)
    {
        Console.Write(arrayC[i,j]+ " ");
    }
    Console.WriteLine();
}
