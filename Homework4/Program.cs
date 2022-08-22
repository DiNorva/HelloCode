// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int number(string num)
{
    Console.Write($"Весдите число {num}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int A = number("A");
int B = number("B");

int pow = 1;
for (int i = 0; i < B; i++)
{
    pow = pow * A;
}
Console.WriteLine($"{A} ^ {B} = {pow}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
{
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
       advance = numberN - numberN % 10;
       result = result + (numberN - advance);
       numberN = numberN / 10;
    }
   return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



static void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
static void Main (string[] args)
{
    int[] array = new int[0]; 
    while (true)
    {
        Console.WriteLine("Введите значение массива");
        string meaning = Console.ReadLine();
        if(meaning != "end")
        {
            int number = Convert.ToInt32(meaning);
            int[] newArray = array;
            array = new int[array.Length + 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                array[i] = newArray[i];
            }
            array[array.Length - 1] = number;
        }
        else
        {
            break;
        }
    }
    WriteArray(array);
}

