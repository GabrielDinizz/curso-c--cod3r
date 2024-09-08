using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar() {
            //chave do Dictionary não aceita repetição.
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            //Verifica se existe a respectiva chave.
            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
            }

            //Verifica se existe o conteúdo.
            Console.WriteLine(filmes.ContainsValue("Amnésia"));

            //Remove a chave.
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2016, out string filme2006);
            Console.WriteLine($"Filme {filme2006}!");

            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }

            // O loop foreach percorre cada par chave-valor no dicionário, onde você declara explicitamente o tipo KeyValuePair<int, string>.
            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

            //Forma mais simples de percorrer chave e valor
            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }
        }
    }
}