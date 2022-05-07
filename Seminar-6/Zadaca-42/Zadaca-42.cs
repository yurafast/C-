// Напишите программу которая будет переводить число из 10й системы в двоичную
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
string result = String.Empty;
while (a > 0)
{
    result = a % 2 + result;
    a = a / 2;
}
Console.WriteLine(result);

