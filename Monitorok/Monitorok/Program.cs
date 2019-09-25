using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitorok
{
    class Program
    {
        static void Main(string[] args)
        {
            GrafikaiStudio grafikaiStudio = new GrafikaiStudio();
            using (StreamReader sr = new StreamReader("Monitorok.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string sor;
                    string[] sorLista;
                    sor = sr.ReadLine();

                    sorLista = sor.Split(';');
                    switch (sorLista.Length)
                    {
                        case 3:
                            Monitor monitor = new Monitor(Int32.Parse(sorLista[0]), Int32.Parse(sorLista[1]), (Felbontas)Enum.Parse(typeof(Felbontas), sorLista[2]));
                            grafikaiStudio.MonitorHozzaAd(monitor);
                            break;
                        case 4:
                            monitor = new Monitor(Int32.Parse(sorLista[0]), Int32.Parse(sorLista[1]), (Felbontas)Enum.Parse(typeof(Felbontas), sorLista[2]), bool.Parse(sorLista[3]));
                            grafikaiStudio.MonitorHozzaAd(monitor);
                            break;
                        case 5:
                            Monitor3D monitor3D = new Monitor3D(Int32.Parse(sorLista[0]), Int32.Parse(sorLista[1]), (Felbontas)Enum.Parse(typeof(Felbontas), sorLista[2]), bool.Parse(sorLista[3]), Int32.Parse(sorLista[4]));
                            grafikaiStudio.MonitorHozzaAd(monitor3D);
                            break;
                        default:
                            monitor3D = new Monitor3D(Int32.Parse(sorLista[0]), Int32.Parse(sorLista[1]), (Felbontas)Enum.Parse(typeof(Felbontas), sorLista[2]), bool.Parse(sorLista[3]), Int32.Parse(sorLista[4]), bool.Parse(sorLista[5]));
                            grafikaiStudio.MonitorHozzaAd(monitor3D);
                            break;
                    }
                }
            }
            foreach (Monitor monitor in grafikaiStudio.MonitorokListaz())
            {
                Console.WriteLine(monitor);
            }
            grafikaiStudio.Menu();
        }

    }
}
