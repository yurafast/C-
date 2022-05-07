// задать массив и поменять элементы местами. Первый с последним и т.д.
int[] arr = new int[12];

void Print(int []array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 100);
}

Print(arr);
for (int i = 0; i < arr.Length/2; i++)
{
    int temp = arr[i];
    arr[i] = arr[arr.Length - 1-i];
    arr[arr.Length-1-i] = temp;
}

Print(arr);