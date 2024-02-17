using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    public abstract class ArrayBase :IArrayBase, IPrinter
    {
        public ArrayBase(bool randif)
        {
            Createarray(randif);
        }

        public void Createarray(bool randif)
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
        public abstract void Getmiddle();

        protected abstract void Fillarray();

        protected abstract void Fillarrayrandomly();
        
         public abstract void Print();
    }
}
