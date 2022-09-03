// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int FindPowerResult (int numberA, int numberB)
{
    int result = numberA;

for(int power = 1; power < numberB; power++)
    result = numberA * result;

return result;
}

Console.Write("Input integer number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer power B: ");
int B = Convert.ToInt32(Console.ReadLine());

int PowerResult = FindPowerResult(A,B);
Console.WriteLine($"Number {A} to the {B} power is {PowerResult}");
*/

// Задача 2.  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int FindDigitSum (int number)
{
int digitsum = 0;

while (number > 0)
{
    digitsum += number % 10;
    number = number / 10;
}
return digitsum;

}

Console.Write("Input digit number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindDigitSum(a);
Console.WriteLine($"The sum of number {a} digits is {result}");
*/

// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
void ShowArray(int n1,int n2,int n3,int n4,int n5,int n6,int n7,int n8 )
{
    
    int[] array = {n1,n2,n3,n4,n5,n6,n7,n8};

    for(int i = 0; i < 8; i++)
        
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input 1 number for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2 number for array: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 3 number for array: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 4 number for array: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 5 number for array: ");
int e = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 6 number for array: ");
int f = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 7 number for array: ");
int g = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 8 number for array: ");
int h = Convert.ToInt32(Console.ReadLine());


ShowArray(a,b,c,d,e,f,g,h);
*/

