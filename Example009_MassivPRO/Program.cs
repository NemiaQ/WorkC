void FillArray(int[] collection)
{
    int i = 0;
    while (i < collection.Length)
    {
        collection[i] = new Random().Next(0, 10);
        i++;
    }
    //return collection;
}

void PrintArray(int[] collection)
{
    int i = 0;
    while (i < collection.Length)
    {
        Console.WriteLine(collection[i]);
        i++;
    }
}

int FindPosition(int find, int[] collection)
{
    int i = 0;
    int position = -1;
    while (i < collection.Length)
    {
        if (collection[i] == find)
        {
            position = i;
            break;
        }
        i++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = FindPosition(77, array);
Console.WriteLine(pos);
