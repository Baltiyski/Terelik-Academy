using System;

class FillTheMatri
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n, n];
        char letter = char.Parse(Console.ReadLine());

        int row = array.GetLength(0);
        int coll = array.GetLength(1);

        switch (letter)
        {
            case 'a':
                for (int i = 0; i < row; i++)
                { 
                    for (int j = 0; j < coll; j++)
                    {
                        if (j == 0)
                        {
                            array[i, j] = i + 1;
                        }
                        else
                        {
                            array[i, j] = array[i, j - 1] + n;
                        }           
                    }
                }
                break;
            case 'b':
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < coll; j++)
                    {
                        if (j == 0)
                        {
                            array[i, j] = i + 1;
                        }
                        else if(j % 2 != 0)
                        {
                            array[i, j] = n * (j + 1) - i;
                        }
                        else if(j % 2 == 0)
                        {
                            array[i, j] = (array[i, j - 1] + i) + array[i,0];
                        }
                    }
                }
                break;
            case 'c':
                int d = 1;
                for (int i = row; i > 0; i--)
                {
                    for (int j = 0; j < coll; j++)
                    {
                        if (j == 0)
                        {
                            if (i == row)
                            {
                                array[i - 1, j] = array[i - 1, j] + 1;
                            }
                            else
                            {
                                array[i -1 , j] = array[i, j] + d;
                                d++;
                            }
                            
                        }
                        if(i == 1 && j > 0)
                        {
                            array[0, j] = array[0, j - 1] + n - (j - 1); 
                        }
                    }
                }

                for (int i = 1; i < row; i++)
                {
                    for (int j = 1; j < coll; j++)
                    {
                        array[i, j] = array[i - 1, j - 1] + 1;
                    }
                }
                
                break;
            case 'd':
                int firstColaps = 0;
                int lastColMinus = 1;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < coll; j++)
                    {
                        if (firstColaps < row)
                        {
                            if (j == 0)
                            {
                                array[i, j] = i + 1;
                            }
                            if (i == row - 1 && j > 0)
                            {
                                array[i, j] = array[i, j - 1] + 1;
                                if (j == coll - 1)
                                {
                                    i = 0;
                                }
                            }
                        }
                        else if(firstColaps < row + n - 1)
                        {
                            if (j== coll - 1 )
                            {
                                array[i - 1, j] = array[row - 1, coll - 1] + n - i;
                                if (i == row -1)
                                {
                                    i = 0;
                                }
                            }
                        }
                    }
                    firstColaps++;
                }
                break;
            default:
                break;
        }

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < coll; j++)
            {
                if (j > 0)
                {
                    Console.Write(" ");
                }
                Console.Write(array[i,j]);
            }
            Console.WriteLine();
        }
    }
}
