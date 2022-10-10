// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

/*
Console.Write("Введите число a = ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0) // || - или && - и
{
Console.Write("Да");
}
else
{
Console.Write("Нет");
}
*/

/*int a;
string userEnter;
Console.Write("Введите число: ");
userEnter = Console.ReadLine()!;
int.TryParse(userEnter, out a);
if (a >= 23)
    if (a % 7 % 23 == 0)
        Console.Write("да");
    else Console.Write("нет");
else Console.Write("нет");
*/

/*
int a;
string userEnter;
Console.Write("Введите число: ");
userEnter = Console.ReadLine();
int.TryParse(userEnter, out a);
if (a % 7 == 0)
    if (a % 23 == 0)
        Console.Write("да");
    else Console.Write("нет");
else Console.Write("нет");
*/



//  Напишите программу, которая будет принимать на вход два числа и выводить,
//  является ли второе число кратным первому. Если второе число не кратно числу первому, 
//  то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

/*
int a, b;
string userEnter;
Console.Write("Введите первое число: ");
userEnter = Console.ReadLine();
int.TryParse(userEnter, out a);
Console.Write("Введите второе число: ");
userEnter = Console.ReadLine();
int.TryParse(userEnter, out b);
if (b % a != 0)
    Console.Write($"не кратно, остаток {b % a}");
else Console.Write("кратно");
*/

/*
// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру
// этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int rand = new Random().Next(10, 100);

Console.WriteLine(rand);

Console.Write($"{rand / 100 * 10 + rand % 10}");
*/

/*
// Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int rand = new Random().Next(10, 100);

Console.WriteLine(rand);

int a = rand / 10;
int b = rand % 10;
Console.Write($"Наибольшая цифра числа = ");
if (a > b)
Console.Write(a);
else
Console.Write(b);
*/

/*
// рандом в диапазоне от 10 до 20. 
for (int i = 0; i < 5; i++)
{
    int a = new Random().Next(10, 20);//левая граница диапазона включается правая не включается!
    Console.Write($"{a} ");
}*/


/*
//Рандомное число int, до 100 через пробел
for (int i = 0; i < 30; i++)
{
    int a = new Random().Next() % 90 + 10;
    Console.Write($"{a} ");
}

//рандомное четное до 20 включительно
for (int i = 0; i < 30; i++)
{
    int a = new Random().Next() % 11 * 2;
    Console.Write($"{a} ");
}
*/


// Максимальное число  в массиве
/*int[] array = { 4, 9, 36 };

int max = Max(array[0], array[1], array[2]);
Console.Write($"Максимальное число = {max}");

int Max(int _a, int _b, int _c)
{
    int max = _a;
    if (_b > max)
        max = _b;
    if (_c > max)
        max = _c;
    return max;
}
*/

// for (int i = 0; i < array2.Length; i++)
//     Console.Write($"{array2[i]} ");

// Sort(array2);
// Console.WriteLine();

// for (int i = 0; i < array2.Length; i++)
//     Console.Write($"{array2[i]} ");


/* //Сортировка пузырьком
void Sort(int[] _array)
{
    for (int j = 0; j < _array.Length - 1; j++)
    {
        for (int i = 0; i < _array.Length - 1; i++)
        {
            if (_array[i] > _array[i + 1])
            {
                int temp = _array[i];
                _array[i] = _array[i + 1];
                _array[i + 1] = temp;
            }
        }
    }
}
*/