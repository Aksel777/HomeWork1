// преобразовать исло из десятичной в двоичную систему


// Console.WriteLine("enter number");
// int number = int.Parse(Console.ReadLine());

// int convert(int arg1)
// {
//     int size = 0;
//     int number = arg1;
//     // for(int i=0; arg1>0; i ++)
//     while(arg1>0)
//     {
//         arg1 = arg1/2;
//         size++;
//     }
// return size;
// }

// int[]FillArray(int size, int number)
// {
//     int [] array = new int[size];
//     for (int i=0; i<array.Length; i++)
//     {
//         array[i] = number%2;
//         number = number/2;
//     }
// return array;
// }

// int[] ReverseArray(int[]array)
// {
//     for (int i=0; i<array.Length/2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length-i-1];
//         array[array.Length-i-1] = temp;
//     }
//     return array;
// }


// convert(number);
// int[]array = FillArray(convert(number), number);

// Console.WriteLine(string.Join(" ,", ReverseArray(array)));

int number = int.Parse(Console.ReadLine());

void  PrintBinaryView(int number)
{
if(number <= 0) return;
PrintBinaryView(number/2);
Console.Write(number%2);
}
PrintBinaryView(number);

