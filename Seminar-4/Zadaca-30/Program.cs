// Задача 30. Напишите программу, которая выводит массив
// из 8 элементов заполенный нулями и единицами в случайном порядке. 
// А потом суммирует положительные и отридцательные значения

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
        Console.Write(array[i] + " ");
    }
}

int[] mass = new int[12];
Print(mass);

int summPos = 0;
int summNeg = 0;

for(int i=0; i<mass.Length; i++)
{
    if(mass[i] > 0)
    {
        summPos+=mass[i];
    }
    else
    {
        summNeg+=mass[i];
    }
}
Console.WriteLine($"Сумма положительных {summPos}, Сумма отридцательных {summNeg}");