using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public sealed class Onedimensional : ArrayBase, DeleteBigger100
    {
        private int[] array;
        public Onedimensional(bool randif)
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
            Console.WriteLine();

            Console.WriteLine("Введите длину массива:");

            int length = int.Parse(Console.ReadLine());

            array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент массива:");

                array[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        void ArrayBase.Fillarrayrandomly()
        {
            Random random = new Random();

            array = new int[4];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-200, 200);
            }
            Console.WriteLine();
        }

        void ArrayBase.Getmiddle()
        {
            decimal sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            decimal result = sum / array.Length;

            Console.WriteLine();

            Console.WriteLine("Среднее значение массива:");

            Console.WriteLine(result);

            Console.WriteLine();
        }

        void ArrayBase.Print()
        {
            Console.WriteLine("Итоги одномерного массива");
            Console.WriteLine();
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Массив без чисел больше 100 по модулю:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 100 && array[i] > -100)
                {
                    Console.Write($"{array[i]} ");
                }
            }

            Console.WriteLine();
        }

        void DeleteBigger100.DeleteBigger100()
        {
            Console.WriteLine("Массив без чисел больше 100 по модулю:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 100 && array[i] > -100)
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }
    }
}
