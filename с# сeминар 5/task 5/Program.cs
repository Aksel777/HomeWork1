
// static int[] GenerateArray(int size)
// {
//     Random random = new Random();
//     int[] array = new int[size];

//     for (int i=0; i<array.Length; i++)
//     {
//         array[i] = random.Next(1,15);
//     }
//     return array;
// }

// static int FindCount(int[] array)
// {
//     int count = 0;
//     for(int i=0; i<array.Length; i++)
//     {
//         if(array[i]>= 10 && array[i]<=99)
//         {
//             count ++;
//         }
//     }
//     return count;
// }

// int [] array = GenerateArray(6);
// Console.Write(String.Join(" ", array));
// Console.WriteLine();
// Console.Write(FindCount(array));

using System;

public class Answer
{
    public static int CountEvenElements(int[] array)
    { 
    // Введите свое решение ниже
      
    int count = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]%2==0)
        {
            count ++;
        }
    }
    return count;
  }

    public static void PrintArray(int[] size)
    {
    // Введите свое решение ниже
     
      int[] array = new int[size] ;
      for(int i=0; i<array.Length; i ++) 
        {
           array[i] = new int {100, 102, 105, 166, 283, 764, 300, 499, 133};
        }
      return;
    }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        Console.WriteLine("Массив:");
        PrintArray(array);
        int evenCount = CountEvenElements(array);
        Console.WriteLine($"Количество четных элементов: {evenCount}");
    }
}