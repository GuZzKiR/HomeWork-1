//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Console.Clear();
Console.WriteLine("Найдите количество элементов массива, значения которых лежат в отрезке [10,99]");


void InputArray(int[] array) //метод(функция) для заполнения массива случайными числами
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(10, 123);
}

int Finder (int[] array)
{
    int count=0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i]>10 && array[i]<100)
        count++;
    }
    return count;
        
}
int[] array = new int[123];
InputArray(array);
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");
Console.WriteLine("Колличество элементов массива: " + Finder(array)); 
