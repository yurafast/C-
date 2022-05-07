// Напишите программу, которая принимает 3 числа и проверяет могут ли они быть длиннами треугольника
Console.WriteLine("Введите Первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Третье число: ");
int c = int.Parse(Console.ReadLine());
if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Треугольник может быть");
}
else
{
    Console.WriteLine("Треугольник бытьНЕ может");
}