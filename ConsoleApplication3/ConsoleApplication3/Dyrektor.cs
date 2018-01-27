using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    
    class Dyrektor
    {
	    public void ZbudujMiHulajnogeWKtorejJestesSpecjalista(IBudowniczyHulajnog budowniczy)
	    {
		    budowniczy.DokrecKolka();
		    budowniczy.ZamontujHamulce();
		    budowniczy.DoklejNaklejke();
		    budowniczy.ZamontujKierownice();
	    }
    }
}
