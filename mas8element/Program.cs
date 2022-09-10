//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
//На всякий случай сдела два вариатна выдачи массива, в рандоме и со ввод данных!

int [] numbers = new int[8];

for(int i=0; i<numbers.Length; i++) 
    numbers[i] = new Random().Next(0,100);

//Console.WriteLine("[" +string.Join(" ,", numbers) + "]");


Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int e = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int f = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int g = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int h = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("["+ string.Join(", ", +a, b, c, d, e ,f, g, h)+ "]");
Console.WriteLine("[" +string.Join(" ,", numbers) + "]");