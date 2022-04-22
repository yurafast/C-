//Задача 2: Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int a = 918;
int b = a%10;
int c = a / 100;
Console.Write(c);
Console.Write(b);

//Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. 645 -> 5,  78 -> третьей цифры нет, 32679 -> 6
Console.Clear(); 
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a < 100)
{

    Console.WriteLine("Третьей цифры нет");
}
if (a >= 1000)
{
    while (a > 1000)
    {
        a = a / 10;
    }
    Console.WriteLine($"Третья цифра числа {a%10}");
}

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
