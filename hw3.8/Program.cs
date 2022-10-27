// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
int ArraySize1 = new Random().Next(3, 10);
int ArraySize2 = new Random().Next(3, 10);
int[,] array = new int[ArraySize1, ArraySize2];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int k = 0; k < array.GetLength(1) - 1; k++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[i, j] < array[i, j + 1])
            {
                int temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
            }
        }
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}       */

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка

/*
int ArraySize1 = new Random().Next(3, 10);
int ArraySize2 = new Random().Next(3, 10);
int[,] array = new int[ArraySize1, ArraySize2];
int min = ArraySize2 * 9;
int Size1Number = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
        sum = sum + array[i, j];
    }
    Console.WriteLine();
    if (sum < min)
    {
        min = sum;
        Size1Number = i;
    }
}
Console.WriteLine();
Console.Write($"{Size1Number} строка");     */

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
int ArraySize1 = new Random().Next(2, 5);
int ArraySize2 = new Random().Next(2, 5);
int ArraySize3 = new Random().Next(2, 5);
int[,] array1 = new int[ArraySize1, ArraySize2];
int[,] array2 = new int[ArraySize2, ArraySize3];
int[,] array3 = new int[ArraySize1, ArraySize3];


void FillArray(int[,] _array)
{
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            _array[i, j] = new Random().Next(10);
            Console.Write($"{_array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

FillArray(array1);
FillArray(array2);

for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            array3[i, j] += array1[i, k] * array2[k, j];
        }
        Console.Write($"{array3[i, j]} ");
    }
    Console.WriteLine();
}       */

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)
/*
int ArraySize1 = new Random().Next(2, 4);
int ArraySize2 = new Random().Next(2, 4);
int ArraySize3 = new Random().Next(2, 4);
int[,,] array = new int[ArraySize1, ArraySize2, ArraySize3];

int[] nums = new int[90];
for (int i = 0; i < nums.GetLength(0); i++)
{
    nums[i] = i + 10;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            while (array[i, j, k] == 0)
            {
                int temp = new Random().Next(nums.GetLength(0));
                array[i, j, k] = nums[temp];
                nums[temp] = 0;
            }
            Console.Write($"{array[i, j, k]} ({i}, {j}, {k})");
        }
        Console.WriteLine();
    }
}       */



// Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int ArraySize = new Random().Next(4, 10);
int[,] array = new int[ArraySize, ArraySize];

for (int i = 0, j = 0, t = 0; t < array.Length; t++)
{
    array[i, j] = t + 1;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
    else i--;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(string.Format("{0:D2} ", array[i, j]));
    }
    Console.WriteLine();
}