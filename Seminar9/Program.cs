//Задача. Задайте значение N. Напишите пррогрвмму, которая выведет все натуральные числа от 1 до N.
/*
void ShowNumber(int n)
{
    if(n > 1) ShowNumber(n - 1);
    Console.Write(n + " ");
}

ShowNumber(5);
*/
//Задача. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumOfDigit(int n)
{
    if(n != 0)  return SumOfDigit(n / 10) + n % 10;
    else return 0;
}

Console.WriteLine(SumOfDigit(1234));
*/
// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N.
/*
void ShowNumber (int m, int n)
{
    if(n == m)
    {
        Console.Write(n +" ");
    }
    if(n < m)
    {
        ShowNumber (m - 1, n);
        Console.Write(m + " ");
    }
    if(n > m)
    {
        ShowNumber (m, n - 1);
        Console.Write(n + " ");
    }
}

ShowNumber(1,5);
*/
// Напишите программу, которая на вход принимает два числа A и B,  и возводит число А в целую степень B.
/*
double ShowNumber (double a, double b)
{
    if(b < 0)
    {
        return 1/a * ShowNumber(a, b +1);
    }
    if(b > 0)
    {
        return a * ShowNumber(a, b -1);
    }
    return 1;
}
Console.Write(ShowNumber(2,-3));
*/
