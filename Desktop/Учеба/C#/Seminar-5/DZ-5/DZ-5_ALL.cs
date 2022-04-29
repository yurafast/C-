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


// Задача 36: Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] mas = new int[10];

void Printo(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(1, 100);
}

Printo(mas);

int sum=0;

for(int i=0; i< mas.Length; i++)
{
    if(mas[i]%2==0)
    {
        sum=sum+mas[i];
    }
}
Console.WriteLine();

Console.WriteLine($"Сумма четных эллементов массива равна: {sum}");

// Задача 38: Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.
//[3 7 22 2 78] -> 76


int[] arr = new int[16];
Console.Clear();
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 100);
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPossition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPossition])
            {
                minPossition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPossition];
        array[minPossition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
int razn = arr[arr.Length-1] - arr[0];
Console.WriteLine($"Разница между MAX и MIN элементами равна: {razn}");
