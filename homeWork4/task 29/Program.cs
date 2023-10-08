// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Вывод сделать отдельным методом.

int [] array = new int [8];
int size = 8;
int a = array [0];
array [0] = 0;
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(0, 11);
    Console.Write(" " + array[i] + ",");
}
Console.Write("]");