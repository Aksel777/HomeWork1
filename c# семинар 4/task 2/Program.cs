int[]FillArray(int size)
{
    int[]array = new int[size];
    for (int index = 0; index < array.Length; index ++)
    {
        array[index]= new Random().Next(0,2);
        Console.Write($"{array[index]},");
    }
   return array;
}
Console.WriteLine("Enter array size");
int size = int.Parse(Console.ReadLine());
FillArray(size);