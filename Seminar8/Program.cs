//Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
void SortToLower2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp;
        for (int j = 0; j < array.GetLength(1) -1; j++)
            for (int x = 0; x < array.GetLength(1) - j -1; x++)
                if (array[i, x + 1] > array[i, x])
                {
                    temp = array[i, x + 1];
                    array[i, x + 1] = array[i, x];
                    array[i, x]  = temp;
                }
    }
}

int[,] CreateRandom2dArray(int rows, int columns, int minVal, int maxVal)
{
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = new Random().Next(minVal, maxVal + 1);
  return array;
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

int[,] myArray = CreateRandom2dArray(5,4,1,8);

Show2dArray(myArray);
SortToLower2dArray(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/
//Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minVal, int maxVal)
{
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = new Random().Next(minVal, maxVal + 1);
  return array;
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

void MaxSumRow2dArray(int[,] array)
{
  if (array.GetLength(0) != array.GetLength(1))
  {
    int[] sumRowArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
      int num = 0;
      for (int j = 0; j < array.GetLength(1); j++)
        num += array[i, j];
      sumRowArray[i] = num;
    }
    int sumMinRow = sumRowArray[0];
    int indexSumMinRow = 0;

    for (int i = 1; i < sumRowArray.Length; i++)
      if (sumMinRow > sumRowArray[i])
      {
        sumMinRow = sumRowArray[i];
        indexSumMinRow = i;
      }
    Console.WriteLine($"The row with the smallest sum of elements - {indexSumMinRow + 1} line amount - {sumMinRow}");
  }
  else
    Console.WriteLine("Square array");
}

int[,] myArray = CreateRandom2dArray(5, 6, 1, 5);
Show2dArray(myArray);
Console.WriteLine();
MaxSumRow2dArray(myArray);
*/


//Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*

int[,] CreateRandom2dArray(int rows, int columns, int minVal, int maxVal)
{
  int[,] array = new int[rows, columns];
  for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
      array[i, j] = new Random().Next(minVal, maxVal + 1);
  return array;
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

int[,] MatrixMultiply(int[,] oneMatrix, int[,] twoMatrix)
{
  int matrix1Rows = oneMatrix.GetLength(0);
  int matrix1Cols = oneMatrix.GetLength(1);
  int matrix2Rows = twoMatrix.GetLength(0);
  int matrix2Cols = twoMatrix.GetLength(1);
  int[,] product = new int[matrix1Rows, matrix2Cols];
  if (oneMatrix.GetLength(1) == twoMatrix.GetLength(0))
    for (int matrix1_row = 0; matrix1_row < matrix1Rows; matrix1_row++)
      for (int matrix2_col = 0; matrix2_col < matrix2Cols; matrix2_col++)
        for (int matrix1_col = 0; matrix1_col < matrix1Cols; matrix1_col++)
          product[matrix1_row, matrix2_col] +=
            oneMatrix[matrix1_row, matrix1_col] *
            twoMatrix[matrix1_col, matrix2_col];
  return product;
}

int[,] arrayOne = CreateRandom2dArray(2, 2, 1, 5);
Show2dArray(arrayOne);
Console.WriteLine();
int[,] arrayTwo = CreateRandom2dArray(2, 2, 1, 5);
Show2dArray(arrayTwo);
Console.WriteLine();
int[,] matrixMult = MatrixMultiply(arrayOne, arrayTwo);
Show2dArray(matrixMult);
*/
//Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента. Массив размером 2 x 2 x 2.