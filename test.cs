/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int m = 2;
int n = 2;
int k = 2;
int[,,] array = getMatrix(m, n, k, 0, 10);

int[,,] getMatrix(int m, int n, int k, int minNumber, int maxNumber)
{
    int[,,] array = new int[m, n, k];
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
          for (int d = 0; d < array.GetLength(2); d++)
          {
            array[i, j, d] = new Random().Next(minNumber, maxNumber + 1);
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
          for (int d = 0; d < array.GetLength(2); d++)
          {
            if(array[i, j, d] > maxNumb)
            {
            maxNumb = array[i, j, d];
            }
       } 
       }   
    }
    return maxNumb;
}

int maxNumb = getMaxNumb(array);
int[,,] checkAndGetMatrix(int[,,] array,int maxNumb)
{
       for (int i = 0; i < array.GetLength(0); i++)
       {
          for (int j = 0; j < array.GetLength(1); j++)
          {
             for (int d = 0; d < array.GetLength(2); d++)
            {   
               if(maxNumb == array[i, j, d]) 
               {    
                maxNumb++;
                array[i, j, d] = maxNumb;
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
        for (int d = 0; d < array.GetLength(2); d++)
        {   
            Console.Write($"{array[i, j, d]}\t ");
        }
    Console.WriteLine();
    }
}
}

int[,,] newArray = checkAndGetMatrix(array, maxNumb);
printArray3withIndexes(newArray);
