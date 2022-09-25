// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

Console.Clear();
Console.WriteLine("Программа которая которая будет находить произведение двух матриц.");
Console.WriteLine("Добро пожаловать!");

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 4); //заполнение мтарицы
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

Console.Write("Введите кол-во строк первой матрицы: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов первой матрицы: ");
int colum = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, colum];
InputMatrix(matrix);
Console.WriteLine("Первая матрица: ");
PrintMatrix(matrix);
int[,] secondMatrix = new int[row, colum];
InputMatrix(secondMatrix);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(secondMatrix);

int[,] resultMatrix = new int[row, colum];
if (matrix.GetLength(0) != secondMatrix.GetLength(1))
{
    Console.WriteLine("Матрицы невозможно перемножить!");
    return;
}
else for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix[i, k] * secondMatrix[k, j];
            }
        }
    }
Console.WriteLine("Результат произведения матриц: ");
PrintMatrix(resultMatrix);
