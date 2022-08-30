/*

void DO() // функция ничего не принимает и ничего не отдает
{
    
}
void DO2(int number) // функция принимает число и ничего не отдает
{
    
}
int DO3() // функция ничего не принимает и отдает число
{
    return 1;
}

// если есть int или string, то return обязательно
int DO4(int number) // функция принимает число и отдает число
{
    return number; // return - отдает полученный результат
}
string DO5(int number) // функция принимает число и отдает строку
{
    return number.ToString() + " яблок";
}
string str = DO5(5);
Console.WriteLine(str);

*/



/*
void PowDoubleNumber(int number) // функция принимает число и ничего не отдает
{
    number = number * number; // число умножается на само себя
    Console.WriteLine(number); // вывод числа
}
int DoubleNumber(int number) // функция принимает число и отдает тоже число
{
    number = number * 2; // берем число и умножаем его на 2
    return number; // отдаем полученное число
}

int number = 12; // создаем переменную и сохраняем число
PowDoubleNumber(number); // вызываем функцию где передаем число, которое умножается на само себя и выводится
number = DoubleNumber(number); // обращаеся к нашей переменной снова и пересохраняем ее данные через функцию
Console.WriteLine(number); // выводим результат
*/


// Напишите программу, которая выводит массив из N элементов, заполненный нулями и единицами в случайном порядке.
// Сделать красивый вывод
// Сделать все на функциях

// [1,0,1,1,0,1,0,0]


Console.WriteLine("Введите число: ");
int ReadStringConvertInt(string word)
{
    return int.Parse(word); // Convert.ToInt32() - можно заменить, но он дольше работает
}
int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0,2); // (2)
    }
    return result;
}
void GetConsoleArray(int[] array)
{
    Console.WriteLine($"[{String.Join(",", array)}]"); 
}
int number = ReadStringConvertInt(Console.ReadLine());
int[] array = GetBinaryArray(number);
GetConsoleArray(array);





