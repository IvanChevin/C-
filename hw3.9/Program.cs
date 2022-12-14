// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N 
// до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
int N = new Random().Next(1, 10);
Console.Write(RecNums(N, 1));

string RecNums(int _start, int _end)
{
    if (_start == _end) return _end.ToString();
    return $"{_start} {RecNums(_start - 1, _end)}";
}       */


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int M = new Random().Next(1, 5);
int N = new Random().Next(5, 10);

Console.Write($"M = {M} N = {N}  -> {RecSum(M, N)}");

int RecSum(int _M, int _N)
{
    if (_M == _N) return _M;
    return _M + RecSum(_M + 1, _N);
}       */

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
/*
int m = new Random().Next(1, 4);
int n = new Random().Next(1, 10);

int AckermannFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
    return AckermannFunction(numberM, numberN);
}

Console.Write($"m = {m}, n = {n} -> {AckermannFunction(m, n)}");        */