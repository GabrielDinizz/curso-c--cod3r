using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Membros {
        public static void Executar() { 
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            sicrano.ApresentarNoConsole();

            //O próprio compilador está fazendo a infêrencia do tipo (Pessoa)
            var fulano = new Pessoa();
            fulano.Nome = "Diniz";
            fulano.Idade = 23;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);
            Console.WriteLine(apresentacaoDoFulano.Length);

        }
    }
}
