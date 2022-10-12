// Задача 25: Напишите функцию, используя цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*    int a, b;
Console.Write($"введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);

Console.Write($"{stepen(a, b)}");

int stepen(int _a, int _b)
{
    int proizv = 1;
    for (int i = 1; i <= _b; i++)
        proizv *= _a;
    return proizv;
}       */

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*  Console.Write($"введите число: ");
string a = Console.ReadLine()!;
Console.Write($"{Sum(a)}");

int Sum(string _a)
{
    int _sum = 0;
    int _len = _a.Length;
    int.TryParse(_a, out int _znachenie);
    for (int i = 0; i < _len; i++)
    {
        _sum = _sum + _znachenie % 10;
        _znachenie = _znachenie / 10;
    }
    return _sum;
}   */

// Задача 29: Напишите функцию, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
FillArray(array);

void FillArray(int[] _array)
{
    int len = _array.Length;
    for (int i = 0; i < len; i++)
    {
        _array[i] = new Random().Next(100);
        Console.Write($"{_array[i]} ");
    }
}