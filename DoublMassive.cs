void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }

        Console.WriteLine();
    }
}

void FillArray(int[,] matrx)
{
    for (int i = 0; i < matrx.GetLength(0); i++)
    {
        for (int j = 0; j < matrx.GetLength(1); j++)
        {
            matrx[i,j] = new Random().Next(10, 100);
        }
    }
}
int[,] matrix = new int[4, 5];
FillArray(matrix);
PrintArray(matrix);