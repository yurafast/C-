// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 6; N = 2. -> "6, 5, 4, 3, 2"
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

void Func(int c, int d)
{
    if (c == d)
    {
        Console.Write(c);
        return;
    }
    
    else if (c < d)
    {
        Console.Write(c + " ");
        Func(c + 1, d);
    }

    else
    {
        Console.Write(c + " ");
        Func(c - 1, d);
    }

}
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n : ");
int n = int.Parse(Console.ReadLine());
Func(m, n);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Func(int c, int d)
{
    if (c == d)
        return c;

    return d + Func(c, d - 1);
}

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n : ");
int n = int.Parse(Console.ReadLine());
int sum = Func(m, n);
Console.WriteLine(sum);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
int A(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
        if ((m > 0) && (n == 0))
        return A(m - 1, 1);
            else
                return A(m - 1, A(m, n - 1));
    
}
int result = A(2, 2);
Console.WriteLine(result);
