Console.Clear();
Console.WriteLine("Введите колличество кустов черники: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] berry = new int[n];
int sum=0;
for(int i=0; i<berry.Length; i++)
berry[i]=new Random().Next(1, n+1);
Console.WriteLine("[" +string.Join(" ,", berry) + "]");
for(int i=0; i<berry.Length; i++)
{
    sum = i+(i+1);
}
Console.WriteLine(sum);
