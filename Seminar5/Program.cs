//Задача.1 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int  size = ReadInt("Введите размерность массива: ");
int[] numbers = new int[size];

FillArrayRandomNumber(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        result++;
    }
}


void FillArrayRandomNumber(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 999);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
*/

//Задача.2 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int size = ReadInt("Введите размерность массива: ");
int min = ReadInt("Введите минимальное число массива: ");
int max = ReadInt("Введите максимальное число массива: ");
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if(i % 2 != 0)
        result +=numbers[i];
}

Console.WriteLine($"Сумма элементов нечетных позицый = {result}");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
*/

//Задача.3 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
/*

int size = ReadInt("Введите размерность массива: ");
int min = ReadInt("Введите минимальное значение массива: ");
int max = ReadInt("Введите максимальное значение массива: ");
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int maxFillArray = numbers[0];
int minFillArray = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > maxFillArray)
    
        maxFillArray = numbers[i];
    
    if(numbers[i] < minFillArray)
        minFillArray = numbers[i];
}

Console.WriteLine($"Разница между максимальным и минимальным числом = {maxFillArray - minFillArray}");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();     
}    
 int ReadInt(string msg)
 {
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
 }
*/

