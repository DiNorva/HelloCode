/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
int a = -9;
int b = -3;

int max = a;
int min = a;

if(b > a)
{
    max = b;
    min = a;
}
else
{
    max = a;
    min = b;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
int a = 22;
int b = 3;
int c = 9;
int max = a;

if(b > a)
{
    max = b;
}
if(c > max)
{
    max = c;
}
Console.WriteLine(max);
*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

/*
int a = 7;
if(a % 2 == 0)
{
    Console.WriteLine("число a - четное");
}
else
{
    Console.WriteLine("число a - нечетное");
}
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int N = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i <= 10; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
