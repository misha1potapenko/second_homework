// Задача 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите чило от 1 до 7 : ");
string weekNumber = Console.ReadLine()!;
Console.WriteLine(weekNumber);
string dayWeek (string day)
{
    if (day == "1")
    {
        Console.WriteLine("Понедельник");
        return day;
    }
    if (day == "2")
    {
        Console.WriteLine("Вторник");
        return day;
    }
    if (day == "3")
    {
        Console.WriteLine("Среда");
        return day;
    }
    if (day == "4")
    {
        Console.WriteLine("Четверг");
        return day;
    }
    if (day == "5")
    {
        Console.WriteLine("Пятница");
        return day;
    }
    if (day == "6")
    {
        Console.WriteLine("Суббота - выходной");
        return day;
    }
        if (day == "7")
    {
        Console.WriteLine("Воскресенье - выходной");
        return day;
    }
    else
    {
        Console.WriteLine("Вы ввели недопустимое число, введите от 1 до 7");
        return day;
    }
}
dayWeek(weekNumber);