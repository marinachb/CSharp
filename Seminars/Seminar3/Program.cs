// Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FindQuart(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4; 

    return 0;

}

Console.Write("Input first number: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
double yA = Convert.ToInt32(Console.ReadLine());

int quartNum = FindQuart(xA, yA);

if(quartNum == 0)
    Console.WriteLine("Point is on the axes");
else
Console.WriteLine($"Point is located on {quartNum} quart");
*/

// Задача 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void PointsRange (int quart)
{
if (quart == 1)
Console.WriteLine("Points range is (x>0, y>0) ");
if (quart == 2)
Console.WriteLine("Points range is (x<0, y>0) ");
if (quart == 3)
Console.WriteLine("Points range is (x<0, y<0) ");
if (quart == 4)
Console.WriteLine("Points range is (x>0, y<0) ");
}

Console.Write("Input quart number: ");
int number = Convert.ToInt32(Console.ReadLine());
PointsRange(number);
*/

// Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double FindLenght (double x1, double y1, double x2, double y2)
{

return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
}

Console.Write("Input x1: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double yb = Convert.ToDouble(Console.ReadLine());

double coordinates = FindLenght(xa, xb, ya, yb);
Console.WriteLine($"Length is {coordinates}");
*/

//Задача 4. Напишите программу, которая принимает на вход число (N) и выдаёт на консоль квадраты чисел от 1 до N.
/*
void FindSq (int number)
{
    int current = 1;

    while(current <= number)
    {
        int square = current * current;
        Console.Write(square + " ");
        current++;
    }
    
}

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

FindSq(a);
*/