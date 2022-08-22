
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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