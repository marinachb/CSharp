// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

int[,] ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= array.GetLength(0) || row2 >= array.GetLength(0))
        return array;
    else
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1,j];
            array[row1, j] = array[row2,j];
            array[row2,j] = temp;
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
myArray = ChangeRows(myArray, 0, m-1);
Console.WriteLine();
ShowArray(myArray);
*/

// Задача 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

int[,] ChangeRowsColumns(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1)) // проверяемость равенства числа строк и столбцов
    {
        for(int i = 0; i < array.GetLength(0)-1; i++)
            for(int j = i + 1; j < array.GetLength(1); j++) // смотрим со сдвигом вправо по диагонали
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
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
int[,] newArray = ChangeRowsColumns(myArray);
Console.WriteLine();
ShowArray(newArray);
*/


// Задача 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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

int[,] DeleteRowsColumns(int[,] array)
{
    int min = array[0,0],
        t1 = 0, // i
        t2 = 0; // j
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < min)
            {
                min = array[i,j];
                t1 = i;
                t2 = j;

            }
        }
    for(int i = 0; i < array.GetLength(0); i++) 
        array[i, t2]= 0;
    for(int j = 0; j < array.GetLength(1); j++)
        array[t1, j]= 0;

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
int[,] newArray = DeleteRowsColumns(myArray);
Console.WriteLine();
ShowArray(newArray);