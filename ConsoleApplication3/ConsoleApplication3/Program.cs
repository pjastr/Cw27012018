using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyrektor James = new Dyrektor();
            IBudowniczyHulajnog Aron = new BudownczyHulajnogiStandardowej();
            IBudowniczyHulajnog Michal = new BudowniczyHulajnogiExtremalnej();

            James.ZbudujMiHulajnogeWKtorejJestesSpecjalista(Aron);
            James.ZbudujMiHulajnogeWKtorejJestesSpecjalista(Michal);

            Hulajnoga hulajnogaStandardowa = Aron.OddajZbudowanaHulajnoge();
            Hulajnoga hulajnogaExtreme = Michal.OddajZbudowanaHulajnoge();

            hulajnogaStandardowa.PokazHulajnoge();
            Console.WriteLine();
            hulajnogaExtreme.PokazHulajnoge();
            Console.ReadKey();
     
        }
    }
}
