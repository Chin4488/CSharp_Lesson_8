// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
void PrintArray(int[,] array) // метод печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] array) // метод заполнение массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
Console.WriteLine("Введите количество строк в заданном массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в заданном массиве");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arrayinput = new int[m,n];
FillArray(arrayinput);
Console.WriteLine("Входной массив:");
PrintArray(arrayinput);
int[,] arraysort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int tempj = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, tempj]) tempj = k;
            }
            int selection = array[i, j];
            array[i, j] = array[i, tempj];
            array[i, tempj] = selection;
        }
    }
    return array;
}
Console.WriteLine("Сортировка строк по убыванию:");
PrintArray(arraysort(arrayinput));