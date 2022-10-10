// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a, b, max;
string userEnter;
Console.Write("Введите первое число: ");
userEnter = Console.ReadLine();
int.TryParse(userEnter, out a);
Console.Write("Введите второе число: ");
userEnter = Console.ReadLine();
int.TryParse(userEnter, out b);
if (a > b)
{
    max = a;
    Console.WriteLine($"Число {a} больше {b}, max = {max}");
}
else
{
    max = b;
    Console.WriteLine($"Число {b} больше {a}, max = {max}");
}