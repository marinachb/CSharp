/*
// Задача 1. Напишите, программу, которая на вход принимает число и выдает его квадрат

int num;

Console.Write("Input a number: ");
num = Convert.ToInt32(Console.ReadLine());

int quad = num * num;

//Console.WriteLine("The square of " + num+ " is " + quad);

Console.WriteLine($"The square of {num} is {quad}");
*/

/*
// Задача 2. Напишите программу, которая на вход принимает два чила и проверяет является ли первое число квадратом второго

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if(n1 == quad2)
{
    Console.WriteLine($"{n1} is quad of {n2}");
}
else
{
    Console.WriteLine($"{n1} is not quad of {n2}");
}
*/

// Задача 3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутка (-N;N)

Console.Write("Input integer positive number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = number * (-1);

while(current <= number)
{
    Console.Write(current + " ");
    current++;
}