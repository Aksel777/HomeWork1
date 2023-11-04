// for (int i=2; i<=10; i ++)
// {
//     for (int j=2; j<=10; j ++)
//     {
//     Console.WriteLine($"{i} * {j} = {i*j}");
//     }
// Console.WriteLine();

// }




// Карл у Клары украл Кол

// string text = "Карл у Клары украл Корралы";
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i=0; i<length; i++)
//     {
//         if(text[i] == oldValue) 
//         result = result + $"{newValue}";
//         else
//         result = result + $"{text[i]}";
//     }
//     return result;
// }

// string NewText = Replace(text, 'р', 'л');
// Console.WriteLine(NewText);
// Console.WriteLine();
// NewText = Replace(NewText, 'к', 'К');
// Console.WriteLine(NewText);
// Console.WriteLine();
// NewText = Replace(NewText, 'К', 'Ф');
// Console.WriteLine(NewText);




int[] arr = {1, 2, 7, 4, 9, 5, 8, 6, 3};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]}" +" ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i=0; i<array.Length-1; i++)
    {
        int minPosition=i;
        for (int j=i+1; j<array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporrary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporrary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);