// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputInt(string msg)
{
    System.Console.Write($"{msg} >");
    return (Convert.ToInt32(Console.ReadLine()));
}

double Exponentiation(int num, int deg)
{
    double resalt = 1;
    if (deg > 0)
    {
        for (int i = 0; i < deg; i++)
        {
            resalt *= num;
        }
    }
    else
    {
        for (int i = 0; i > deg; i--)
        {
            resalt /= num;
        }
    }
    return (resalt);
}

int number = InputInt("Введите число возводимое в степень");
int degree = InputInt("Введите степень числа");

System.Console.WriteLine($"Число {number} в степени {degree} равняется {Exponentiation(number, degree)}.");
