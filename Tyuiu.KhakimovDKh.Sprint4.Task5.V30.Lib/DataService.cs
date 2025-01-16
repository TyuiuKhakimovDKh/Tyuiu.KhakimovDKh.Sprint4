﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhakimovDKh.Sprint4.Task5.V30.Lib
{
    public class DataService : ISprint4Task5V30
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int answer = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        answer += matrix[i, j];
                    }
                }
            }
            return answer;
        }
    }
}
