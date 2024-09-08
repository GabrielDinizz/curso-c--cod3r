using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //Uma única casa decimal (Fazendo um arredondamento)
            Console.WriteLine(valor.ToString("C")); //Moeda (Conforme o windows)
            Console.WriteLine(valor.ToString("P")); //Percentual (vai colocar o sinal de % e multiplicar o valor por 100)
            Console.WriteLine(valor.ToString("#.##")); //Delimita as casas decimais

            //Delimita qual padrão (de qual país) será utilizado
            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura));

            //Para completar com zeros a esquerda (D10, Irá completar o número com 0 até que tenha 10 caracteres ao todo)
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}