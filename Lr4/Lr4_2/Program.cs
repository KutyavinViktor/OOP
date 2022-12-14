int[] Create(int n)
{
    var rand = new Random();
    int[] massiv = new int[n];
    for (int i = 0; i < n; i++)
    {
        massiv[i] = rand.Next(100);
    }

    return massiv;
}

void Print(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]} \t");
    }
}

void SortArr(int[] arr)
{
    int maxValue = arr[0];
    int position = 0;

    // перебор элементов с целью поиска максимального значения в
    // массиве и его индекса
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxValue)
        {
            maxValue = arr[i];
            position = i;
        }
    }

    // сортировка по возрастанию до <максимального значения>
    for (int j = 0; j < position - 1; j++)
    {
        // первое приближение позиции максимального значения
        int min = j;
        for (int i = j + 1; i < position; i++)
        {
            if (arr[i] < arr[min])
            {
                min = i;
            }
        }

        // переопределение значений
        (arr[j], arr[min]) = (arr[min], arr[j]);
    }

    // сортировка по убыванию после <максимального значения>
    for (int k = position + 1; k < arr.Length; k++)
    {
        // первое приближение позиции минимального значения
        int max = k;

        // перебор элементов массива
        for (int l = k + 1; l < arr.Length; l++)
        {
            if (arr[l] > arr[max])
            {
                max = l;
            }
        }

        // переопределение значений
        (arr[k], arr[max]) = (arr[max], arr[k]);
    }
}

int value = 10;
int[] d = Create(value);
Console.WriteLine("Сгенерированный массив:");
Print(d);
SortArr(d);
Console.WriteLine("\nОтсортированный массив:");
Print(d);
