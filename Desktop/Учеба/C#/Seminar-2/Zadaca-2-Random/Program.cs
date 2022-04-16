// Случайное число
int a = new Random().Next(10,99);
int b = a / 10;
int c = a%10;
int max = b;
if (c > b ) max = c;
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine($"Максимальное число {max}");

