// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
int m, n;
Console.Write($"введите m:");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"введите n:");
int.TryParse(Console.ReadLine()!, out n);

double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        double temp = new Random().Next(-99, 100);
        array[i, j] = temp / 10;
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}       */


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет
/*
int ArrayIndex1 = new Random().Next(5);
int ArrayIndex2 = new Random().Next(5);

int ArraySize1 = new Random().Next(3, 10);
int ArraySize2 = new Random().Next(3, 10);

int[,] array = new int[ArraySize1, ArraySize2];

for (int i = 0; i < ArraySize1; i++)
{
    for (int j = 0; j < ArraySize2; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();
if (ArrayIndex1 > ArraySize1 - 1 || ArrayIndex2 > ArraySize2 - 1)
    Console.Write($"{ArrayIndex1}{ArrayIndex2} -> такого числа в массиве нет");
else Console.Write($"{ArrayIndex1}{ArrayIndex2} -> {array[ArrayIndex1, ArrayIndex2]}");
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ArraySize1 = new Random().Next(3, 10);
int ArraySize2 = new Random().Next(3, 10);
int[,] array = new int[ArraySize1, ArraySize2];
for (int i = 0; i < ArraySize1; i++)
{
    for (int j = 0; j < ArraySize2; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.Write("Среднее арифметическое каждого столбца: ");

for (int j = 0; j < ArraySize2; j++)
{
    double ColumnSum = 0;
    for (int i = 0; i < ArraySize1; i++)
    {
        ColumnSum = ColumnSum + array[i, j];
    }
    double ArithMean = ColumnSum / ArraySize1;
    Console.Write($"{Math.Round(ArithMean, 2)} ");
}