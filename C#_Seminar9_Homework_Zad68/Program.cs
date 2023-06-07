// Семинар 9. Курс введение в прогр. Домашняя работа.
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAkkerman(int n, int m)
{
    while (n != 0)
    {
      if (m == 0)
      {
      m = 1;
      }
      else
      {
      m = FunctionAkkerman(n, m - 1);
      }
      n = n - 1;
    }
    return m + 1;
}
Console.Write("Решение 1. Функция Аккермана = ");
Console.WriteLine(FunctionAkkerman(2, 3));


int FunctionAkkerman2(int n, int m)
{
  if (n == 0) return m + 1;
    if (m == 0)
      return FunctionAkkerman2(n - 1, 1);
    else
      return FunctionAkkerman2(n - 1, FunctionAkkerman2(n, m - 1));
}
Console.Write("Решение 2. Функция Аккермана = ");
Console.Write(FunctionAkkerman2(2, 3));



// Википедия о функции Аккермана. Псевдокод.
// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))


// функция ack(n, m)
//    пока n ≠ 0
//      если m = 0
//        m:= 1
//      иначе
//        m:= ack(n, m - 1)
//      n:= n - 1
//    вернуть m + 1
// Спасибо Википедия!
// Значения, что бы проверить правильность кода:
// uint res;
// res = A(1, 2); // res = 4
// res = A(0, 1); // res = 2
// res = A(0, 0); // res = 1
// res = A(2, 2); // res = 7