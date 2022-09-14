Console.Clear();
Console.WriteLine("Программа, которая определяет, присутствует ли заданное число в массиве.");

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10);
}


string SearchNumber (int[] array, int number)
{
    for(int i=0; i<array.Length; i++)
    {
        if (array[i] == number)
        return "Yes";
    }
        return "NO";
}

int[] array = new int[12];
InputArray(array);

Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");


Console.WriteLine("Введите искомое число: ");
    int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SearchNumber(array, n));