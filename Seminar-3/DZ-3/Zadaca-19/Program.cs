﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
int a = 15651;
int b = (a / 1000) % 10;
int c = (a % 100) / 10;
if (a / 10000 == a % 10 & b == c)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
