// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
Console.WriteLine("Программа которая которая будет находить строку с наименьшей суммой элементов.");
Console.WriteLine("Добро пожаловать!");

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
void SumMinMatrix(int[,] matrix)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumRow += matrix[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}
Console.Write("Введите кол-во строк матрицы: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов матрицы: ");
int colum = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, colum];
if (row < 4 && colum < 4)
{
    Console.WriteLine("Введите другое значение! ");
    return;
}
else
    InputMatrix(matrix);
PrintMatrix(matrix);
SumMinMatrix(matrix);