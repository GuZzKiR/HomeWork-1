Console.Clear();
Console.WriteLine("Программа  которая меняет местами стобец и строку.");
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
int[,] ReleaseMatrix(int[, ] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = i + 1; j < matrix.GetLength(1); j++)
{
int x = matrix[i, j];
matrix[i, j] = matrix[j, i];
matrix[j, i] = x;
}
}
return matrix;
}


Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n != m)
Console.WriteLine("no");
else
{
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
PrintMatrix(ReleaseMatrix(matrix));
}