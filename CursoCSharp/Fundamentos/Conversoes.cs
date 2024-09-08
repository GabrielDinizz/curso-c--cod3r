using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {
        public static void Executar() {
            
            int inteiro = 10;  //Como o inteiro para double não há perca de informação, não é necessário explicitamente fazer a conversão.
            double quebrado = inteiro; //Isso ocorre devido o double ser naturalmente maior que um int, logo sempre um int "caberá" em um double.
            Console.WriteLine(quebrado);

            double nota = 9.7;  //Trocando o tipo explicitamente
            int notaTruncada = (int)nota; // dessa ação é Casting explícito
            
            
            Console.Write("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade Inserida {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString); //convertendo para Int de outra forma
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            // int numero1;
            int.TryParse(palavra, out int numero1);
            Console.WriteLine("Resultado 1: {0}", numero1);
            

            //forma mais otimizada
            Console.Write("Digite o segundo número: ");
            //TryParse => tenta converter, se não o valor padrão é 0.
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);




        }
    }
}
