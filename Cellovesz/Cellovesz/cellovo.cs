using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellovesz
{
    public class cellovo
    {
        public string Nev { get; private set; }
        public int ElsoLoves { get; private set; }
        public int MasodikLoves { get; private set; }
        public int HarmadikLoves { get; private set; }
        public int NegyedikLoves { get; private set; }

        public cellovo(string sor)
        {
            var egySor = sor.Split(";");
            Nev = egySor[0];
            ElsoLoves = int.Parse(egySor[1]);
            MasodikLoves = int.Parse(egySor[2]);
            HarmadikLoves = int.Parse(egySor[3]);
            NegyedikLoves = int.Parse(egySor[4]);
        }

        public int legnagyobb()
        {
            List<int> lovesek = new List<int>() { ElsoLoves, MasodikLoves, HarmadikLoves, NegyedikLoves};
            return lovesek.Max();
        }
    }
}
