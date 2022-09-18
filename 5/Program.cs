// Написать программу возведения числа А в целую стень B

int ExpFunction(int a, int b) // Возведение в степень
{
    if (b == 0)
        return 1;
    else
        return a * ExpFunction(a, b - 1);

}

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"{A}^{B} = {ExpFunction(A, B)}");