// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();
Console.Write("Введите цифры: ");
string s = Console.ReadLine();

for (int i = 0; i < s.Length; i++)
{
    Console.Write(s[i]+ " ");
}