// Написать программу вычисления функции Аккермана

int Akkerman(int i, int j)
{
    if (i == 0)
        return j + 1;
    else
        if ((i > 0) && (j == 0))
            return Akkerman(i - 1, 1);
        else
        {
            return Akkerman(i - 1, Akkerman(i, j - 1));
        }
}

Console.WriteLine("Введите число i: ");
int i = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число j: ");
int j = int.Parse(Console.ReadLine());
Console.WriteLine($"Функция Аккермана = {Akkerman(i, j)}");