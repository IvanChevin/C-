// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
int a, b, c, d, userEnter;
Console.Write("Введите пятизначное число: ");
int.TryParse(Console.ReadLine()!, out userEnter);
a = userEnter / 10000;
b = userEnter / 1000 % 10;
c = userEnter / 10 % 10;
d = userEnter % 10;
if (a == d && b == c)
    Console.Write($"да");
else
    Console.Write($"нет");
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
int[] A = new int[3];
int[] B = new int[3];

Console.Write($"Введите координату X1:");
int.TryParse(Console.ReadLine()!, out A[0]);
Console.Write($"Введите координату Y1:");
int.TryParse(Console.ReadLine()!, out A[1]);
Console.Write($"Введите координату Z1:");
int.TryParse(Console.ReadLine()!, out A[2]);
Console.Write($"Введите координату X2:");
int.TryParse(Console.ReadLine()!, out B[0]);
Console.Write($"Введите координату Y2:");
int.TryParse(Console.ReadLine()!, out B[1]);
Console.Write($"Введите координату Z2:");
int.TryParse(Console.ReadLine()!, out B[2]);
double c = Math.Sqrt((A[0] - B[0]) * (A[0] - B[0]) + (A[1] - B[1]) * (A[2] - B[2]) + (A[2] - B[2]) * (A[2] - B[2]));
Console.Write($"расстояние между точками = {c}");
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int N = 0;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

for (int i = 1; i <= N; i++)
    Console.Write($"{i * i * i} ");



