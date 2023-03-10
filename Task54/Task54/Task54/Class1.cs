using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task54
{
    public class ArrayWorker
    {

        /// <summary>
        /// Получение нового двумерного массива, заполненного случайными числами [1;10]
        /// </summary>
        /// <param name="length">Длина первого измеренеия</param>
        /// <param name="secondLength">Длина второго измерения</param>
        /// <returns>Новый двумерный массив</returns>

        public int[,] GetArray(int length, int secondLength)
        {
            int[,] array = new int[length, secondLength];
            var rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(10);
                }
            }
            return array;
        }
        

        /// <summary>
        /// Изменение массива (меняем местами первую и последнюю строки)
        /// </summary>
        /// <param name="array">Массив, в котором мы меняем строки</param>
        public void Update(int[,] array)
        {
            int[] first = GetRow(0, array);
            int[] last = GetRow(array.GetLength(0) - 1, array);

            UpdateRow(0, last, array);
            UpdateRow(array.GetLength(0) - 1, first, array);
        }

        /// <summary>
        /// Получение строки из двумерного массива как одномерный массив
        /// </summary>
        /// <param name="rowNumber">Номер строки, которую я хочу получить</param>
        /// <param name="array">Массив из которого я хочу получить строку</param>
        /// <returns>Строку под номером rowNumber</returns>
        int[] GetRow(int rowNumber, int[,] array)
        {
            int[] row = new int[array.GetLength(0)];

            for (int i = 0; i < array.GetLength(1); i++)
            {
                row[i] = array[rowNumber, i];
            }
            return row;
        }
        /// <summary>
        /// Изменение значений строки на новые
        /// </summary>
        /// <param name="rowNumber">Номер строки, которую мы обновляем</param>
        /// <param name="newValue">Значения, которые будут храниться в новом массиве</param>
        /// <param name="array">Массив, в котором мы проводим обновления</param>
        void UpdateRow(int rowNumber, int[] newValue, int[,] array)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                array[rowNumber, i] = newValue[i];
            }
        }

        /// <summary>
        /// Вывод массива на экран
        /// </summary>
        /// <param name="array">Массив, который мы хотим вывести</param>
        public void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Сортировка значений массива в каждой строке
        /// </summary>
        /// <param name="array">Массив, который мы хотим отсортировать</param>
        public void SortirovkaArrayLines(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(1) - 1; k++)
                    {
                        if (array[i, k] < array[i, k + 1])
                        {
                            int temp = array[i, k + 1];
                            array[i, k + 1] = array[i, k];
                            array[i, k] = temp;
                        }
                    }
                }
            }
        }


    }

}
