//Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.
int m = 4, n = 5;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 10);
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

Console.Write("Введите искомый элемент: ");
int a = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i, j] == a)
        {
            count++;
        }
    }
}
if (count == 0)
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Число {a} встерчается {count} раз");
}