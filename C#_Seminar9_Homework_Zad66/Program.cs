// Семинар 9. Курс введение в прогр. Домашняя работа.
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummNatural(int max, int min)
{
    if (max == min) return min;
    {
        return max + SummNatural(max - 1, min);
    }
}
Console.Write(SummNatural(15, 1));