// Найти сумму цифр числа

int DigitsSum(int n)
{
    if (n == 0) return 0;
    return n % 10 + DigitsSum(n / 10);
}

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {n} = {DigitsSum(n)}");