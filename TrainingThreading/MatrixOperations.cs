﻿using System;
using System.Threading;

namespace TrainingThreading
{
    public class MatrixOperations
    {
        public int[,] Matrix { get; set; }

        public MatrixOperations()
        {
        }

        public int[,] GetRandomMatrix(int rowsSize,int colsSize)
        {
            Matrix = new int[rowsSize, colsSize];
            Random ran = new Random();
            for (int i = 0; i < rowsSize; i++)
            {
                for (int j = 0; j < colsSize; j++)
                {
                    Matrix[i, j] = ran.Next(1, 15);                   
                }
            }
            return Matrix;
        }
        public static int MatrixSumParallel(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetUpperBound(0);
            int cols = matrix.GetUpperBound(1);
            const int THREADSCOUNT = 4;
            int countOfActions = rows / THREADSCOUNT;
            int[] localSums = new int[THREADSCOUNT];
            Thread[] threads = new Thread[THREADSCOUNT];
            for (int i = 0; i < THREADSCOUNT; i++)
            {
                int start = countOfActions * i;
                int end = countOfActions * (i + 1);
                int threadnumber = i;

                threads[i] = new Thread(() =>
               {
                   for (int row = start; row < end; ++row)
                   {
                       for (int col = 0; col < cols; ++col)
                       {
                           localSums[threadnumber] += matrix[row, col];
                       }
                   }
               });
                threads[i].Start();
            }
            foreach (Thread thread in threads)
                thread.Join();
            foreach (int sumInArray in localSums)
                sum += sumInArray;
            return sum;
        }
    }
}
