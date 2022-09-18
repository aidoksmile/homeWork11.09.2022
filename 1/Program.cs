// Показать натуральные числа от M до N, N и M заданы

void PrintNumber(int m, int n)
{
    string a = "error";
    if (n < m) return;
        PrintNumber(m, n - 1);
        Console.Write(n + " ");
}

Console.WriteLine("Введите M: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine());
PrintNumber(M, N);