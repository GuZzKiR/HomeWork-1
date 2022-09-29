// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.WriteLine("Программа которая которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine("Добро пожаловать!");

Console.WriteLine("-----------");

Console.WriteLine("Введите изначальное число: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите финальное число: ");
int N = int.Parse(Console.ReadLine());

void SumNumberFromMtoN(int M, int N, int sum)
{
    if (M > N)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    else Console.WriteLine("Найти сумму натуральных элементов в заданном промежутке невозможно!");
    return;
    sum = sum + (M++);
    SumNumberFromMtoN(M, N, sum);
}
Console.WriteLine("-----------");
SumNumberFromMtoN(M, N, 0);

