//Задача1.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Input number: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] &&  number[1] == number [3])
    {
        Console.WriteLine($"{number} - Палидром");
    }
    else
    {
        Console.WriteLine($"{number} - Не палидром");
    }
}
else
{
    Console.WriteLine($"Ошибка: {number} - не является птизначным");
}
*/

//Задача2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
int x1 = ReadInt("Enter the cordinate of X the first point: ");
int y1 = ReadInt("Enter the cordinate of Y the first point: ");
int z1 = ReadInt("Enter the cordinate of Z the first point: ");
int x2 = ReadInt("Enter the cordinate of X the second point: ");
int y2 = ReadInt("Enter the cordinate of Y the second point: ");
int z2 = ReadInt("Enter the cordinate of Z the second point: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
*/

//Задача3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
int number = ReadInt("Input number N: ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i}");
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
*/