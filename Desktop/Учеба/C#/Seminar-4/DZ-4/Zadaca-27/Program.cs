// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11, 82 -> 10, 9012 -> 12
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int summ = 0;
int b = a % 10;
while (a > 0)
{
    summ = summ + b;
    a = a / 10;
    b = a % 10;
}
Console.WriteLine($"Сумма цифр числа равна: {summ}");