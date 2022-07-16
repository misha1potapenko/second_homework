// Задача 13: Напишите программу,
//  которая выводит третью цифру заданного 
//  числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите  чило: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(threeDigitNumber);

int ForArray(int number)
{
    
    if (number > 99 && number < 1000)
    {
        int number3 = number  % 10;
        Console.WriteLine(number3);
        return number3;
    }
    else if (number >= 1000 && number < 10000)
    {
        int number3 = number / 10  % 10;
        Console.WriteLine(number3);
        return number3;
    }
    else if (number >= 10000 && number < 100000)
    {
        int number3 = number / 100 % 10;
        Console.WriteLine(number3);
        return number3;
    }
    else if (number >= 100000 && number < 1000000)
    {
        int number3 = number / 1000 % 10;
        Console.WriteLine(number3);
        return number3;
    }
    else if (number >= 1000000 && number < 10000000)
    {
        int number3 = number / 10000 % 10;
        Console.WriteLine(number3);
        return number3;
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
        return number;
    }
    
    
    



}
ForArray(threeDigitNumber);