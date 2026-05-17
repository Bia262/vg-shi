namespace Cellovesz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] adatok = File.ReadAllLines("lovesek.csv");
            List<cellovo> cellovesek = new List<cellovo>();
            
            foreach(var sor in adatok)
            {
                cellovesek.Add(new cellovo(sor));
            }

            //9. feladat
            foreach (var lovo in cellovesek)
            {
                Console.WriteLine($"{lovo.Nev}, {lovo.legnagyobb()}");
            }

            //10. feladat
            cellovo legjobb = cellovesek[0];
            foreach (var lovo in cellovesek)
            {
                if (lovo.legnagyobb() > legjobb.legnagyobb())
                {
                    legjobb = lovo;
                }
            }
            Console.WriteLine($"Legnahyobb találatot lövő eredményei: \n{legjobb.Nev} {legjobb.ElsoLoves} {legjobb.MasodikLoves} {legjobb.HarmadikLoves} {legjobb.NegyedikLoves}");

            //11. feladat
            cellovo leggyengebb = cellovesek[0];
            foreach (var lovo in cellovesek)
            {
                double atlag = (lovo.ElsoLoves + lovo.MasodikLoves + lovo.HarmadikLoves + lovo.NegyedikLoves) / 4.0;
                double leggyengebbAtlag = (leggyengebb.ElsoLoves + leggyengebb.MasodikLoves + leggyengebb.HarmadikLoves + leggyengebb.NegyedikLoves) / 4.0;

                if (atlag < leggyengebbAtlag)
                {
                    leggyengebb = lovo;
                }
            }
            double leggyengebbAtlag2 = (leggyengebb.ElsoLoves + leggyengebb.MasodikLoves + leggyengebb.HarmadikLoves + leggyengebb.NegyedikLoves) / 4;
            Console.WriteLine($"A leggyengébb átlagú találatok lövő eredményei: \n{leggyengebb.Nev}{leggyengebbAtlag2}");
        }
    }
}
