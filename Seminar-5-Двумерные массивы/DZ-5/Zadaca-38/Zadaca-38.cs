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
