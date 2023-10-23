int[] FillArray(int Length)
{
    int[] array = new int[Length];

    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(-15,15);
        Console.Write($" {array[i]}, ");
    }
    return array;
}

int[] PrintArray (int[]array)
{
        for (int i=0; i<array.Length; i++)
    {
        array[i] = array[i]*-1;
        Console.Write($" {array[i]}, ");
    }
     return array;
}

Console.Clear();
Console.WriteLine("enter array size");
int size = int.Parse(Console.ReadLine());

int[]array = FillArray(size);
Console.WriteLine(" ");
PrintArray(array);
