// Ищем максимум из 9ти цифры через функцию
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a=1000, b=2, c=30000, a1=400, b1=225,c1=6, a2=7, b2=18, c2=9;

//int max = Max (a, b, c);
//int max1 = Max (a1, b1, c1);
//int max2 = Max (a2, b2, c2);
//int max3 = Max (max, max1, max2);

int max = Max(Max (a, b, c), Max (a1, b1, c1), Max (a2, b2, c2));

Console.WriteLine(max);
