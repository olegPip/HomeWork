
// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.Write("Enter the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rows, columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
      
        Console.WriteLine("");
    }
}
*/

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
string StockIndex2dArray(int[,] array, int row, int column)
{
    return array.GetLength(0) <= row && array.GetLength(1) <= column ? "No this element in this 2d array" : $"Yes this element [{row}, {column}] 2d array stock in and have value - {array[row, column]}";
}
 int[,] array = CreateRandom2dArray();

Console.WriteLine(StockIndex2dArray(array, 5, 5));
*/

// Задача 3.  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*

double[] AverageNumber(int[,] array)
{
    double[] doubleArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int count = 0;
        for (int j = 0; j < array.GetLength(0); j++, count++)
          doubleArray[i] += array[j, i];
        doubleArray[i] /= count;
    }
    return doubleArray;
}

int[,] array = CreateRandom2dArray();

Show2dArray(array);

ShowArray(AverageNumber(array));


void ShowArray(double[] array) 
{
  foreach (var item in array)
    Console.Write(item + " ");
  Console.WriteLine();
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minVal, maxVal + 1);
    return array;
}
*/