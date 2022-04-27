// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите количество строк в заданном массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в заданном массиве");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
// заполнение массива и печать
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
    array[i, j] = new Random().Next(0,11);
    Console.Write(array[i,j]+" ");
    }
}
// подсчёт сумм элементов построчно
Console.WriteLine();
int minsummline = 1;
int summline = 0;
 for (int j = 0; j < array.GetLength(1); j++)
        {
            summline = summline + array[0,j];
        }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i,j];
        }
        if (summ < summline) 
        {
            summline = summ;
            minsummline = i+1;
        }
    }
Console.WriteLine($"Строка с наименьшей суммой элементов - {minsummline}");