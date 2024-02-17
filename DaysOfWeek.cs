using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    public class DaysOfWeek : IPrinter
    {
        void IPrinter.Print()
        {
            Console.WriteLine("Понедельник, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье");
            Console.WriteLine();
        }
    }
}
