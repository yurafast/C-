// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.
int m = 4, n = 5;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(1,10);
        }
        Console.WriteLine();
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

int temp;
Console.WriteLine();
if (m==n)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        
        for (int j = i; j < mass.GetLength(1); j++)
        {
            temp=mass[i,j];
            mass[i,j]=mass[j,i];
            mass[j,i]=temp;
        }
    
    }
}
else
{
    Console.WriteLine("Перевернуть массив нельзя");
}
Print(mass);