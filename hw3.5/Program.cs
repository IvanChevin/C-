/*int[] CreateArray(int size, int min = 0, int max = 100)
{
    int[] _array = new int[size];
    for (int i = 0; i < size; i++)
        _array[i] = new Random().Next(min, max);
    return _array;
}

void PrintArray(int[] _array)
{
    foreach (var item in _array)
        Console.Write($"{item} ");
}       */

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*      int[] array = CreateArray(5, 100, 999);
PrintArray(array);
Console.WriteLine();
int chet = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        chet++;
}
Console.Write(chet);        */

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*      int[] array = CreateArray(4);
PrintArray(array);
Console.WriteLine();
int sum = 0;
for (int i = 1; i < array.Length; i += 2)
{
    sum += array[i];
}
Console.Write(sum);     */

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] arrayDouble = CreateArrayDouble(5);
PrintArrayDouble(arrayDouble);
Console.WriteLine();

double max = arrayDouble[0], min = arrayDouble[0];
for (int i = 0; i < arrayDouble.Length; i++)
{
    if (arrayDouble[i] > max) max = arrayDouble[i];
    else if (arrayDouble[i] < min) min = arrayDouble[i];
}
Console.Write(max - min);



double[] CreateArrayDouble(int size, int min = 0, int max = 100)
{
    double[] _array = new double[size];
    for (int i = 0; i < size; i++)
    {
        double temp = new Random().Next(min, max);
        _array[i] = temp / 10;
    }
    return _array;
}

void PrintArrayDouble(double[] _array)
{
    foreach (var item in _array)
        Console.Write($"{item} ");
}
