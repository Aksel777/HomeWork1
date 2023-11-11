int[,] NewMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for(int i=0; i< matrix.GetLength(0); i++)
    {
        for(int j=0; j< matrix.GetLength(1); j++)
        {
            matrix[i,j] = Random.Shared.Next(1, 50);
        }
    }
    return matrix;
} 

void PrintMatrix(int[,] matrix)
{
    
    for(int i=0; i< matrix.GetLength(0); i++)
    {
        for(int j=0; j< matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
            
        }
        Console.WriteLine();
    }
} 

int CountNumbers(int[,] matrix)
{
    int count = 0;
    for(int i=0; i< matrix.GetLength(0)&&i< matrix.GetLength(1); i++)
    {
        // for(int j=0; j< matrix.GetLength(1); j++)
        // {
        //     if(i==j)
        //     {
                 count = count + matrix[i,i];
            // }
//         }
}
    return count;
}

const int Rows = 5;
const int Columns = 5;

int[,] myMatrix = NewMatrix(Rows, Columns);
PrintMatrix(myMatrix);
int Count = CountNumbers(myMatrix);
Console.WriteLine(Count);
