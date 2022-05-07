//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
int a = -22, b = 99, c = 9;
int max = a;


if( a > max) max = a;
if( b > max) max = b;
if( c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);