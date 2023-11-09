// развернуть массив

int[] RandomArray(int length, int leftBorder, int rightBorder)
{
    int[] array = new int[length];

    for (int i=0; i<array.Length; i++)
    {
        array[i]= Random.Shared.Next(leftBorder, rightBorder+1);
    }
    return array;
}
 void ReverseArray (int[] sourceArray)
 {
    for(int i=0; i<sourceArray.Length/2; i++)
    {
        int temp = sourceArray[i];
        sourceArray[i] = sourceArray[sourceArray.Length-i-1];
        sourceArray[sourceArray.Length-i-1] = temp;
    }
 }

int length = 7;
int leftBorder = -10;
int rightBorder = 10;
 int[] myArray = RandomArray(length, leftBorder, rightBorder);
 Console.WriteLine(string.Join(", ", myArray));
 ReverseArray(myArray);
 Console.WriteLine(string.Join(", ", myArray));