// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int [size]; // выделяем для массива память в числе int[sixe] штук
    
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array) // показываем массив
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int FindEvenNumbers (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {  
        if(array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.Write("Input size of array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible element value: ");
int mint = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible element value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a,mint,max);
ShowArray(myArray);
int countEvenNumbers = FindEvenNumbers(myArray);
Console.Write($"There are {countEvenNumbers} even numbers in array");
*/

// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int [size]; 
    
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

int OddPositionSum (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {  
        if(i % 2 > 0)
            count += array[i];
    }
    return count;
}

Console.Write("Input size of array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible element value: ");
int mint = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible element value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a,mint,max);
ShowArray(myArray);
int countOddPosNumbers = OddPositionSum(myArray);
Console.Write($"There sum of numbers at the odd positions in array is {countOddPosNumbers}");
*/

// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size)
{
    double [] newArray = new double [size]; 
    
    for(int i = 0; i < size; i++)
   {
        Console.Write($"Input {i} real number element of the array: "); 
        newArray[i] = Convert.ToDouble(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(double[] array) 
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

double FindMax(double[] array)
{
    double max = 0;
    for(int i = 0; i < array.Length; i++)
    { 
    if(array[i] > max)
        max = array[i];
    }
    return max;
} 
double FindMin(double[] array)
{
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {  
        if(array[i] < min)
        min = array[i];
    }
    return min;
}



Console.Write("Input size of array: ");
int a = Convert.ToInt32(Console.ReadLine());


double[] myArray = CreateRandomArray(a);
ShowArray(myArray);
double maxNumber = FindMax(myArray);
double minNumber = FindMin(myArray);
Console.WriteLine($"The difference between min and max number in array is {maxNumber - minNumber}");

