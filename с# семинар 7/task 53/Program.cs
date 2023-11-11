// Cрднеарифметическое эллементом массива, кторые расположены по углам

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

double Mean(int[,] matrix)
{
return (matrix[0,0]+
+matrix[0,matrix.GetLength(1)-1]+
+matrix[matrix.GetLength(0)-1,matrix.GetLength(1)-1]+
+matrix[matrix.GetLength(0)-1,0])/4.0;
}

const int Rows = 5;
const int Columns = 5;

int[,] myMatrix = NewMatrix(Rows, Columns);
PrintMatrix(myMatrix);
Console.WriteLine(Mean(myMatrix));