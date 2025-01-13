﻿ using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.KhakimovDKh.Sprint4.Task3.V1.Lib
{
    public class DataService : ISprint4Task3V1
    {
        public int Calculate(int[,] array)
        {
            int k = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == 4)
                    {
                        k += array[i, j];
                    }
                }
            }
            return k;
        }
    }
}
