// Координаты
double X = new Random().Next(-100 , 100);
double Y = new Random().Next(-100 , 100);
Console.WriteLine(X);
Console.WriteLine(Y);
if(X < 0 & Y < 0)
{
    Console.WriteLine("Точка находится в 3й четверти");
} 
if(X > 0 & Y > 0)
{
    Console.WriteLine("Точка находится в 1й четверти");
} 
if(X < 0 & Y > 0)
{
    Console.WriteLine("Точка находится в 2й четверти");
} 
if(X > 0 & Y < 0)
{
    Console.WriteLine("Точка находится в 4й четверти");
} 
if (X == 0 & Y == 0)
{
    Console.WriteLine("Точка НЕ в четверти");
} 