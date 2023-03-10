// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29


using System;
using static System.Console;
Write("Введите число N: ");
int N = int.Parse(ReadLine());
Write("Введите число M: ");
int M = int.Parse(ReadLine());




int FunctionAkkermana(int M, int N)
{
  if (M == 0)
    return N + 1;
  else
    if ((M != 0) && (N == 0))
      return FunctionAkkermana(M - 1, 1);
    else
      return FunctionAkkermana(M - 1, FunctionAkkermana(M, N - 1));
}
WriteLine($"A(m,n) = {FunctionAkkermana(M,N)}");