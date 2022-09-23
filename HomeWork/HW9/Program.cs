// Задача 1. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int FindSum(int m, int n)
{
	int begin = m;
	int finish = n;
	if(m > n)
	{
		begin = n;
		finish = m;
	}
	return (finish + begin)*(finish - begin + 1)/2;
}
		
Console.WriteLine(FindSum(1, 15));
*/

// Задача 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;

    else if (n == 0 && m > 0)
        return Akkerman(m - 1, 1);

    else
        return Akkerman(m - 1, Akkerman(m, n - 1));

}

Console.Write(Akkerman(3, 2));
*/