using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitorok
{
    class Monitor3D : Monitor
    {
        bool aktivVPassziv = true;
        public bool AktivVPassziv
        {
            get { return aktivVPassziv; }
            private set { aktivVPassziv = value; }
        }
        public int szemuvegSzam;
        public int SzemuvegSzam
        {
            get { return szemuvegSzam; }
            private set { szemuvegSzam = value; }
        }
        public Monitor3D(int x, int y, Felbontas felbontas, bool aktivVpassziv, int szemuvegszam) : base(x, y, felbontas)
        {
            aktivVPassziv = aktivVpassziv;
            szemuvegSzam = szemuvegszam;
        }

        public Monitor3D(int x, int y, Felbontas felbontas, bool erinto_e, int szemuvegszam, bool aktivVpassziv) : base(x, y, felbontas, erinto_e)
        {
            szemuvegSzam = szemuvegszam;
            aktivVPassziv = aktivVpassziv;
        }
        public override string ToString()
        {
            return string.Format("{0}, szemüvegek száma: {1}, aktív: {2},", base.ToString(), szemuvegSzam, aktivVPassziv);
        }
    }
}
