/*
// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
    Console.WriteLine($"max = {n1}");
}
else
{
    Console.WriteLine($"max = {n2}");
}
*/

/*
// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if(n1 > max) max = n1;
if(n2 > max) max = n2;
if(n3 > max) max = n3;

Console.WriteLine($"max = {max}");
*/

/*
// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input a number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if(n1 % 2 == 0)
{
    Console.WriteLine($"{n1} - четное число");
}
else
{
    Console.WriteLine($"{n1} - нечетное число");
}
*/

// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input integer positive number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= number)
{
    if (current % 2 == 0)
    
    Console.Write(current + " ");
    current++;
}