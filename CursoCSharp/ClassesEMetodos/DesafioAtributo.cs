using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class DesafioAtributo
    {
        int a = 10;

        public static void Executar() {
            var desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}
