// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
int m = 3, n= 3;
int[,] array= new int[m,n];

void Print(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i,j]=new Random().Next(0,10);
            Console.Write(mass[i,j] + " ");
        }
        Console.WriteLine();    
    } 
}
Print(array);
int temp;
for (int i = 0; i < m-1; i++)
{
    temp=array[0,i];
    array[0,i]=array[array.GetLength(0)-1,i];
    array[array.GetLength(0)-1,i]=temp;
}
Print(array);