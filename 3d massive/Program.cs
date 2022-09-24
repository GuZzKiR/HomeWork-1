// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2


Console.Clear();
Console.WriteLine("Программа  которая будет построчно выводить массив, добавляя индексы каждого элемента.");
Console.WriteLine("Добро пожаловать!");
int[,,] matrix3D = new int[2, 2, 2];
FillMatrix(matrix3D);
Console.WriteLine("_______");
Console.WriteLine("Массив и его индексы: ");
PrintIndex(matrix3D);
void PrintIndex(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"{matrix3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

// Функция заполнения 3D массива не повторяющимеся числами
void FillMatrix(int[,,] matrix3D)
{
    int count = 10;
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[k, i, j] += count;
                count += 3;
            }
        }
    }
}
