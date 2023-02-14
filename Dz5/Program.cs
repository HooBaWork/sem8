/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int m = 4;
int n = 4;
int s = 1;

void main()
{
Console.Clear();
int[,] array = new int[m, n];
getSpiralMatrix(array);
}

main();

void getSpiralMatrix(int[,] array)
{
    for (int y = 0; y < n; y++) 
    {
        array[0, y] = s;
        s++;
    }
    for (int x = 1; x < m; x++) 
    {
        array[x, n - 1] = s;
        s++;
    }
    for (int y = n - 2; y >= 0; y--) 
    {
        array[m - 1, y] = s;
        s++;
    }
    for (int x = m - 2; x > 0; x--) 
    {
        array[x, 0] = s;
        s++;
    }
    int c = 1;
    int d = 1;
    while (s < m * n) 
    {
        while (array[c, d + 1] == 0) 
        {
            array[c, d] = s;
            s++;
            d++;
        }
        while (array[c + 1, d] == 0) {
            array[c, d] = s;
            s++;
            c++;
        }
        while (array[c, d - 1] == 0) {
            array[c, d] = s;
            s++;
            d--;
        }
        while (array[c - 1, d] == 0) {
            array[c, d] = s;
            s++;
            c--;
        }
    }
    for (int x = 0; x < m; x++) 
    {
        for (int y = 0; y < n; y++) 
        {
            if (array[x, y] == 0) 
            {
                array[x, y] = s;
            }
        }
    }
    for (int x = 0; x < m; x++) {
        for (int y = 0; y < n; y++) 
        {
            if (array[x, y] < 10) 
            {
                Console.Write($"{ array[x, y]}\t ");
            } 
            else 
            {
                Console.Write($"{ array[x, y]}\t ");
            }
        }
        Console.WriteLine(" ");
    }
}
