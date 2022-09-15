//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


Console.Clear();
Console.WriteLine("Поиск суммы элементов, стоящих на нечётных позициях.");
Console.WriteLine("-----------------");
void InputArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10);
}

int SumArray(int[] array)
{
    int sum = 0;
    
    for(int i=1; i<array.Length; i=i+2)
    {
        if(i % 2!=0)
        sum=sum+array[i];
    }
    return sum;
}

Console.WriteLine("Введите количество элементов в массиве: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Clear();
    Console.WriteLine("Массив состоит из " + n + " элементов!");
        Console.WriteLine("-----------------");
int[] array = new int[n];
    InputArray(array);
    Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");
        Console.WriteLine("-----------------");
            Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + SumArray(array));
