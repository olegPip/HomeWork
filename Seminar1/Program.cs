//Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


/*
Console.WriteLine("Enter the first number: ");
int num_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
{
    Console.WriteLine($"First number {num_A}  More than the second  {num_B}");
}
else
{
Console.WriteLine($"Second number  {num_B}  More then the first {num_A}");
}
*/


// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Enter three numbers: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (num_2 > max)
{
    max = num_2;
}

if (num_3 > max)
{
max = num_3;
}

    Console.WriteLine($"The largest of the entered numbers: {max}");
*/


// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*

Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"Number {num} is: odd");
}
else
{
    Console.WriteLine($"Number {num} is: even");
}

*/
// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*

int i = 1;
bool not = true;

Console.WriteLine("Enter a number:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Even numbers from 1 to " + num);

while (i <= num)
{
    if (i % 2 != 1)
{
    Console.Write(i + ", ");
    not = false;
}
    i++;
}

    if (not)
{
    Console.WriteLine("No even numbers!");
}   

*/