using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton obiekt = Singleton.Create();
            Singleton obiekt2 = Singleton.Create();
        }
    }

    class Singleton
    {
        private static Singleton instancja;
        
        private Singleton()
        {

        }

        public static Singleton Create()
        {
            if (instancja == null) return new Singleton();
            return instancja;
        }
    }
}
