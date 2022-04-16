// Кратное число
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (b % a == 0) 
{
Console.WriteLine($"Число {b} КРАТНО {a}");
int c = b / a;
Console.WriteLine(c);
}
else
{
Console.WriteLine($"Число {b} НЕ кратно {a}");
}

