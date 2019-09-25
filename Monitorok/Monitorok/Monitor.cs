using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitorok
{
    class Monitor
    {
        int x;
        int y;
        public int X
        {
            get { return x; }
            private set
            {
                if (value % 10 != 0)
                    throw new Exception("Az érték nem osztható 10-el");
                x = value;
            }
        }
        public int Y
        {
            get { return y; }
            private set
            {
                if (value % 10 != 0)
                    throw new Exception("Az érték nem osztható 10-el");
                y = value;
            }
        }
        Felbontas felbontas;
        public Felbontas Felbontas
        {
            get { return felbontas; }
            private set { felbontas = value; }
        }
        bool erinto_e = false;
        public bool Erinto_e
        {
            get
            { return erinto_e; }
            private set { erinto_e = value; }
        }
        public bool FullHD_e
        {
            get
            {
                if (x == 1080 && y == 1920)
                    return true;
                else
                    return false;
            }
        }
        public bool NegyK_e
        {
            get
            {
                if (x == 2300 && y == 4090)//4K monitor felbontása 2304x4096 ha 10-el oszthatónak kell lenni akkor nem lehet 4K sosem
                    return true;
                else
                    return false;
            }
        }
        public Monitor(int x, int y, Felbontas felbontas, bool erinto_e)
        {
            X = x;
            Y = y;
            Felbontas = felbontas;
            Erinto_e = erinto_e;
        }
        public Monitor(int x, int y, Felbontas felbontas)
        {
            X = x;
            Y = y;
            Felbontas = felbontas;
            erinto_e = false;
        }
        public override string ToString()
        {
            return string.Format("felbontás: {0}x{1}, monitor tipus:{2}, érintő kijelzős-e: {3}",x,y,felbontas,erinto_e);
        }
    }
}
