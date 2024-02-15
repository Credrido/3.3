using System;

namespace _3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool randif;

            IArrayBase[] arrays = new IArrayBase[3];

            Console.WriteLine("Хотите заполнить массивы сами? Введите Да или Нет");

            if(Console.ReadLine() == "Да")
            {
                randif = true;
            }
            else
            {
                randif = false;
            }

            arrays[0] = new Onedimensional(randif);
            arrays[1] = new Twodimensional(randif);
            arrays[2] = new Uneven(randif);

            foreach (ArrayBase array in arrays)
            {
                array.Print();
                array.Getmiddle();
            }
        }
    }
}
