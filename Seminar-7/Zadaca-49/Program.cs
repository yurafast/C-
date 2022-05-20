// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
int m = 4, n = 3;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(-10, 10);
        }
    }

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Print(mass);
Console.WriteLine();
for (int i = 0; i < mass.GetLength(0); i=i+2)
{
    for (int j = 0; j < mass.GetLength(1); j=j+2)
    {
        mass[i,j]= mass[i,j] * mass[i,j];
    }
}

Print(mass);