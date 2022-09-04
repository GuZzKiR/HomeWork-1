// //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numt = Convert.ToString(num);
if (numt.Length > 2)
{
  Console.WriteLine(numt[2]);
}
else 
{
  Console.WriteLine("Упс! Третьей цифры нет!");
}