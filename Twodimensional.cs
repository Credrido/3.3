using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    public sealed class Twodimensional : ArrayBase, IPrintSnake
    {
        private int[,] array;

        public Twodimensional(bool randif) : base(randif) { }

        protected override void Fillarray()
        {
            Console.WriteLine("Введите кол-во строк:");

            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Введите кол-во столбцов:");

            int columns = int.Parse(Console.ReadLine());

            Console.WriteLine();

            array = new int[rows, columns];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Введите элемент массива:");

                    array[i, j] = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        protected override void Fillarrayrandomly()
        {
            Random random = new Random();

            array = new int[4, 4];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-250, 250);
                }
            }
            Console.WriteLine();
        }

        public override void Getmiddle()
        {
            decimal sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }

            decimal result = sum / (array.GetLength(0) * array.GetLength(1));

            Console.WriteLine("Среднее значение массива:");

            Console.WriteLine(result);

            Console.WriteLine();
        }

        public override void Print()
        {
            Console.WriteLine("Итоги двумерного массива");
            Console.WriteLine();
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        void IPrintSnake.SnakePrint()
        {
            Console.WriteLine("Массив с перевёрнутыми чётными строками:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    for (int j = array.GetLength(1); j > 0; j--)
                    {
                        Console.Write($"{array[i, j - 1]} \t");
                    }
                }
                else
                {
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        Console.Write($"{array[i, k]} \t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
