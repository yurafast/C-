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

int sum = 0;

for (int i = 0; i < mas.Length; i = i + 2)
{
    sum = sum + mas[i];
}
Console.WriteLine();

Console.WriteLine($"Сумма эллементов на нечетных позициях равна: {sum}");