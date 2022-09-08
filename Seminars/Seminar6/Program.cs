// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
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

int[] ReverseArray (int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)    //for(int i = 0, j = array.Length - 1; i < j; i++, j--)  
    {
        int temp = array [i];   
        array[i] = array [array.Length - 1 - i]; //array[i] = array[j] 
        array [array.Length - 1 - i] = array[i]; //array[j] = temp
    }

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
ShowArray(ReverseArray(myArray));
*/

// Задача 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

// a < b + c
/*
bool CheckTriangle (int n1, int n2, int n3)
{

if (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2) return true;

else return false;

}

Console.Write("Input 1 length: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2 length: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 3 length: ");
int c = Convert.ToInt32(Console.ReadLine());

bool result = CheckTriangle(a, b, c);
if (result == true) Console.WriteLine($"A triangle with sides {a}, {b} and {c} exists");
else Console.WriteLine($"A triangle with sides {a}, {b} and {c} doesn't exist");
*/

// Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
int[] Fibonacci (int l, int n1, int n2)
{
    int[] array = new int[l];
    array[0] = n1;
    array[1] = n2;
    for(int i = 2; i < l; i++)
        array[i] = array[i-1] + array[i-2];
    return array;
}

void ShowArray(int[] array) 
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input the length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = Fibonacci(length, a, b);
ShowArray(myArray);
*/

// Задача 4. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
string DecimalToBinary (int N)
{
    string result = string.Empty;
    while (N > 0)
    {
        result = N % 2 + result;
        N /= 2;
    }
    return result;
}

Console.Write("Input decimal number: ");
int dec = Convert.ToInt32(Console.ReadLine());
string binary = DecimalToBinary(dec);
Console.WriteLine($"The binary form of {dec} is {binary}");
*/
//