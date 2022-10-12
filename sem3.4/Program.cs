// Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36 

/*
int a = 0;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

int sum = 0;
for (int i = 1; i <= a; i++)
sum += i;

Console.Write($"Сумма чисел от 1 до {a} = {sum}");
*/
/*
int a = 0;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write($"Сумма чисел от 1 до {a} = {Sum(a)}");

int Sum(int _a) // метод (функция)
{
    int sum = 0;
    for (int i = 1; i <= _a; i++)
        sum += i;
    return sum;
}
*/


// Чтото про типы данных..

// int Max(int a, int b)
// {
// if (a > b)
// return a;
// return b;
// }

// double Div(int a, int b)
// {
// return (double)a / (double)b;
// }

// string Output(string text)
// {
// return $"+{text}+";
// }

// bool IsEven(int a)
// {
// if (a % 2 == 0)
// return true;
// return false;
// }

// int[] CreateArray(int size)
// {
// int[] _array = new int[size];
// return _array;
// }

// void print(string _text)
// {
// Console.Write(_text);
// return;
// }

// print($"Это использование функции void");

// Чтото про глобальные переменные
/*
int G_i = 0;
string G_str = "";

Max(5);

Console.Write($"{G_i} {G_str}");

void Max(int a)
{
G_i = a;
if (a > 0)
G_str = "переменная положительна";
else if (a < 0)
G_str = "переменная отрицательна";
else
G_str = "переменная равна 0";
Min(a);
}

void Min(int a)
{
G_i *= -1;
}
*/

// Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
/*
int N = 0;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

Console.Write($"Произведение чисел от 1 до {N} = {Factorial(N)}");

int Factorial(int _N)
{
int factorial = 1;
for (int i = 1; i <= _N; i++)
factorial *= i;
return factorial;
}
*/

// Напишите функцию, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
/*
int[] array;

array = CreateArray();
for (int i = 0; i < array.Length; i++)
Console.Write($"{array[i]} ");

int[] CreateArray()
{
int[] _array = new int[8];
for (int i = 0; i < 8; i++)
_array[i] = new Random().Next(0, 2);
return _array;
}
*/

/*
int a = 5;

Console.WriteLine(a);

Multiply(ref a);

Console.WriteLine(a);

void Multiply(ref int _a)
{
_a *= 2;
}
*/

//пример использования foreach
/*
int[] array = new int[20];

foreach (var item in CreateArray(20))
Console.Write($"{item} ");

int[] CreateArray(int _size)
{
int[] _array = new int[_size];
for (int i = 0; i < _size; i++)
_array[i] = new Random().Next(10);
return _array;
}
*/