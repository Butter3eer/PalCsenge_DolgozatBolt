using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatBolt
{
    internal class Bolt
    {
        public void Teszteles()
        {
            Termek termek = new Termek("Alma", 30, 5);
            Termek termek2 = new Termek("Körte", 60, 2);

            Console.WriteLine(termek.ToString());
            Console.WriteLine(termek2.ToString());
            Console.WriteLine(termek.fizetendoAr());
            Console.WriteLine(termek2.fizetendoAr());

            Kosar kosar = new Kosar();
            kosar.kosarMegtolt(termek);
            kosar.kosarMegtolt(termek2);

            Console.WriteLine(kosar.kosarbanAr());
            Console.WriteLine(kosar.ToString());
        }
    }
}
