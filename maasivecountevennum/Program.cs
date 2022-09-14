//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
Console.WriteLine("Программа, которая покажет количество четных чисел в массиве");


void InputArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(99, 999);
}

int Finder (int[] array)
{
   int count = 0;
   
   for(int i = 0; i<array.Length; i++)
    {
        if(array[i]%2==0)
        count++;
    }
    return count;
}
int[] array = new int[10];
InputArray(array);
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");
Console.WriteLine("Колличество четных чисел массива: " + Finder(array)); 
