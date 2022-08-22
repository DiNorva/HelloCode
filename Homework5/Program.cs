// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = new int[10];
int countEven = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write(array[i] + ",");
}
Console.WriteLine();

for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0) 
    countEven = countEven + 1;
}
Console.Write("Четные числа из массива: " + countEven);
Console.WriteLine();



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[30];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + ",");
}
for (int j = 0; j < array.Length; j++)
{
    if (j % 2 == 1) 
    count = count + array[j];
}
Console.WriteLine();
Console.Write("Сумма чисел стоящих на нечетной позиции в массиве равна:  ");
Console.Write(count);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


class Program
{
    static int MaxNumberArray(int[] array)
    {
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
    static int MinNumberArray(int[] array)
    {
        int min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }
    static void Main(string[] args)
    {
        int[] array = {45,10,4,5,6,721,67,10,16,2345};
        int max = MaxNumberArray(array);
        int min = MinNumberArray(array);
        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine(max - min);
    }
}

