// Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех чисел на
// группы, так чтобы в одной группе все числа были взаимно просты (все числа в группе друг на
// друга не делятся)? Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰.

void PrintG(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.Write($"Группа {i + 1}: ");
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (mass[i, j] == 0)
                break;
            Console.Write(mass[i, j] + " ");
        }
        Console.WriteLine();
    }
}
bool Check(int c, int d)
{
    return (c % d == 0 || d % c == 0);
}
int LinesCount(int x)
{
    int line = 0;
    int count = 1;
    while (count < x)
    {
        count *= 2;
        line++;
    }
    return line;
}

int x = 50;

int[,] mass = new int[LinesCount(x), (int)Math.Ceiling((decimal)x/3)];

int l = 0;

for (int i = 1; i <= x; i++)
{
    for (int m = 0; m < mass.GetLength(1); m++)
    {
        if (mass[l, m] == 0)
        {
            mass[l, m] = i;
            l = 0;
            break;
        }
        else if (Check(i, mass[l, m]))
        {
            l++;
            m = -1;
            continue;
        }
    }
}
PrintG(mass);
