/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int m = 2;
int n = 2;

void main()
{
Console.Clear();
int[,] matrix1 = getMatrix1(m: 2, n: 2, minNumber: 0, maxNumber: 10);
int[,] matrix2 = getMatrix2(m: 2, n: 2, minNumber: 0, maxNumber: 10);
int[,] matrix3 = getMatrix3(matrix1, matrix2, m, n);
printMatrix1(matrix1);
printMatrix2(matrix2);
printMatrix3(matrix3);
}

main();

int[,] getMatrix1(int m, int n, int minNumber, int maxNumber)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        result[i, j] = new Random().Next(minNumber, maxNumber + 1);
      }
  }
return result;
}

int[,] getMatrix2(int m, int n, int minNumber, int maxNumber)
{
  int[,] result = new int[m, n];
  for (int i = 0; i < m; i++)
  {
     for (int j = 0; j < n; j++)
     {
       result[i, j] = new Random().Next(minNumber, maxNumber + 1);
     }
  }
return result;
}

int[,] getMatrix3(int[,] matrix1, int[,] matrix2, int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            matrix[i, j] = 0;
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                matrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
return matrix;
}

void printMatrix3(int[,] matrix3)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        Console.Write($"{matrix3[i, j]}\t");
        }
        Console.WriteLine();
        }
}

void printMatrix2(int[,] matrix2)
{
   for (int i = 0; i < m; i++)
   {
      for (int j = 0; j < n; j++)
      {
      Console.Write($"{matrix2[i, j]}\t");
      }
      Console.WriteLine();
   }
   Console.WriteLine("----------");
}

void printMatrix1(int[,] matrix1)
{
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
            Console.Write($"{matrix1[i, j]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("----------");
}
