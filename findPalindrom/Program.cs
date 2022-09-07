// //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.Write("Введите число: ");
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
            Console.WriteLine("Я не сомневался в вас, что у вас получится!");
        }
        else
        {
            Console.WriteLine("Упс! Это не Палиндром!");
            Console.WriteLine("Не сдавайтесь и попробуйте еще раз! Я в вас верю!");
        }        