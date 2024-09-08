using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar() {
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano");

            //Peek não remove da fila, só pega o valor da primeira pessoa da fila (Fulano)
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            //Dequeue REMOVE a próxima pessoa da fila (Fulano)
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            //Exibe a fila (Primeiro elemento Fulano)
            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            //Enqueue enfileira elementos na lista 
            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            //Busca o item na lista (Maiúsculo e Minúsculo importa!)
            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}