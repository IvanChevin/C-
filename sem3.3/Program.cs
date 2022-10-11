//"editor.acceptSuggestionOnCommitCharacter": false, - чтобы не дописовало по подсказке после пробела

/*
int x = 0, y = 0;
Console.Write($"Введите координату X:");
int.TryParse(Console.ReadLine()!, out x);
Console.Write($"Введите координату Y:");
int.TryParse(Console.ReadLine()!, out y);
*/

// if (x > 0 && y > 0)
//     Console.Write($"Плоскость 1");
// else if (x < 0 && y > 0)
//     Console.Write($"Плоскость 2");
// else if (x < 0 && y < 0)
//     Console.Write($"Плоскость 3");
// else if (x > 0 && y < 0)
//     Console.Write($"Плоскость 4");
// else if (x == 0 && y == 0)
//     console.write($"точка лежит в начале координат");
// else if (x == 0)
//     console.write($"точка лежит на оси y");
// else if (y == 0)
//     console.write($"точка лежит на оси x");
/*
{
    if (y > 0)
        Console.Write($"Плоскость 1");
    else if (y < 0)
        Console.Write($"Плоскость 4");
}
else
{
    if (y > 0)
        Console.Write($"Плоскость 2");
    else if (y < 0)
        Console.Write($"Плоскость 3");
}
else if (x == 0 && y == 0)
    console.write($"точка лежит в начале координат");
else if (x == 0)
    console.write($"точка лежит на оси y");
else if (y == 0)
    console.write($"точка лежит на оси x");
*/

// Цикл for
/*
for (int i = 0; i < 10; i++)
{
    console.write($"{i} ");
}
*/

// Расстояние между 2 точками

/*
int[] A = new int[2];
int[] B = new int[2];

Console.Write($"Введите координату X:");
int.TryParse(Console.ReadLine()!, out A[0]);
Console.Write($"Введите координату Y:");
int.TryParse(Console.ReadLine()!, out A[1]);
Console.Write($"Введите координату X:");
int.TryParse(Console.ReadLine()!, out B[0]);
Console.Write($"Введите координату Y:");
int.TryParse(Console.ReadLine()!, out B[1]);
double c = Math.Sqrt((A[0] - B[0]) * (A[0] - B[0]) + (A[1] - B[1]) * (A[1] - B[1]));
c = Math.Round(c, 2); // ограничить до 2х знаков после запятой
Console.Write($"расстояние между точками = {c}");
*/

// bool user = nt.TryParse(Console.ReadLine()!, out x); - проверка правильности ввода

/*
Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

/*
int a = 0;
Console.Write($"Введите координатную четверть: ");
int.TryParse(Console.ReadLine()!, out a);

switch (a)
{
case 1:
Console.Write($"X > 0 Y > 0");
break;
case 2:
Console.Write($"X < 0 Y > 0");
break;
case 3:
Console.Write($"X < 0 Y < 0");
break;
case 4:
Console.Write($"X > 0 Y < 0");
break;
default:
Console.Write($"Неверный ввод!");
break;
}
*/

/*
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

/*
int a = 0;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

for (int i = 0; i <= a; i++)
Console.Write($"{i * i} ");
*/