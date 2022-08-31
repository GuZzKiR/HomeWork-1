Console.WriteLine("Введите числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if ( a < b ) max = b;
Console.WriteLine (max);