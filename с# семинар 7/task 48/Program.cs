﻿int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for(int i=0; i< matrix.GetLength(0); i++)
    {
        for(int j=0; j< matrix.GetLength(1); j++)
        {
            matrix[i,j] = i+j;
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
const int Columns = 5;

int[,] myMatrix = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);