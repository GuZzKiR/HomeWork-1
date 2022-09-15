//Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
Console.WriteLine("Программа ищет разницу между максимальным и минимальным элементов массива.");
Console.WriteLine("-----------");

Console.WriteLine("Введите необхожимое число элементов в массиве: ");
int n =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-----------");
double[] array = new double[n]; 
   for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().NextDouble() * 100;
}
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");
double max =array[0];
double min =array[0];

for(int i=0; i<array.Length; i++)
{
    if(max < array[i])
    {
    max = array[i];
    }
        if(min > array[i])
        {
        min = array[i];
        }
}
    double result=max - min;
    Console.WriteLine("-----------");
        Console.WriteLine("Разница между максимальным: [" + (max) +"] и минимальным: ["+ (min) +"] элементами: ["+ (result)+"]");
   




