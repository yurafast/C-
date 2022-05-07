// Сортировка Массива
int[] arr = { 0, 20, 3, 7, 6, 5, 3};
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
void SelectionSort(int[]array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPossition = i;

        for (int j =i+ 1; j < array.Length; j++)
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