// Написать программу которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3.
Console.Clear();
Console.WriteLine("Программа которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3.");
Console.WriteLine("Добро пожаловать!");
Console.WriteLine("-----------------");

void FindWords(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {

        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

void PrintArrayCopy(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}


string[] array1 = new string[4] { "Hello", "2", "world", ":-)" };
string[] arraycopy1 = new string[array1.Length];

string[] array2 = new string[4] { "1234", "1567", "-2", "computer science" };
string[] arraycopy2 = new string[array2.Length];

string[] array3 = new string[3] { "Russia", "Denmark", "Kazan" };
string[] arraycopy3 = new string[array3.Length];


Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array1) + "]");
FindWords(array1, arraycopy1);
PrintArrayCopy(arraycopy1);
Console.WriteLine();
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array2) + "]");
FindWords(array2, arraycopy2);
PrintArrayCopy(arraycopy2);
Console.WriteLine();
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array3) + "]");
FindWords(array3, arraycopy3);
PrintArrayCopy(arraycopy3);