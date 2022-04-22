// Задача 23
//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
int n = 7;
int i = 1;
while (i <= n)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
    i++;
}
Console.Write($"{Math.Pow(i, 3)}.");