int[] RandomArray(int length, int leftBorder, int rightBorder)
{
    int[] array = new int[length];

    for (int i=0; i<array.Length; i++)
    {
        array[i]= Random.Shared.Next(leftBorder, rightBorder+1);
    }
    return array;
}

bool SortArray(int[]array, int num)
{
    for(int i=0; i<array.Length; i++)
    {
        if(array[i] == num)
        {
            return true;
        }
        
    }
return false;
}

int[]myArray = RandomArray(10, -10, 10);
Console.WriteLine(string.Join(", ", myArray));
bool result = SortArray(myArray,7);
Console.WriteLine(result);