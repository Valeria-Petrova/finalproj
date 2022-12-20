// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//M = 5; N = 3 -> "5, 4, 3"
//M = 8; N = 4. -> "8, 7, 6, 5, 4"

using System;
using static System.Console;
Write("Введите число N: ");
int N = int.Parse(ReadLine());
WriteLine(PrintNumbers(N));

string PrintNumbers(int end)
{
    if (end == 1)
    return "1";
    return (end.ToString() +' ' + PrintNumbers(end-1));
    
}