//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.Write("Введите ваше имя ");
string username = Console.ReadLine();

    Console.WriteLine();

Console.Write("Привет,  ");
Console.WriteLine(username+"!");

    Console.WriteLine();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.WriteLine(i + "^3="+ i * i*i);
    Console.WriteLine();

Console.Write("Ты красавчик,  ");
Console.WriteLine(username+"!");