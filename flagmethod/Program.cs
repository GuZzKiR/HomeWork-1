// метод флажка
// break - ломать

bool flag = true;

// Найдите минимальный делитель числа
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (flag)
{
if (n % i == 0)
{
Console.WriteLine(i);
flag = false;
}
i++;
}
// сравнение массивов на похожесть
Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
int[] arrayFirst = new int[n];
for (int i = 0; i < n; i++)
arrayFirst[i] = Convert.ToInt32(Console.ReadLine());

int m = Convert.ToInt32(Console.ReadLine());
// int[] arraySecond = new int[n];
bool flag = true;
for (int i = 0; i < m; i++)
{
int k = 0;
int x = Convert.ToInt32(Console.ReadLine());
for (int j = 0; j < n; j++)
{
if (arrayFirst[j] == x)
{
k++;
}
}
if (k < 1)
flag = false;

}
if (flag)
Console.WriteLine("YES");
else
Console.WriteLine("NO");

// вводить числа в массив в одной строке через пробел
split
// алгебра логики


//округляет дробные числа 
Console.Clear();


double n = 1.13425346241235325346364;
Console.WriteLine(Math.Round(n, 3));