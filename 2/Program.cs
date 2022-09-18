﻿// Найти сумму элементов от M до N, N и M заданы

int SumNumber(int m, int n)
{
    if (n == m) return n;
    return (m + SumNumber(m + 1, n));
}

Console.WriteLine("Введите M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма элементов от {M} до {N} равна: {SumNumber(M, N)}");