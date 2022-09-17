// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Программа  которая найдёт точку пересечения двух прямых.");
Console.WriteLine("Добро пожаловать!");

Console.WriteLine("-----------");


Console.WriteLine("Введите координаты первой линии: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй линии: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    double k2 = Convert.ToDouble(Console.ReadLine());
            
double x = 0;
double y = 0;

if(b1 == b2 && k1 == k2) Console.WriteLine("Прямые совпадают!");
    else if(k1 == k2) Console.WriteLine("Прямые параллельны!");
else
{
    x= (b1 - b2) / (k1 - k2);
    y= k1 * x + b1;
    Console.WriteLine("Точка пересечения "+"(" + x +";" + y + ")");
}
Console.WriteLine();
Console.WriteLine("-----------");
Console.WriteLine("Спасибо за использование! Удачи!");
