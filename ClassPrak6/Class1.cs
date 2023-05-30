using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPrak6
{
    public class Class1
    {
        private int[,] matrix;

        public Class1(int[,] matrix)
        {
            this.matrix = matrix;
        }

        public int Zadanie1()
        {
            int maxElement = int.MinValue;

            // Заштрихованная область матрицы 8x8
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i >= j && i + j >= 7)
                    {
                        int element = matrix[i, j];
                        if (element > maxElement)
                        {
                            maxElement = element;
                        }
                    }
                }
            }
            return maxElement;
        }

        public int[] Zadanie2()
        {
            List<int> neravnol = new List<int>();

            // Заштрихованная область матрицы 8x8
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i >= j && i + j >= 7 && matrix[i, j] != 0)
                    {
                        neravnol.Add(matrix[i, j]);
                    }
                }
            }
            return neravnol.ToArray();
        }

        public int[] Zadanie3()
        {
            int[] countOfTwosArray = new int[8];

            // Заштрихованная область матрицы 8x8
            for (int j = 0; j < 8; j++)
            {
                int ravn2 = 0;
                for (int i = 0; i < 8; i++)
                {
                    if (i >= j && i + j >= 7 && matrix[i, j] == 2)
                    {
                        ravn2++;
                    }
                }
                countOfTwosArray[j] = ravn2;
            } 
            return countOfTwosArray;
        }

        public int Zadanie4()
        {
            int sum = 0;

            // Правая нижняя четверть матрицы 8x8
            for (int i = 4; i < 8; i++)
            {
                for (int j = 4; j < 8; j++)
                {
                    if (matrix[i, j] > 2)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }

}
