using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano) {
            // O especificador de formato "D2" garante que o número seja representado com pelo menos 2 dígitos,
            // preenchendo com um zero à esquerda, se necessário (por exemplo, 5 se torna 05).
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }

        public static void Executar() {
            // Mesmo que os parâmetros não estejam na ordem original do método,
            // ao nomear os parâmetros ao passar, facilita o entendimento.
            Formatar(mes: 1, dia: 6, ano: 1996);

        }
    }
}
