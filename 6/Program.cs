// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

void Fibo(int x1, int x2, int n) // расчет последовательности
{
    if (n == 0)
        return;
    else
    {
        Console.Write((x2 + x1) + " ");
        Fibo(x2, x2+x1, n - 1);
    }
}

Console.WriteLine("Введите первый элемент: ");
int a = int.Parse(Console.ReadLine());;
Console.WriteLine("Введите второй элемент: ");
int b = int.Parse(Console.ReadLine());;
Console.WriteLine("Введите длину последовательности: ");
int N = int.Parse(Console.ReadLine());;
Console.Write($"Последовательность: {a} {b} ");
Fibo(a, b, N);