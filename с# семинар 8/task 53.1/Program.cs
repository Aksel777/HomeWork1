int[,] FirstMatrix(int rows, int columns)
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
void Swap (int[,] matrix)
{
    int temp = 0;
    for(int i=0; i<matrix.GetLength(1);i++)
    {
        // (a,b)=(b,a)
        temp = matrix[0,i];
        matrix[0,i] = matrix[matrix.GetLength(0)-1,i];
        matrix[matrix.GetLength(0)-1,i] = temp;
    }
}

int[,] matr = FirstMatrix(3, 5);
Console.WriteLine("Старый массив");
PrintMatrix(matr);

Console.WriteLine("Новый");
Swap(matr);
PrintMatrix(matr);