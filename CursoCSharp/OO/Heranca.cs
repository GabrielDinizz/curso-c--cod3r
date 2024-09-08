using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima; //Readonly para não permitir alterações (somente leitura)
        int VelocidadeAtual;

        //Construtor padrão
        //public Carro() { }

        //Construtor que recebe a velocidade máxima;
        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        //Método acessado apenas por herança
        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        // Método virtual para permitir sobrescrita nas classes derivadas
        public virtual int Acelerar() {
            return AlterarVelocidade(5);
        }

        public virtual int Frear() {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        //Construtor que está definido na classe pai.
        public Uno() : base(200) {

        }
    }

    public class Ferrari : Carro
    {
        //Construtor que está definido na classe pai.
        public Ferrari() : base(350) {

        }

        //override (diz que estou sobrescrevendo um código da classe pai)
        public override int Acelerar() {
            return AlterarVelocidade(15);
        }

        //Oculta o método da classe Pai (Como não sobrescreve o método
        //ele cria um novo método que está dentro de "Ferrari" e não de "Carro".)
        public new int Frear() {
            return AlterarVelocidade(-15);
        }
    }

    internal class Heranca
    {
        public static void Executar() {
            Console.WriteLine("Uno...");
            Ferrari carro1 = new Ferrari();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari(); //Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro...");
            carro3 = new Uno(); //Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

        }
    }
}
