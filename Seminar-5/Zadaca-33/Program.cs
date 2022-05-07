// поиск числа в массиве
int[] array = { 1, 2, 3, 4, 5, 6, };
int n = array.Length;
int find = 41;
int index = 0;
bool found = false;
while (index < n)
{
    if (array [index] == find)
    {
        found = true;
        break;
    }
    index ++;
}
if (found==true)
{
    Console.WriteLine("В массиве есть число");
}
else
{
    Console.WriteLine("В массиве НЕТ числа");
}
