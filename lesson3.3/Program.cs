// Первая группа методов — не принимает никаких аргументов 
// и ничего не возвращают
/*
void Metod1()
{
    Console.WriteLine("Автор …");
}
*/
// Вторая группа методов — принимает какие-то аргументы, 
// но ничего не возвращают.
/*void Metod2(string msg) — //где void ключевое слово, 
//дальше идентификатор, в скобках указаны какие-то аргументы.
{
Console.WriteLine(msg); //— оператор, в скобках указан
//принятый аргумент.
}*/

// ctrl+c - если зацикливается программа

// Третья группа методов — может что-то возвращать,
// но не принимает никаких аргументов. Например,
// может служить для генерации случайных данных
/*
int Metod3() //- не принимает никакие аргументы
{
    return DataTime.Now.Year; //- обязательное использование 
                              //оператора return,
}
int year = Metod3(); - //вызываем метод, в левой части 
//используем идентификатор переменной (year) и через 
//оператор присваивания (=) кладём нужное значение
Console.WriteLine(year);
*/

// Четвёртая группа методов — что-то принимает (аргументы, 
// данные). И что-то возвращает для дальнейшей работы.
/*
string Metod4(int count, string text)
{
int i = 0;
string result = String.Empty;
while (i<count)
{
result = result + text;
i++;
}
return result;
}
string res = Metod4(10, “asdf”);
Console.WriteLine(res);
*/

//string result = String.Empty;- пустая строка

//Cинтаксис цикла for:
//for (int i = 0; i<count; i++) - вначале ключевое слово, 
//затем инициализация счётчика, после проверка условия 
//и инкремент (увеличение счётчика).
/*
string Metod4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, “asdf”);
Console.WriteLine(res);
*/

//Таблица умножения
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";


string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

// string newText = Replase(text, ' ', '|');
// newText = Replase(newText, 'к', 'К');
// newText = Replase(newText, 'С', 'с');

string newText = Replase(Replase(Replase(text, 'С', 'с'), 'к', 'К'), ' ', '|');

Console.WriteLine(newText);
*/

//Упорядочевание массива по возростанию
/*
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }

        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PtintArray(arr);
selectionSort(arr);
PtintArray(arr);
*/

//Упорядочевание массива по убыванию

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            }

        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PtintArray(arr);
selectionSort(arr);
PtintArray(arr);
