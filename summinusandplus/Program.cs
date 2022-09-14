void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10);
}

int SummaPositive(int[] array)
{
    int summa_p = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    summa_p += array[i];
}
    return summa_p;
}

int SummaNegative(int[] array)
{
    int summa_n = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    summa_n += array[i];
}
    return summa_n;
}

int[] arr = new int[12];
InputArray(arr);
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", arr) + "]");
Console.WriteLine("Сумма положительных чисел равна: " + SummaPositive(arr));
Console.WriteLine("Сумма отрицательных чисел равна: " + SummaNegative(arr));