//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

Console.Clear();
Console.WriteLine("Найдите произведение пар чисел в одномерном массиве.");
Console.WriteLine("Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.");
Console.WriteLine();
void InputArray(int[] array) //метод(функция) для заполнения массива случайными числами
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10);
}


void ResultArray (int[] array) // метод(функция) для получения массива из произведений чисел в исходном массиве
{
    int LenArray;
    if(array.Length%2==0)
        LenArray=array.Length/2;
            else
            LenArray=array.Length/2+1;
    int[] LenResult = new int [LenArray];
    
    for(int i = 0; i<LenArray; i++)
    {
        LenResult[i]=array[i]*array[array.Length - i -1];
    }
    Console.WriteLine("Конечный массив: [" +string.Join(", " , LenResult)+ "]"); 
    
}

int[] array = new int[5];
InputArray(array);
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");
ResultArray(array);
