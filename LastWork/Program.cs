// Написать программу которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3.
 Console.Clear();
Console.WriteLine("Программа которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3.");
Console.WriteLine("Добро пожаловать!");
Console.WriteLine();


		string[] array1 = {"Hello", "2", "world", ":-)"};
		string[] array2 = {"1234", "1567", "-2", "computer science"};
		string[] array3 = {"Russia", "Denmark", "Kazan"};
		
		int word_length = 3;

      string[] GetShortWords(string[] array)
		{
			int length = array.Length;			
			string[] result = new string[length];
			int count = 0;
			
			for (int i = 0; i < length; i++)
			{
				if(array[i].Length <= word_length)
				{
					result[count] = array[i];
					count++;
				}
			}
			Array.Resize(ref result, count);
			
			return result;
		}  