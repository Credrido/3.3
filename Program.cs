using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool randif;

            IArrayBase[] arrays = new IArrayBase[3];

            Console.WriteLine("Хотите заполнить массивы сами? Введите Да или Нет");

            if (Console.ReadLine() == "Да")
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


            Console.WriteLine();
            Console.WriteLine("Доп для одномерных:");
            Onedimensional array1 = new Onedimensional(randif);
            IDeleteBigger100 Delete = array1;
            Delete.DeleteBigger100();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Доп для двумерных:");
            Twodimensional array2 = new Twodimensional(randif);
            IPrintSnake Snake = array2;
            Snake.SnakePrint();

            IPrinter[] arraysP = new IPrinter[4];

            arraysP[0] = new DaysOfWeek();
            arraysP[1] = new Onedimensional(randif);
            arraysP[2] = new Twodimensional(randif);
            arraysP[3] = new Uneven(randif);

            foreach(IPrinter arr in arraysP)
            {
                arr.Print();
            }

        }
    }
}
