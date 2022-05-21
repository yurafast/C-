// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, 
// которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2
int[] mas = new int[12];
void Printo(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(100, 1000);
}

Printo(mas);

int count=0;

for(int i=0; i< mas.Length; i++)
{
    if(mas[i]%2==0)
    {
        count++;
    }
}
Console.WriteLine();

Console.WriteLine($"В массиве {count} четных элементов");