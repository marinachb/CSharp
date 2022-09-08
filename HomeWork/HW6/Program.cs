// Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] CreateRandomArray(int size)
{
    int [] newArray = new int [size]; 
    
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i} element of the array: "); 
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(int[] array) 
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int CountPosNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] > 0) count++;

    return count;
}

Console.Write("Input total amount of numbers: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(length);
ShowArray(myArray);
int amount = CountPosNumbers(myArray);
Console.WriteLine($"There are {amount} positive numbers in the written array");
*/


// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] FindCrossPoint (double b01, double k01, double b02, double k02)
{
    double[] array = new double[2];
    array[0] = (b02 - b01) / (k01 - k02);
    array[1] = k01 * array[0] + b01;
    return array;
}

void ShowArray(double[] array) 
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "; ");
    
    Console.WriteLine();
}

Console.Write("Input value for b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input value for k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input value for b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input value for k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] crossPoint = FindCrossPoint(b1, k1, b2, k2);
ShowArray(crossPoint);