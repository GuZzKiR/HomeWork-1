void ReleaseMatrix(int[] array)
{
int[] help_array = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
int count = 1;
bool flag = true;
foreach (int el in help_array)
{
if (array[i] == el)
flag = false;
}
if (flag)
{
for (int j = 0; j < array.Length; j++)
{
if (array[i] == array[j] && i != j)
{
count++;
help_array[i] = array[i];
}

}
Console.WriteLine(array[i] + " встречается " + count + " раз");
}
}
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
int[] array = new int[n * m];
InputMatrix(matrix, array);
PrintMatrix(matrix);
ReleaseMatrix(array);