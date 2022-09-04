//""" Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
//Пример: - 6 -> да - 7 -> да - 1 -> нет  """
Console.Clear();
Console.Write("Введите число от 1 до 7: ");
void week()
{
    int n = Convert.ToInt32(Console.ReadLine());
    if (n == 6 || n == 7) Console.Write("Yes it is weekend!");
        else if (n > 7 || n==0) Console.Write("Oh my God, you broke me!");
        else Console.Write ("You are bad, it's a work time!");   
}
week();


















