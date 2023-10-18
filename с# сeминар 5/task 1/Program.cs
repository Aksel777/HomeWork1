int[] GetRandomArray(int length, int leftBorder, int rightBorder)
{
    int[] array = new int[length];

    for (int i=0; i<array.Length; i++)
    {
        array[i]= Random.Shared.Next(leftBorder, rightBorder+1);
    }
    return array;
}

int SumPositiveElments(int[] array)
{
    int sum = 0;
    for(int i=0; i<array.Length; i++)
    {
        if (array[i]>0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
int SumNegativeElments(int[] array)
{
    int sum = 0;
    for(int i=0; i<array.Length; i++)
    {
        if (array[i]<0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int Length = 5;
int rightBorder = 12;
int leftBorder = -12;

int[] myArray = GetRandomArray(Length, leftBorder, rightBorder);
string myArrayString = string.Join(", ", myArray);
Console.WriteLine("[" + myArrayString + "]");
int SumNegative = SumNegativeElments(myArray);
int SumPositive = SumPositiveElments(myArray);


Console.WriteLine ($"сумма положительных чисел = {SumPositive}, отрицательных = {SumNegative}");