// Напишите программу принимает N, выдает произведение от 1 до N
Console.Clear();
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int mul = 1;
for (int i = 1; i <= N; i++)
{
    mul = mul * i;

}
Console.WriteLine("Произведение чисел равно: " + mul);