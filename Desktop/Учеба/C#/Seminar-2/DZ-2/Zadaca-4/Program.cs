// Задача 4: Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.
Console.Write("Введите число для недели ");
int a = int.Parse(Console.ReadLine());

if (a == 1)
{
    Console.WriteLine("Понедельник");
}
if (a == 2)
{
    Console.WriteLine("Вторник");
}
if (a == 3)
{
    Console.WriteLine("Среда");
}
if (a == 4)
{
    Console.WriteLine("Четверг");
}
if (a == 5)
{
    Console.WriteLine("Пятница");
}
if (a == 5)
{
    Console.WriteLine("Пятница");
}
if (a == 6)
{
    Console.WriteLine("Суббота - Выходной");
}
if (a == 7)
{
    Console.WriteLine("Воскресенье - Выходной");
}
if (a > 8 | a < 1)
{
    Console.WriteLine("Не день недели");
}