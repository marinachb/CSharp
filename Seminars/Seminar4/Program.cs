// Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int FindSum (int number)
{
    int sum = 0;

    for(int current = 1; current <= number; current++)
        sum += current;

    return sum;
}
Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindSum(a);
Console.WriteLine($"The sum of numbers from 1 to {a} is {result}");
*/


// Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int DigitAmount (string number)
{
int digit = 0;

for(int i = 0; i <= number.Length - 1; i++)
    digit ++;
return digit;

}

Console.Write("Input digit number: ");
string a = Convert.ToString(Console.ReadLine());
int result = DigitAmount(a);
Console.WriteLine($"The number {a} has {result} digits");
*/


// Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N
/*
int FindProduct (int number)
{
    int product = 1;

    for(int current = 1; current <= number; current++)
        product = product * current;

    return product;
}
Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindProduct(a);
Console.WriteLine($"The product of numbers from 1 to {a} is {result}");
*/

// Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int [size]; // выделяем для массива память в числе int[sixe] штук
    
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input size of array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible element value: ");
int mint = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible element value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a,mint,max);
ShowArray(myArray);