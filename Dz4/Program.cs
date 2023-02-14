/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int m = 2;
int n = 2;
int d = 2;

void main()
{
int[,,] array = getMatrix(m, n, d, 0, 10);
int maxNumb = getMaxNumb(array);
int[,,] newArray = checkAndGetMatrix(array, maxNumb);
printArray3withIndexes(newArray);
}

main();



int[,,] getMatrix(int m, int n, int d, int minNumber, int maxNumber)
{
    int[,,] array = new int[m, n, d];
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
          for (int k = 0; k < array.GetLength(2); k++)
          {
            array[i, j, k] = new Random().Next(minNumber, maxNumber + 1);
          }
       } 
}   
return array;
}

int getMaxNumb(int[,,] array)
{
    int maxNumb = array[0, 0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
          for (int k = 0; k < array.GetLength(2); k++)
          {
            if(array[i, j, k] > maxNumb)
            {
            maxNumb = array[i, j, k];
            }
       } 
       }   
    }
    return maxNumb;
}


int[,,] checkAndGetMatrix(int[,,] array,int maxNumb)
{
       for (int i = 0; i < array.GetLength(0); i++)
       {
          for (int j = 0; j < array.GetLength(1); j++)
          {
             for (int k = 0; k < array.GetLength(2); k++)
            {   
               if(maxNumb > array[i, j, k]) 
               {    
                maxNumb++;
                array[i, j, k] = maxNumb;
               }
            } 
          }
       }  
    
return array;
}

void printArray3withIndexes(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
     for (int j = 0; j < array.GetLength(1); j++)
     {
        for (int k = 0; k < array.GetLength(2); k++)
        {   
            Console.Write($" {array[i, j, k]} ( {i} ,{j} ,{k} )\t ");
        }
     Console.WriteLine();
     }
  }
}
