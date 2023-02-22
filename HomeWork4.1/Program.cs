// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputInt(string msg)
{
    System.Console.Write($"{msg} >");
    return (Convert.ToInt32(Console.ReadLine()));
}

int SumDigits(int num)
{
    int res = 0;
    while (num > 0)
    {
        res += num % 10;
        num /= 10;
    }
    return (res);
}

int number = InputInt("Введите число");
System.Console.WriteLine($"Сумма цифр числа {number} равна {SumDigits(number)}.");
