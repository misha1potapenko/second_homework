// Задача 10: Напишите программу,
//  которая принимает на вход трёхзначное 
//  число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное чило: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(threeDigitNumber);

int ForArray(int number)
{
    
    if (number < 999 && number > 99)
    {
        int number2 = number / 10 % 10;

        Console.WriteLine(number2);
        return number2;
    }
    
    else
    {
        Console.WriteLine("Вы ввели не трехзначное число");
        int anothe = Convert.ToInt32(Console.ReadLine());
        number = anothe;
        return number;
    }
    
    
    



}
ForArray(threeDigitNumber);