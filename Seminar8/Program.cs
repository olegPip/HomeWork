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


//Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.




//Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента. Массив размером 2 x 2 x 2.