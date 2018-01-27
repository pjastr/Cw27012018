using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Czat czat = Czat.Create();
            Console.WriteLine("User1:");
            string wej = Console.ReadLine();
            czat.Dodaj("User1: "+wej);
            Console.WriteLine("User2:");
            wej = Console.ReadLine();
            czat.Dodaj("User2: " + wej);

            Console.WriteLine(czat);
            Console.ReadLine();
        }
    }

    sealed class Czat
    {
        List<string> wypowiedzi;
        private static Czat instancja;

        private Czat()
        {
            wypowiedzi = new List<string>();
        }

        public static Czat Create()
        {
            if (instancja == null) instancja = new Czat();
            return instancja;
        }

        public void Dodaj(string param)
        {
            wypowiedzi.Add(param);
        }
        public override string ToString()
        {
            string opis = "Wypowiedzi:" + Environment.NewLine;
            foreach(var element in wypowiedzi)
            {
                opis += element + Environment.NewLine;
            }
            return opis;
        }
    }
}
