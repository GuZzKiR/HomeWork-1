// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Console.Clear();
Console.WriteLine("Программа ищет сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine("-----------");

Console.WriteLine ("Введите любые целые числа, через запятую: ");
string numbers = Console.ReadLine();

string [] newNumbers = new string [numbers.Length];
int k = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
  if (numbers[i] == ',')
  {
    k++;
  }
  else
  {
    newNumbers[k] = newNumbers[k]+$"{numbers[i]}";
  }
}
k++;

int [] resultNumbers = new int[k];

PrintArray (resultNumbers, newNumbers);
int count = 0;
for (int i = 0; i < k; i++)
{
  if (resultNumbers[i]>0)
  {
    count++;
  }
}
Console.WriteLine ("Количество чисел больше нуля: " +count);

void PrintArray (int [] array, string [] string1)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(string1[i]);
  Console.Write("[ "+ array[i]+ " ]");                                  
  }
Console.WriteLine();
}