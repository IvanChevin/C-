// Напишите программу которая на вход принимает число и выдает его квадрат
int a, b;
string userEnter;

Console.Write("Введите число: ");
userEnter = Console.ReadLine()!;

//a = int.Parse(userEnter);
int.TryParse(userEnter, out a);

b = a * a;

Console.Write($"Квадрат введенного числа = {b}\n");// $ - интерполяция

if (b > 100)
{
    Console.WriteLine("Получилось!");
}
else
{
    Console.WriteLine("Не получилось");
}

int i = 0;
while (i < 10) // true false
{
    Console.Write($"{i + 1} ");
    i = i + 1;// i++
}