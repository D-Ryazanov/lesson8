using System;

class Program
{
    public static void Main(string[] args)
    {

        void Task54()
        {
            // Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

            int m = 5;
            int n = 5;
            int temp;
            Console.WriteLine("Для простоты эксперемента будет создан массив с высотой и шириной в 5 значений.");
            int[,] array = new int[m, n];
            FillArray(array);
            Console.WriteLine("После заполнения получился данный массив.");
            WriteArray(array);
            for (int i = 0; i < m; i++)
            {
                for (int l = n - 1; l > 0; l--)
                {
                    for (int k = 0; k < l; k++)
                        if (array[i, k] > array[i, l])
                        {
                            temp = array[i, k];
                            array[i, k] = array[i, l];
                            array[i, l] = temp;
                        }
                }
            }
            Console.WriteLine("А после выполнения программы, получился данный массив:");
            WriteArray(array);
        }


        void Task56()
        {
            // Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

            int m = 5;
            int n = 5;
            int temp = 0;
            int[] summ = new int[5];
            Console.WriteLine("Для простоты эксперемента будет создан массив с высотой и шириной в 5 значений.");
            int[,] array = new int[m, n];
            FillArray(array);
            Console.WriteLine("После заполнения получился данный массив.");
            WriteArray(array);
            Console.WriteLine("Суммы каждой из строк:");
            for (int i = 0; i < m; i++)
            {
                for (int l = 0; l < n; l++)
                {
                    summ[i] += array[i, l];
                }
                if (summ[i] < summ[temp])
                {
                    temp = i;
                }
                Console.WriteLine("Сумма чисел в " + (i+1) + " строке равна " + summ[i]);
            }            
            Console.WriteLine ("И строкой с наименьшей суммой является " + (temp+1) + " строка.");
        }


        void Task58()
        {
            // Заполните спирально массив 4 на 4 числами от 1 до 16.

            int m = 4;
            int n = 4;
            int count = 1;
            int[,] array = new int[m, n];
            FillArraySpiral(array, count, m, n);
            Console.WriteLine("Результат:");
            WriteArray(array);
        }


        Console.WriteLine("Укажите какое задание хотите проверить (54, 56, 58)");
        int task = Convert.ToInt32(Console.ReadLine());
        if (task == 54)
        {
            Task54();
        }
        else if (task == 56)
        {
            Task56();
        }
        else if (task == 58)
        {
            Task58();
        }
        else
        {
            Console.WriteLine("Такого задания нет.");
        }

        void FillArraySpiral(int[,] array, int count, int m, int n, int i = 0, int l = 0)
        {        
            while (m!= 1 && n!= 1)
            {
                if (l !=n && i !=m)
                {
                    for (int k = 0; k < n; k++)
                    {
                        array[i,l] = count;
                        count++;
                        l++;                   
                    }
                    count--;
                    n--;
                    l--;
                }
                else if (l == n && i != m)
                {
                    for (int k = 0;  k < m; k++)
                    {
                        array[i,l] = count;
                        count++;
                        i++;        
                    }
                    i--;
                    m--;
                    count--;
                }
                else if (l == n && i == m)
                {
                    n++;
                    for (int k = 0; k < n; k++)
                    {
                        array[i,l] = count;
                        count++;
                        l--;                        
                    }
                    n--;
                    l++;
                    count--;
                }
                else if (l != n && i == m)
                {
                    for (int k = 0; k < m; k++)
                    {
                        array[i,l] = count;
                        count++;
                        i--;                        
                    }
                    m--;
                    i++;
                    count--;
                }
            }
            count++;
            l--;
            array[i,l] = count;
        }
    }


    static void FillArray(double[,] array, int min, int max)
    {
        Random random = new Random();
        for (int m = 0; m < array.GetLength(0); m++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                array[m, n] = random.Next(min, max);
            }
        }
    }

    static void FillArray(int[,] array, int min = -10, int max = 11)
    {
        Random random = new Random();
        for (int m = 0; m < array.GetLength(0); m++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                array[m, n] = random.Next(min, max);
            }
        }
    }
    static void WriteArray(double[,] array)
    {
        for (int m = 0; m < array.GetLength(0); m++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                Console.Write(array[m, n] + " ");
            }
            Console.WriteLine();
        }
    }
    static void WriteArray(int[,] array)
    {
        for (int m = 0; m < array.GetLength(0); m++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                Console.Write(array[m, n] + " ");
            }
            Console.WriteLine();
        }
    }

    static void WriteArray(int[] array)
    {

        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write(array[n] + " ");
        }
        Console.WriteLine();
    }




}