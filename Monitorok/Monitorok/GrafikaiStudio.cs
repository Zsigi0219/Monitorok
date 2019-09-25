using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitorok
{
    class GrafikaiStudio
    {
        List<Monitor> MonitorokL = new List<Monitor>();
        public string HanyDBTipusuMonitor()
        {
            int lcdDB = 0;
            int ledDB = 0;
            int plasmaDB = 0;
            foreach (Monitor monitor in MonitorokL)
            {
                if (monitor.Felbontas == Felbontas.LCD)
                    lcdDB++;
                else if (monitor.Felbontas == Felbontas.LED)
                    ledDB++;
                else if (monitor.Felbontas == Felbontas.Plasma)
                    plasmaDB++;

            }
            return string.Format("LED monitorok száma: {0}, LCD monitorok száma: {1}, PLASMA monitorok száma: {2}", lcdDB, ledDB, plasmaDB);
        }
        public int NegyKMonitor()
        {
            int negyKDB = 0;
            foreach (Monitor monitor in MonitorokL)
            {
                if (monitor.NegyK_e)
                    negyKDB++;
            }
            return negyKDB;
        }
        public int FullHDMonitor()
        {
            int hdDB = 0;
            foreach (Monitor monitor in MonitorokL)
            {
                if (monitor.FullHD_e)
                    hdDB++;
            }
            return hdDB;
        }
        public int HaromDMonitor()
        {
            int HaromD = 0;
            foreach (Monitor monitor in MonitorokL)
            {
                if (monitor is Monitor3D)
                {
                    HaromD++;
                }
            }
            return HaromD;
        }
        public int AktivSzemuveg()
        {
            int SzemuvegDB = 0;
            foreach (Monitor monitor in MonitorokL)
            {
                if (monitor is Monitor3D)
                {
                    Monitor3D monitor3D = monitor as Monitor3D;
                    if (monitor3D.AktivVPassziv)
                        SzemuvegDB += monitor3D.SzemuvegSzam;
                }
            }
            return SzemuvegDB;
        }
        public void MonitorHozzaAd(Monitor monitor)
        {
            if (MonitorokL.Count == 0)
                MonitorokL.Add(monitor);
            else
            {
                if (MonitorokL.Last().Y <= monitor.Y)
                    MonitorokL.Add(monitor);
            }
        }
        public List<Monitor> MonitorokListaz()
        {
            return MonitorokL;
        }
        public void Menu()
        {
            bool folytat = true;

            while (folytat)
            {
                Console.WriteLine();
                Console.WriteLine("4K monitorok száma (k)");
                Console.WriteLine("3D monitrok száma (d)");
                Console.WriteLine("Hány darab aktív monitorú szemüveg van (s)");
                Console.WriteLine("Full HD monitorok száma (f)");
                Console.WriteLine("Kilépés (Esc)");
                Console.WriteLine();
                ConsoleKey menu = Console.ReadKey().Key;
                Console.WriteLine();

                switch (menu)
                {
                    case ConsoleKey.K:

                        Console.WriteLine("4K monitorok száma: {0}", NegyKMonitor());
                        break;

                    case ConsoleKey.D:

                        Console.WriteLine("3D monitorok száma: {0}", HaromDMonitor());
                        break;

                    case ConsoleKey.S:
                        Console.WriteLine("Hány darab aktív monitorú szemüveg van: {0}", AktivSzemuveg());

                        break;
                    case ConsoleKey.F:
                        Console.WriteLine("Full HD monitorok száma: {0}", FullHDMonitor());
                        break;

                    case ConsoleKey.Escape:
                    default:
                        folytat = false;
                        break;
                }
            }

        }
    }
}
