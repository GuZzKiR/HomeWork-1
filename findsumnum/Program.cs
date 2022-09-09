Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int num = 1;

for(int i = 0; i<b; i++)
{
    num *=a;
}
Console.WriteLine(num);
Console.Write(a + "^" + b);

//Console.WriteLine(Math.Pow(a,b));
//Console.Write(a+"^"+b);
