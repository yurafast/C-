// Программа принимает число, выдает количество цифр в числе
int a = 7777 ;
int count = 0;
while (a > 0)
{
    a = a / 10;
    count  ++ ;
}
Console.WriteLine(count);
