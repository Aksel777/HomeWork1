int[] GenerateArray(int size)
{
    Random random = new Random();
    int[] array = new int[size];

    for (int i=0; i<array.Length; i++)
    {
        array[i] = random.Next(1,10);
    }
    return array;
}

int[] NewArray(int[] array)
{
    int[] newArray = new int[array.Length/2 + array.Length%2];
    for(int i=0; i<newArray.Length; i++)
    {
        newArray[i] = array[i] * array[(array.Length-1) - i];
        if(i == (array.Length-1) - i)
        {
            newArray[i] = array[i];
        }
    }
    return newArray;
}

int[]array = GenerateArray(size:7);
Console.Write(String.Join(" ", array));
Console.WriteLine();
Console.Write(String.Join(" ", NewArray(array)));
