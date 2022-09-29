// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();
Console.WriteLine("Программа вычисления функции Аккермана с помощью рекурсии.");
Console.WriteLine("Добро пожаловать!");

Console.WriteLine("-----------");
Console.WriteLine("Введите изначальное число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите финальное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int AccermanFunction(int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AccermanFunction(M - 1, 1);
    if (M > 0 && N > 0) return AccermanFunction(M - 1, AccermanFunction(M, N - 1));
return AccermanFunction(M, N);
}
Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {AccermanFunction(M, N)}");