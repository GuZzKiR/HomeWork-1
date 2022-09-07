// //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.Write("Введите ваше имя ");
string username = Console.ReadLine();

    Console.WriteLine();

Console.Write("Привет,  ");
Console.WriteLine(username+"!");

    Console.WriteLine();

Console.WriteLine("Введите число: ");
int num, rem, sum = 0, temp;
num = Convert.ToInt32(Console.ReadLine());
temp = num;
    while (Convert.ToBoolean(num))
        {
            rem = num % 10; 
            num = num / 10; 
            sum = sum * 10 + rem; 
        }
        if (temp == sum)
        {
            Console.WriteLine("Ура! Это палиндром!"); 
            Console.WriteLine("Я не сомневался в вас," + username+"!");
        }
        else
        {
            Console.WriteLine("Упс! Это не Палиндром!");
            Console.WriteLine("Не сдавайтесь," + username+"!");
        }        