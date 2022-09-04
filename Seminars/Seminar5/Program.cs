// Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
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

void FindMinMaxSum(int[]array)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for(int i =0; i < array.Length; i++)
    {
        if(array[i] > 0)
            sumPositive += array[i];

        else 
            sumNegative += array[i];
    }

    Console.WriteLine($"sum of negative elements is {sumNegative}");
    Console.WriteLine($"sum of positive elements is {sumPositive}");
}


Console.Write("Input size of array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible element value: ");
int mint = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible element value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a,mint,max);
ShowArray(myArray);
FindMinMaxSum(myArray);
*/

// Задача 2.Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
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

int[] verseArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = array[i] * (-1);
   
    return array;
}

Console.Write("Input size of array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible element value: ");
int mint = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible element value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a,mint,max);
ShowArray(myArray);
ShowArray(verseArray(myArray));
*/

// Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] CreateRandomArray(int size)
{
    int [] newArray = new int [size]; // выделяем для массива память в числе int[sixe] штук
    
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i} element of the array: "); // Задаем массив вручную
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(int[] array) // показываем массив
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

bool FindNumber (int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)

        if(array[i] == number) return true; // return if..

    return false; // если дошли до конца и элемента нет, возвращаем false
}

Console.Write("Input size of array: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input searching integer number: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a);
ShowArray(myArray);
bool check = FindNumber(myArray, N);
if(check == true) Console.WriteLine ($"Number {N} exists in the array");
else Console.WriteLine ($"Number {N} does not exist in the array");
*/

// Задача 4. Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
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

int Numbers (int[] array, int segmentMin, int segmentMax)
{
    int countNumbers = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= segmentMin && array[i] <= segmentMax)
        countNumbers++;
    }
    return countNumbers;
}


Console.Write("Input size of array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible element value: ");
int mint = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible element value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible element value for the segment: ");
int minseg = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible element value for the segment: ");
int maxseg = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a,mint,max);
ShowArray(myArray);
int segmentNumbers = Numbers(myArray, minseg, maxseg);
Console.WriteLine($"There is {segmentNumbers} numbers from {minseg} to {maxseg}");
*/


// Задача 5. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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

int[] FindProduct(int[] array)
{
    int[] newArray = new int [array.Length / 2]; // создаем место под новый массив, который в 2 раза меньше предыдущего
    for(int i = 0; i < array.Length / 2; i++ )
    {  
        newArray[i] = array[i] * array[array.Length - (i+1)];
    }
    return newArray;
}

Console.Write("Input size of array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible element value: ");
int mint = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible element value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible element value for the segment: ");

int[] myArray = CreateRandomArray(a,mint,max);
ShowArray(myArray);
int[] productsArray = FindProduct(myArray);
ShowArray(FindProduct(myArray));