/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int m = 5;
int n = 4;

void main()
{
Console.Clear();
int[,] array = getRandomArray(m: 5, n: 4, minNumber: 0, maxNumber: 10);
printArray(array);
getSumAndPrint(array);
}

main();


int[,] getRandomArray(int m, int n, int minNumber, int maxNumber)
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

void getSumAndPrint(int[,] array)
{
  int sum = 0;
  int res = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {  
     int temp = 0;
     for (int j = 0; j < array.GetLength(1); j++)
     {
       temp += array[i, j];
     }
     if (temp > sum)
     {
       sum = temp;
       res = i;
     }
  }
Console.WriteLine($"Строка: {res} ");
Console.WriteLine();
}

void printArray(int[,] array)
{
  for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write($"{array[i, j]}\t");
      }
        Console.WriteLine(); 
  }
}
