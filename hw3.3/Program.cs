// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int a, b, c, d, userEnter;
int.TryParse(Console.ReadLine()!, out userEnter);
a = userEnter / 10000;
b = userEnter / 1000 % 10;
c = userEnter / 10 % 10;
d = userEnter % 10;
if (a == d && b == c)
    Console.Write($"да");
else
    Console.Write($"нет");