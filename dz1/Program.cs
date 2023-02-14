/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int m = 4;
int n = 4;
int minNumber = 0;
int maxNumber = 10;
int[,] array = getRandomArray(m, n, minNumber, maxNumber);


void main()
{
Console.Clear();
printArray(array);
int[,] newArray = arraySort(array);
printNewArray(newArray);
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
    Console.WriteLine("--------------------------"); 
}


int[,] arraySort(int[,] newArray)
{
     for (int i = 0; i < 4; i++)
      {
          for (int j = 0; j < 4; j++)
          {
                  for (int k = 0; k < 4; k++)
                  {
                      for (int m = 0; m < 4; m++)
                      {
                              if (array[i,j] > array[k,m])
                               {
                                  int temp = array[i,j];
                                  array[i,j] = array[k,m];
                                  array[k,m] = temp;
                              }

                      }
                  }
          }
      } 
return newArray;
}

void printNewArray(int[,] newArray)
{
  for (int i = 0; i < m; i++)
  {
     for (int j = 0; j < n; j++)
     {
       Console.Write($"{newArray[i, j]}\t");
     }
       Console.WriteLine(); 
  }
}
