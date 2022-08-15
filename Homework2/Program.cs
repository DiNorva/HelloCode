/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

/*

Console.WriteLine ("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int a = Math.Abs(num);
string stringNum = Convert.ToString(a);


if (stringNum.Length < 2)
{
    Console.WriteLine("второй цифры нет");
}
else
{
     Console.WriteLine("вторая цифра этого числа: "+stringNum[1]);
}

*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

/*

Console.WriteLine ("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int a = Math.Abs(num);
string stringNum = Convert.ToString(a);


if (stringNum.Length < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
     Console.WriteLine("третья цифра этого числа: "+stringNum[2]);
}

*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/


/*
class program
{
    static void Main(string[] args)
    {
        string[] WeekDays = ("Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье");
        Console.WriteLine("Введите день недели");
        for(int i = 0; i < WeekDays.Length; i++)
        {
            Console.Write(i+1 + " - " + WeekDays[i] + ", ");
        }
        Console.WriteLine(" ");
        int dayweek = Convert.ToInt32(Console.ReadLine());

        if (dayweek == 6 || dayweek == 7)
        {
            Console.WriteLine("да, " + dayweek + " - выходной день.");
        }
        else
        {
            Console.WriteLine("нет, " + dayweek + " - будний день.");
        }
    }
}
*/


class program
{
    static void Main(string[] args)
    { 
        Dictionary <int, string> eve = new Dictionary <int, string>()
        {
        {1,"Понедельник, рабочий день"},
        {2,"Вторник, рабочий день"},
        {3,"Среда, рабочий день"},
        {4,"Четверг, рабочий день"},
        {5,"Пятница, рабочий день"},
        {1,"Суббота, выходной день"},
        {1,"Воскресенье, выходной день"},
        };
        int index = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(eve[index]);
    }
}
