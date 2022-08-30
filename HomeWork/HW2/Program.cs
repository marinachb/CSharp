// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Cutnumbers(int number)
{
    int dec = number % 100 / 10;
    return dec;
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int newNumber = Cutnumbers(n);
Console.WriteLine($"New version of {n} is {newNumber}");
*/

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void Shownumber(string number)
{
    int lenght = number.Length;
    
    if (lenght > 2)

    Console.WriteLine($"The third digit of {number} is {number[2]}");

    else
        Console.WriteLine($"{number} does not have the third digit");
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
string nText = Convert.ToString(n);

Shownumber(nText);
*/

// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void IsWeekend(int daynumber)
{
    
    if (daynumber == 6 || daynumber == 7)
    Console.WriteLine($"{daynumber} is a weekend");

    else if (daynumber < 1 || daynumber > 7)
    Console.WriteLine($"{daynumber} is not a day of the week number");

    else
    Console.WriteLine($"{daynumber} is not a weekend");
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

IsWeekend(n);
*/