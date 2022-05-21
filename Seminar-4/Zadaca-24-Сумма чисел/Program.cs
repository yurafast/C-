//Задача 24. Напишите программу, которая на принимает число А и выдает сумму чисел от 1 до А
Console.Clear();
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());

int SummaofNum(int A)
{
    int sum = 0;
    for(int i = 1; i <= A; i++) // i = i +1 - тоже самое i++
    {
        Console.Write(i + " ");
        sum = sum + i; // sum = sum + i - тоже самое можно записать sum += i
    }
    return sum;
}
Console.WriteLine("");
Console.WriteLine("Cумма чисел равна: " + SummaofNum(A));