// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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


int[,] SortedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
    return array;
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
int[,] newArray = SortedArray(myArray);
Console.WriteLine();
ShowArray(newArray);
*/

// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int SumRowElements(int[,] array, int i)
{
  int sumRow = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRow += array[i,j];
  }
  return sumRow;
}

void SmallestSum (int[,] array)
{
    int minSumRow = 0;
    int sumRow = SumRowElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumRow = SumRowElements(array, i);
        if (sumRow > tempSumRow)
        {
            sumRow = tempSumRow;
            minSumRow = i;
        }
    }
    Console.WriteLine($"{minSumRow+1} - row with the smallest elements sum");
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
int sum = SumRowElements(myArray, 0);
SmallestSum(myArray);
*/

// Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] ArrayProduct (int[,] firstMartrix, int[,] secondMartrix)
{
  int[,] resultMatrix = new int[firstMartrix.GetLength(0), secondMartrix.GetLength(1)];
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      
      resultMatrix[i,j] = sum;
    }
  
  return resultMatrix;
}

Console.Write("Input number of rows for the first matrix: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns for the first matrix and rows for the second matrix: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns for the second matrix: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
ShowArray(myArray);
Console.WriteLine();
int[,] my2Array = CreateRandom2dArray(n, b, min, max);
ShowArray(my2Array);
Console.WriteLine();
int[,] newArray = ArrayProduct(myArray, my2Array);
ShowArray(newArray);
*/
//