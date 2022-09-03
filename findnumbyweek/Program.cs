//""" Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
//Пример: - 6 -> да - 7 -> да - 1 -> нет  """
Console.Clear();
Console.Write("Введите число от 1 до 7: ");
void week()
{
    int n = Convert.ToInt32(Console.ReadLine());
    if (n == 6) Console.Write("Yes it is Saturday!");
    if (n == 7) Console.Write("Yes it is Sunday!");
    if (n < 6) Console.Write("You are bad, it's a work time!");
    if (n > 7) Console.Write("Oh my God, you broke me!");
}
week();


















