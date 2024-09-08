using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos 
        public string InfoPublica = "Tenho um instagram!";


        // Herança
        protected string CorDoOlho = "Verde";

        // Mesmo projeto (asembly)
        internal ulong NumeroCelular = 5511999999999;

        // Herança OU mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // Mesma class OU herança no mesmo projeto 
        private protected string SegredoFamilia = "Bla bla";

        // Private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("Subcelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
