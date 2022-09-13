// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int columns, double minValue, double maxValue)
{
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i < rows; i++) 
        for(int j =0; j < columns; j++) 
            newArray[i,j] = Math.Round(minValue + new Random().NextDouble() * (maxValue - minValue), 2);
            // не больше 2 знаков после запятой
    
    return newArray;
}

void ShowArray(double[,] array) 
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine(); 
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input max possible value: ");
double max = Convert.ToDouble(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, min, max);
ShowArray(myArray);
*/


// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) 
{
    int[,] newArray = new int[rows, columns]; 

    for(int i = 0; i < rows; i++) 
        for(int j =0; j < columns; j++) 
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
}

void ShowArray(int[,] array) 
{  
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine(); 
    }
}

void CheckNumber(int[,] array, int rowN, int columnN)
{
    if(rowN < array.GetLength(0) && columnN < array.GetLength(1)) 
        Console.Write($"The number with position ({rowN}, {columnN}) is {array[rowN, columnN]}");
    else 
        Console.Write($"The number with position ({rowN}, {columnN}) doesn't exist");
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input row coef: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input column coef: ");
int j = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandom2dArray(m, n, min, max);
ShowArray(myArray);
Console.WriteLine();
CheckNumber(myArray, i, j);
*/

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double[,] CreateRandom2dArray(int rows, int columns, double minValue, double maxValue)
{
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i < rows; i++) 
        for(int j =0; j < columns; j++) 
            newArray[i,j] = Math.Round(minValue + new Random().NextDouble() * (maxValue - minValue), 0);
            
    
    return newArray;
}

void ShowArray(double[,] array) 
{  
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine(); 
    }
}

void AvgInColumns(double[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;
        for(int i = 0; i < array.GetLength(0); i++)
            average += array[i,j] / array.GetLength(1);
       
        Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {average}");
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input max possible value: ");
double max = Convert.ToDouble(Console.ReadLine());


double[,] myArray = CreateRandom2dArray(m, n, min, max);
ShowArray(myArray);
Console.WriteLine();
AvgInColumns(myArray);

