// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
Console.WriteLine("Программа  которая ищет среднее арифметическое элементов в каждом столбце.");
Console.WriteLine("Добро пожаловать!");

Console.WriteLine("-----------");

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void PrintArray(double[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write(matrix[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, colums];
FillMatrix(matrix);
PrintMatrix(matrix);
double[] avgNumbers = new double[matrix.GetLength(1)];

for (int i = 0; i < matrix.GetLength(1); i++)
{
    double result = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        result += matrix[j, i];
    }
    avgNumbers[i] = result / matrix.GetLength(0);
}
Console.WriteLine("Среднеарифметическое столбцов: ");
PrintArray(avgNumbers);
Console.WriteLine("-----------");
Console.WriteLine("Спасибо за внимание!");