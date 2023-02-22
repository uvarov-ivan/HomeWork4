// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный случайными числами. Оформите заполнение массива 
// и вывод в виде функции (пригодится в следующих задачах).  
// Реализовать через функции. (* Доп сложность, 
// “введите количество элементов массива”,
//  “Введите минимальный порог случайных значений”, 
//  “Введите максимальный порог случайных значений”)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputInt(string msg)
{
    System.Console.Write($"{msg} >");
    return (Convert.ToInt32(Console.ReadLine()));
}

int[] NewArray(int len, int min, int max)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return (array);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]},");
    }
    System.Console.WriteLine();
}

int lenghtArray = InputInt("Введите желаемую длину массива");
int minArrayDigit = InputInt("Введите минимальное значение элементов массива");
int maxArrayDigit = InputInt("Введите максимальное значение элементов массива");
int[] array = NewArray(lenghtArray, minArrayDigit, maxArrayDigit);
PrintArray(array);

