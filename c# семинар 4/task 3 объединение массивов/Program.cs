Console.WriteLine("enter size");
int n = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
int[] arr1 = new int[n];
int[] arr2 = new int[n];
int[] arr3 = new int[n];

for (int i=0; i<arr1.Length; i++)
{
    arr1[i] = rand.Next(0,50);
    arr2[i] = rand.Next(0,50);
    arr3[i] = arr1[i] + arr2[i];
}

for (int i=0; i<arr1.Length; i++)
{
    Console.Write(arr1[i] + " ");
}
Console.WriteLine();
for (int i=0; i<arr1.Length; i++)
{
    Console.Write(arr2[i] + " ");
}
Console.WriteLine();
for (int i=0; i<arr1.Length; i++)
{
    Console.Write(arr3[i] + " ");
}
