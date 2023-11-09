
static int[] GenerateArray(int size)
{
    Random random = new Random();
    int[] array = new int[size];

    for (int i=0; i<array.Length; i++)
    {
        array[i] = random.Next(1,100);
    }
    return array;
}

static int FindCount(int[] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>= 10 && array[i]<=99)
        {
            count ++;
        }
    }
    return count;
}

int [] array = GenerateArray(11);
Console.Write(String.Join(" ", array));
Console.WriteLine();
Console.Write(FindCount(array));
