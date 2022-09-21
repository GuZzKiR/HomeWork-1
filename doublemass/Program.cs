// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();
Console.WriteLine("Программа  которая задает двумерный массив, заполненный случайными вещественными числами..");
Console.WriteLine("Добро пожаловать!");

Console.WriteLine("-----------");

void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().NextDouble() * 100; //заполнение мтарицы
    }
}

void PrintMatrix(double[,] matrix)
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
double[,] matrix = new double[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
