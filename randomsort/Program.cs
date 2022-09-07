void FillArray (int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
    collection[index] = new Random().Next(1,10);
    index++;
    }
}
void PrinArray(int[]col)
{
    int count = col.Length;
    int pos = 0;
    while(pos < count)
    {
        Console.WriteLine (col[pos]);
        pos ++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i=0; i<array.Length-1; i++)
    {
        int minPosition = i;

            for(int j = i+1; j<array.Length; j++)
            {
                if(array[j]<array[minPosition]) minPosition=j;
            }
        int temporary = array[i];
        array [i] = array[minPosition];
        array[minPosition]=temporary;
    }
}
int[] array = new int[10];
FillArray(array);
//PrinArray(array);



PrintArray(array);


SelectionSort(array);
PrintArray(array);
