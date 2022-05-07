// Прогрессия Фибаначи через рекурсию
// f0=0
// f1=1
// f2=1
// fn=f(n-1)+f(n-2)

double Fibonaci(int n)
{
    if (n == 1 | n == 2) return 1;
    else return Fibonaci(n - 1) + Fibonaci(n - 2);
}
for (int i = 1; i < 50; i++)
{
 Console.Write(Fibonaci(i)+ " ");   
}