// задайте двумерый массив MxN, заполненный случайными целыми числами

int[,] GetRandomMatrix(int rows, int columns, int leftBorder, int rightBorder)
{
    int[,] matrix = new int[rows, columns];
    for(int i=0; i< matrix.GetLength(0); i++)
    {
        for(int j=0; j< matrix.GetLength(1); j++)
        {
            matrix[i,j] = Random.Shared.Next(leftBorder, rightBorder+1);
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

const int Rows = 3;
const int Columns = 4;
const int LeftBorder = -5;
const int RightBorder = 1000;

int[,] myMatrix = GetRandomMatrix(Rows, Columns, LeftBorder, RightBorder);
Console.WriteLine(string.Join(",", myMatrix));
PrintMatrix(myMatrix);