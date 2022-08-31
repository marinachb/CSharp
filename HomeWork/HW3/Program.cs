// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palindrome (string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    Console.WriteLine($"{number} is a palindronme");

    else
    Console.WriteLine($"{number} is not a palindronme");
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
string nText = Convert.ToString(n);

Palindrome(nText);
*/

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindLenght (double x1, double y1, double x2, double y2, double z1, double z2)
{

return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
}

Console.Write("Input x1: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double zb = Convert.ToDouble(Console.ReadLine());



double coordinates = FindLenght(xa, ya, xb, yb, za, zb);
Console.WriteLine($"Length is {coordinates}");
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void FindCube (int number)
{
    int current = 1;

    while(current <= number)
    {
        int cube = current * current * current;
        Console.Write(cube + " ");
        current++;
    }
    
}

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

FindCube(a);
*/