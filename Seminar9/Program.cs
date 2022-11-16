//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void NaturalToLow(int n)
{
    if (n < 1) return;
    Console.Write(n + " ");
    NaturalToLow(n - 1);
}

NaturalToLow(5);
*/

//Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumValueMFromN (int n, int m)
{
    if (n < m) return n += SumValueMFromN (n + 1, m);
    if (n > m) return n += SumValueMFromN (n - 1, m);
    else return n;
}

Console.WriteLine(SumValueMFromN(1, 5));
*/

//Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

 
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);
*/