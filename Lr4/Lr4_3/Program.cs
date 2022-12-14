int summa = 0;
int Function(int n, int i)
{

    if (n == 1)
    {
        return 1;
    }

    else
    {
        if (i <= n)

        {
            summa += (n / i);
            return Function(n, i + 1);
        }

    }

    return summa;
}

Console.WriteLine(Function(5, 2));

