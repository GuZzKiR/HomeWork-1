int GenerateRandomNumber()
{
    int n = new Random().Next(100, 1000);
    return n;
}
void CompraiseNumber ()
{ 
    int n= GenerateRandomNumber();
    Console.WriteLine(n);
    int a = n / 100;
    int b = n % 10;
    Console.WriteLine(a * 10 + b);
}

CompraiseNumber();