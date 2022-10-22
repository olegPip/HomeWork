//Задача1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int numberA = ReadInt("Input number: ");
int numberB = ReadInt("Input degree: ");
ToDegree(numberA, numberB);

void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"The number {a} to the power of {b} = {result}");  
}

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
*/

//Задача2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int number = ReadInt("Input number: ");

int len = NumberLen(number);
SumNumbers(number, len);

int NumberLen(int a)
{
    int index = 0;
    while(a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i<= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Sum of digit {sum}");
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
*/

//Задача 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*
int lenArray = ReadInt("Enter the length of the array: ");

int[] randomArray = new int [lenArray];
for (int i =0; i < lenArray; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
*/