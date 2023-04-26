using System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello World");
            string nome = "Angelo";
            string cognome;
            cognome = "DAlo";

            //possiamo riassegnare le varibaili, non per le costanti
            nome = "Angelo2";

            int eta = 23;

            Console.WriteLine(nome + " " + eta);
            Console.Read();

            //COSTANTI
            const string genere = "uomo";
        }
    }
}
