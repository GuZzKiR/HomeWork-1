// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
Console.WriteLine("Программа  которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("Добро пожаловать!");

Console.WriteLine("-----------");

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 10); //заполнение мтарицы
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t"); //вывод матрицы
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);


Console.Write("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (rows < matrix.GetLength(0) && colums < matrix.GetLength(1)) Console.WriteLine("Искомый элемент: " + matrix[rows, colums]);
else Console.WriteLine("-> Упс! Такого эелемента в массиве нет");
Console.WriteLine("-----------");
Console.WriteLine("Спасибо за внимание!");