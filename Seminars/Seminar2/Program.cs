// Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и выводит цифру максимального числа
/*
int FindBiggestDigit(int number)
{
    int ed = number % 10;
    int dec = number / 10;
    int max;

    if (ed > dec)
        max = ed;
    else
        max = dec;
    
    return max;
}

int randomNumber = new Random().Next(10,100);

int biggestDigit = FindBiggestDigit(randomNumber);
Console.WriteLine($"Biggest Digit of {randomNumber} is {biggestDigit}");
*/

// Задача 2. Напишите программу, которая выводит случайное трехзначное число и удляет вторую цифру этого числа
/*
int Cutnumber(int number)
{
    int ed = number % 10;
    int sot = number / 100;
    return sot * 10 + ed;
}

int randomNumber = new Random().Next(100,1000);

int newNumber = Cutnumber(randomNumber);
Console.WriteLine($"New version of {randomNumber} is {newNumber}");
*/

// Задача 3. Напишите программу, которая на вход будет принимать 2 числа и выводить, явялется ли второе число кратным первому. Если оно не кратно, то программа выводит остаток от деления.
/*
void IsDivisionAble(int num1, int num2)
{
    int reminder = num2 % num1;
    if (reminder == 0)
     Console.WriteLine($"{num2} is divisionable of {num1}");

    else
    Console.WriteLine($"{num2} is divisionable of {num1}. Reninder is {reminder}");
}

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

IsDivisionAble(n1,n2);
*/

// Задача 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
/*
bool IsDivis(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

bool IsDivision = IsDivis(n);
Console.WriteLine(IsDivision);
*/
