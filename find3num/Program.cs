Console.Clear();
Console.WriteLine("Введите число: ");
int num()
{
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

void numbers()
{
    int n = num();
        Console.WriteLine(Convert.ToString(n)[1]);
}
numbers();




