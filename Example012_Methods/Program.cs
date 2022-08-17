// // Вид 1 ничего не принимает, ничего не возвращает
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// // Method1();









// // Вид2 Что-то принимает, ничего не возвращает
// /*void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст",count: 4);
// Method21(count: 4, msg: "новый текст");
// */


// // Вид3 Что-то возвращают, но ничего не принимают
 
// /*
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);
// */






// // Вид4 Что-то принимают, что-то возвращают
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);




/*
string Method4(int count, string text)
{
    
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
//Console.WriteLine(res);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

/*

// ===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы “к” заменить большими “К”, 
// а большие “С” заменить маленькими “с”.
// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty" 
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
*/

// Функции в программировании
// 1. Найти позицию минимального элемента
// в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции 
// 3. Повторять пока есть не отсортированные элементы
 
/*
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
*/


// ** Семинар **
// Встроенные функции и как с ними работать!

/*
class Program
{
    static void ReadNumber(int number)
    {
        Console.WriteLine(number * number);
    }
    public static void Main(string[] args)
    {
        ReadNumber(Convert.ToInt32(Console.ReadLine()));
        
        Console.ReadLine();
    }
}
*/

/*
class Program
{
    static void ReadNumber(int number)
    {
        Console.WriteLine(number * number);
    }
    static string WriteNumber(int number)
    {
        return number % 2 == 0 ? "Кратное" : "Не кратное";
    }
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        ReadNumber(number);
        Console.WriteLine(WriteNumber(number));
        
        Console.ReadLine();
    }
}
*/

/*
class Program
{
    static int PowTwoNumber(int number)
    {
        return number * number;
    }
    static string MultipleTwoNumber(int number)
    {
        return number % 2 == 0 ? "Кратное" : "Не кратное";
    }

static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(PowTwoNumber(number));
        Console.WriteLine(MultipleTwoNumber(PowTwoNumber(number)));
        
        Console.ReadLine();
    }
}
*/
class Program
{
    static int[] Shuffle(int[] array) // заполнение массива случайными числами
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int j = new Random().Next(0, i + 1);
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
        return array;
    }
    static int[] CreaterArray(int number)
    {
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }
    static void WriteArray(int[] array)
    {
        Console.WriteLine("Вывод массива");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
    static void Main(string[] args)
    {
        // int number = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine(PowTwoNumber(number));
        // Console.WriteLine(MultipleTwoNumber(PowTwoNumber(number)));
        int[] array = CreaterArray(30);
        WriteArray(array);
        array = Shuffle(array);
        WriteArray(array);

        Console.ReadLine();
    }
}