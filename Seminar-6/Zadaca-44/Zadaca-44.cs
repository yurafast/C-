// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int f1 = 0, f2 = 1,sum;
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.Write($"{f1} {f2} ");
for (int i = 0; i < n; i++)
{
    sum=f1+f2; 
    f1=f2;
    f2=sum;
    Console.Write(sum + " ");
}

