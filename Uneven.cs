using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public sealed class Uneven : ArrayBase
    {
        private int[][] array;

        public Uneven(bool isNotRandom)
        {
            if (isNotRandom)
            {
                Fillarray();
            }
            else
            {
                Fillarrayrandomly();
            }
        }

        void ArrayBase.Createarray(bool randif)
        {
            if (randif)
            {
                Fillarray();
            }
            else
            {
                Fillarrayrandomly();
            }
        }

        void ArrayBase.Fillarray()
        {
            Console.WriteLine("Введите кол-во массивов:");

            int Len = int.Parse(Console.ReadLine());

            array = new int[Len][];

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите длину массива {i}:");

                int Length = int.Parse(Console.ReadLine());

                Console.WriteLine();

                array[i] = new int[Length];

                for (int l = 0; l < array[i].Length; l++)
                {
                    Console.WriteLine($"Введите элемент массива {i}:");

                    int j = int.Parse(Console.ReadLine());

                    array[i][l] = j;

                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        void ArrayBase.Fillarrayrandomly()
        {
            Random random = new Random();

            array = new int[4][];

            Console.WriteLine("Для неровного массива");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите длину массива {i}:");

                int Length = int.Parse(Console.ReadLine());

                array[i] = new int[Length];

                for (int l = 0; l < array[i].Length; l++)
                {
                    int j = random.Next(-250, 250);

                    array[i][l] = j;
                }
                Console.WriteLine();
            }
        }

        void ArrayBase.Getmiddle()
        {
            decimal sum = 0;

            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int Len = array[i].Length;

                int summ = array[i].Sum();

                Console.WriteLine($"Среднее значение массива {i}:");

                Console.WriteLine(summ / Len);

                Console.WriteLine();

                counter += array[i].Length;
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
            }

            decimal result = sum / counter;

            Console.WriteLine("Среднее значение всего массива:");

            Console.WriteLine(result);

            Console.WriteLine();
        }

        void ArrayBase.Print()
        {
            Console.WriteLine("Итоги неровного массива");
            Console.WriteLine();
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                for (int l = 0; l < array[i].Length; l++)
                {
                    Console.Write($"{array[i][l]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
