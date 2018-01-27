using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Hulajnoga
    {
        public string Hamulec { get; set; }
        public string Kierownica { get; set; }
        public string Kolka { get; set; }
        public string Naklejka { get; set; }

        public void PokazHulajnoge()
        {
            var informacjeOHulajnodze = String.Format("Hulajnoga w wersji: {0}.nKierownica: {1}.nKola: {2}.nHamulec {3}.", Naklejka, Kierownica, Kolka, Hamulec);
            Console.WriteLine(informacjeOHulajnodze);
        }
    }
}
