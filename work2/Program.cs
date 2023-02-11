 /*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void Generate2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); 
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write(" ");
        Console.WriteLine("");
    }
}

int size = InputInt("размер матриц: ");
int[,] matrix1 = new int[size, size];
int[,] matrix2 = new int[size, size];
Generate2DArray(matrix1);
Generate2DArray(matrix2);
int[,] matrixP = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixP[i, j] = matrixP[i, j] + (matrix1[i, k] * matrix2[k, j]);
        }
    }
}
Console.WriteLine("Матрица - 1");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица - 2");
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц 1*2");
PrintArray(matrixP);