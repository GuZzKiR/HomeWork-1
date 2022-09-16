// Разворот
// int n = Convert.ToInt32(Console.ReadLine());

// void InputArray(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 10);
// }

// for(int i=0; i<array.Length/2; i++)
// {
//     int t =array[i];
//     array[i]= array[array.Length/2-1-i];
//     t=array[array.Length/2-1-i];
// }
// InputArray(array);
// int[] array = new int[n];

// Console.WriteLine(array);


// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
//  if (a<b + a&&b + b&&c < a+b)
//  Console.WriteLine("Треугольник огонь");
// else Console.WriteLine("Плохой Треугольник");

// Труегольгик
// Console.Clear();
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());

// if (a < b + c && b < a + c && c < a + b)
//     Console.WriteLine("Треугольник огонь");
// else
//     Console.WriteLine("Плохой Треугольник");

// ПЕревод в двоичную
Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// string result = ""; //переводим результат в строку
// while (n > 0)
// {
//     int x = n % 2; //ищем остаток и записываем его
//     result = Convert.ToString(x) + result; //остаток +результат
//     n = n / 2; 
// }
// Console.WriteLine("Двоичное число: "+result);

// через рекурсию
// Console.Clear();
// string f(int n)
// {
//     if (n == 0 || n == 1)
//         return Convert.ToString(n);
    
//     return f(n / 2) + Convert.ToString(n % 2);
// }

// Console.WriteLine(f(11));



// Фиббоначи буз рукурсии
// int number = Convert.ToInt32(Console.ReadLine());


// int perv = 0;
// Console.Write("{0} ", perv);
// int vtor = 1;
// Console.Write("{0} ", vtor);
// int sum = 0;
// while (number >= sum)
//             {
//                 sum = perv + vtor;
                
//                     Console.Write("{0} ", sum);
                    
//                         perv = vtor;
//                         vtor = sum;                
//                 }
// // через массив
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// array[0] = 0;
// array[1] = 1;
// for (int i = 1; i < n - 1; i++)
// {
//     array[i + 1] = array[i] + array[i - 1];
// }
// Console.WriteLine("[" + string.Join(", ", array) + "]");

// копирование массива, массив копируется с 0 значения и до конца
// Console.Clear();
// int[] array = {1, 2};
// int[] array1 = new int[array.Length];
// for (int i = 0; i < array.Length; i++)
//     array1[i] = array[i];
// array1[0] = 10;
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine(string.Join(", ", array1));

