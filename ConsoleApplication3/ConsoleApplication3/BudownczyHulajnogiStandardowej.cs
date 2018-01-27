using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class BudownczyHulajnogiStandardowej:IBudowniczyHulajnog
    {
        private Hulajnoga _hulajnoga = new Hulajnoga();

        public void DokrecKolka()
        {
            _hulajnoga.Kolka = "KolkaStd";
        }

        public void ZamontujHamulce()
        {
            _hulajnoga.Hamulec = "HamulceStd";
        }

        public void DoklejNaklejke()
        {
            _hulajnoga.Naklejka = "Standard";
        }

        public void ZamontujKierownice()
        {
            _hulajnoga.Kierownica = "KierownicaStd";
        }


        public Hulajnoga OddajZbudowanaHulajnoge()
        {
            return _hulajnoga;
        }
    }
}
