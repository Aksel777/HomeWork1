int[,] FirstMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
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

int[,] Swap(int[,] matrix)
{
    int[,] tempMatrix = new int[matrix.GetLength(1),matrix.GetLength(0)];
    
    for(int i=0; i<tempMatrix.GetLength(0);i++)
    {
        for(int j=0; j<tempMatrix.GetLength(1); j++)
        {
        tempMatrix[i,j] = matrix[j,i];
        }
    }
    return tempMatrix;
}
const int Rows = 3;
const int Columns = 5;
int[,] matr = FirstMatrix(Rows,Columns);
PrintMatrix(matr);
int[,] newMat = Swap(matr);
PrintMatrix(newMat);