void FillArray(int[] collection) // void -невозвратный метод (нельзя использовать return), FillArray - случайное множество
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++; // - то же index = index+1;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int ind = 0;
    while (ind < count)
    {
        Console.WriteLine(col[ind]);
        ind++;
    }
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);