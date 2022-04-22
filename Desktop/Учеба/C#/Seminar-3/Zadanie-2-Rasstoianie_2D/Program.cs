// Вводим координаты 2х точек и находим расстояние между точками
Console.Clear();
Console.WriteLine("Введите координаты 1й точки");
Console.Write("X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Y2: ");
int y2 = int.Parse(Console.ReadLine());
double lenght = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние между точками равно {lenght}");