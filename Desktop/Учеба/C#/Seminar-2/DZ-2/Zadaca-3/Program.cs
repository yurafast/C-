﻿//Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. 645 -> 5,  78 -> третьей цифры нет, 32679 -> 6
Console.Clear(); 
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a < 100)
{

    Console.WriteLine("Третьей цифры нет");
}
if (a > 1000)
{
    while (a > 1000)
    {
        a = a / 10;
    }
    Console.WriteLine($"Третья цифра числа {a%10}");
}

