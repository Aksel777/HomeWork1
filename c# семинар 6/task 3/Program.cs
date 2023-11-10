// не используя рекурсию, вывести первые Н чисел

// int num = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[num];
// Fibb(arr);

// void Fibb(int[] arr)
// {
//     for (int i=0; i<arr.Length; i++)
//     {
//         if (i==0||i==1) arr[i] = i;
//         else arr[i] = (arr[i-1])+(arr[i-2]);
//     }
// }
// Console.WriteLine(string.Join(" ,", arr));


 int num = Convert.ToInt32(Console.ReadLine());
int[]Fibb(int num)
{
int[] fibb = new int[num];
fibb[0] = 0;
fibb[1] = 1;
for( int i=2; i<num;i++)
{
fibb[i] = fibb[i-1]+ fibb[i-2];
}
return fibb;
}

Fibb(num);
Console.WriteLine(string.Join(" ,",Fibb(num)));