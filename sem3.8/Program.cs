﻿/*         **Задача 53:** Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2             */

/*         int m = 6, n = 7;
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < array.GetLength(1); i++)
{
    int temp = array[0, i];
    array[0, i] = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = temp;
}

Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]} ");
    Console.WriteLine();
}       */

/*         **Задача 53:** Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2             */

/*      int m = 6, n = 7;

List<List<int>> list = new List<List<int>>();

for (int i = 0; i < m; i++)
{
    list.Add(new List<int>());
    for (int j = 0; j < n; j++)
    {
        list[i].Add(new Random().Next(10));
        Console.Write($"{list[i][j]} ");
    }
    Console.WriteLine();
}

List<int> temp = list[0];
list[0] = list[list.Count - 1];
list[list.Count - 1] = temp;

Console.WriteLine();
for (int i = 0; i < list.Count; i++)
{
    for (int j = 0; j < list[i].Count; j++)
        Console.Write($"{list[i][j]} ");
    Console.WriteLine();
}       */



/*        **Задача 55:** Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7                    */
/*        int m = 4, n = 5;
int[,] array = new int[m, n];
array = FillArray(m, n);

int[,] array2 = new int[n, m];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array2[j, i] = array[i, j];
    }
}




PrintArray(array2);






int[,] FillArray(int sizeM, int sizeN, int min = 0, int max = 10)
{
    int[,] _array = new int[sizeM, sizeN];
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            _array[i, j] = new Random().Next(min, max);
            Console.Write($"{_array[i, j]} ");
        }
        Console.WriteLine();
    }
    return _array;
}

void PrintArray(int[,] _array)
{
    Console.WriteLine();
*/
/*
int[,] FillArray(int sizeM, int sizeN, int min = 0, int max = 10)
{
    int[,] _array = new int[sizeM, sizeN];
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            _array[i, j] = new Random().Next(min, max);
            Console.Write($"{_array[i, j]} ");
        }
        Console.WriteLine();
    }
    return _array;
}

void PrintArray(int[,] _array)
{
    Console.WriteLine();
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
            Console.Write($"{_array[i, j]} ");
        Console.WriteLine();
    }
}
}       */
/*
List<List<int>> FillList(int sizeM, int sizeN, int min = 0, int max = 10)
{
    List<List<int>> _list = new List<List<int>>();
    for (int i = 0; i < m; i++)
    {
        _list.Add(new List<int>());
        for (int j = 0; j < n; j++)
        {
            _list[i].Add(new Random().Next(10));
            Console.Write($"{_list[i][j]} ");
        }
        Console.WriteLine();
    }
    return _list;
}

void PrintList(List<List<int>> _list)
{
    Console.WriteLine();
    for (int i = 0; i < _list.Count; i++)
    {
        for (int j = 0; j < _list[i].Count; j++)
            Console.Write($"{_list[i][j]} ");
        Console.WriteLine();
    }
}       */

/*
List<int> temp = new List<int>();
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (!temp.Contains(arr[i, j]))
            temp.Add(arr[i, j]);

    }
}
foreach (var item in temp)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (item == arr[i, j])
            {
                count++;
            }
        }
    }
    Console.WriteLine($"{item} встречается раз - {count}");
}
*/
/*        **Задача 57:** Составить частотный словарь элементов двумерного 
массива. Частотный словарь содержит информацию о том, сколько раз 
встречается элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза                    */

/*
int m = 4, n = 5;
int[,] array = new int[m, n];
array = FillArray(m, n);
Console.WriteLine();
//int[,] array2 = new int[n, m];

for (int i1 = 0; i1 < m; i1++)
{
    for (int j1 = 0; j1 < n; j1++)
    {
        int k = 0;
        int temp = array[i1, j1];
        if (temp != -1)
        {
            for (int i2 = 0; i2 < m; i2++)
            {
                for (int j2 = 0; j2 < n; j2++)
                {
                    if (temp == array[i2, j2])
                    {
                        array[i2, j2] = -1;
                        k++;
                    }
                }
            }
            Console.Write($"{temp} встречается {k} раз\n");
        }
    }
}   */
/*
int m = 4, n = 5;
int[,] array = new int[m, n];
array = FillArray(m, n, 90, 100);
Console.WriteLine();


int max = array[0, 0];

foreach (var item in array)
    if (max < item)
        max = item;

int[] array2 = new int[max + 1];

foreach (var item in array)
    array2[item]++;

for (int i = 0; i < array2.Length; i++)
    if (array2[i] != 0)
        Console.Write($"{i} встречается {array2[i]} раз\n");
*/
/*
int m = 4, n = 5;
int[,] array = new int[m, n];
array = FillArray(m, n, 90, 100);
Console.WriteLine();


int max = array[0, 0];
int min = array[0, 0];


foreach (var item in array)
{
    if (max < item)
        max = item;
    if (min > item)
        min = item;
}
int[] array2 = new int[max + 1 - min];

foreach (var item in array)
{
    array2[item - min]++;
}

for (int i = 0; i < array2.Length; i++)
    if (array2[i] != 0)
        Console.Write($"{i + min} встречается {array2[i]} раз\n");
*/

/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
int m = 4, n = 5;
double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        double t = new Random().NextDouble() * 20 - 10; // задание массива double через NextDouble
        array[i, j] = Math.Round(t, 1);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        Console.Write($"{array[i, j]}  ");
    Console.WriteLine();
}       */
