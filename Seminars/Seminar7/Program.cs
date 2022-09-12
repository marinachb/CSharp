// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // задаем массив
{
    int[,] newArray = new int[rows, columns]; // выделяем память

    for(int i = 0; i < rows; i++) // внешний цико
        for(int j =0; j < columns; j++) // вложенный массив для столбцов
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
}

void ShowArray(int[,] array) // показываем массив
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine(); // переход на новую строчку
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
ShowArray(myArray);
*/


// Задача 2. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int[,] Create2dArray(int rows, int columns) 
{
    int[,] newArray = new int[rows, columns]; 

    for(int i = 0; i < rows; i++) 
        for(int j =0; j < columns; j++) 
            newArray[i,j] = i + j;
    
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

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(m, n);
ShowArray(myArray);
*/

// Задача 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] Create2dArray(int rows, int columns) 
{
    int[,] newArray = new int[rows, columns]; 

    for(int i = 0; i < rows; i++) 
        for(int j =0; j < columns; j++) 
            newArray[i,j] = i + j;
    
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

int[,] ChangeElements(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i+=2)
        for(int j = 0; j < array.GetLength(1); j+=2)
            array[i,j] = array[i,j] *  array[i,j]; 
    
    return array;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(m, n);
ShowArray(myArray);
Console.WriteLine();
int[,] newArray = ChangeElements(myArray);
ShowArray(newArray);
*/


// Задача 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] Create2dArray(int rows, int columns) 
{
    int[,] newArray = new int[rows, columns]; 

    for(int i = 0; i < rows; i++) 
        for(int j =0; j < columns; j++) 
            newArray[i,j] = i + j;
    
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

int FindSum(int[,] array)
{
    int sum = 0;
    for(int i = 0 ; i < array.GetLength(0); i++)
        sum += array[i,i];
    
    return sum;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(m, n);
ShowArray(myArray);
Console.WriteLine();
int diagonalSum = FindSum(myArray);
Console.Write($"The sum of elements on array diagonal is {diagonalSum}");
//
//