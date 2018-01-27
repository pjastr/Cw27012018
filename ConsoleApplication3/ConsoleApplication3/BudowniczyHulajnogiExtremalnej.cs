using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class BudowniczyHulajnogiExtremalnej:IBudowniczyHulajnog
    {

        private Hulajnoga _hulajnoga = new Hulajnoga();

        public void DokrecKolka()
        {
            _hulajnoga.Kolka = "KolkaExtreme";
        }

        public void ZamontujHamulce()
        {
            _hulajnoga.Hamulec = "HamulceExtreme";
        }

        public void DoklejNaklejke()
        {
            _hulajnoga.Naklejka = "Extreme";
        }

        public void ZamontujKierownice()
        {
            _hulajnoga.Kierownica = "KierownicaExtreme";
        }


        public Hulajnoga OddajZbudowanaHulajnoge()
        {
            return _hulajnoga;
        }
    }
}
