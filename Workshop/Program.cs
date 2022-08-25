// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2] -> 0

// [10, 11, 12, 13, 14] -> 5


/*
int[] array = new int[123];
int count=0;

for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
        Console.Write(array[i] + " ");
    }
Console.WriteLine();

for (int j = 0; j < array.Length; j++)
    {
       if(array[j] >= 10 & array[j] <= 99) 
       count++;
    }
Console.WriteLine();
Console.Write("Массив содержит следующее количество элементов из отрезка [10,99] - ");
Console.Write(count);

*/


// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21

int N = 10;
int[] array = new int[N];

for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
        Console.Write(array[i] + ",");
    }
Console.WriteLine();

int j = array.Length - 1;
for (int i = 0; i < (array.Length + 1) % 2; i++)
    {
        Console.Write(array[i] * array[j] + ",");
        j++;
}
