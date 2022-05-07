// Задача 32.Напишите программу замена элементов
//массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]
int[] mass = new int[12];

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
           Console.Write(array[i] + " ");
    }
}

for(int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-9, 10);
} 

Print(mass);

Console.WriteLine();
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = mass[i] * -1;
}
Print(mass);


