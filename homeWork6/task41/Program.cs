int Promt (string message)
{
    Console.Write(message);
    Console.WriteLine();
    string value = Console.ReadLine();
    int result  = Convert.ToInt32(value);
    return result;
}

int[] InputArray(int length)
{
    int[] array = new int[length];

    for (int i=0; i<array.Length; i++)
    {
        array[i]= Promt($"enter {i + 1}-st element");
    }
    return array;
}
 void PrintArray(int[]array)
 {
    for (int i=0; i<array.Length; i++)
    {
        Console.WriteLine($"a[{i}]={array[i]}");
    }
 }

 int CountOfPositive(int[] array)
 {
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        
        if (array[i] > 0) count ++;
    }
    return count;
 }

 int length = Promt("enter elements >");
 
 int[] array;
 array = InputArray(length);
 PrintArray(array);
 Console.WriteLine($"Count of positive numbers - {CountOfPositive(array)}");
