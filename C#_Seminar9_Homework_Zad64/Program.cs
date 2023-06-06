// Семинар 9. Курс введение в прогр. Домашняя работа.
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void AllNaturalNumbers(int max, int min)
{
    if (min == max) Console.Write($"{max}, ");
    else
    {
        AllNaturalNumbers(max, min + 1);
        Console.Write($"{min}, ");
    }
}
AllNaturalNumbers(10, 2);