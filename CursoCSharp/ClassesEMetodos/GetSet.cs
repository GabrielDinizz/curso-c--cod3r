using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto {
        private string Marca;
        private string Modelo;
        //tipo inteiro sem sinal (+-)
        private uint Cilindrada;

        //Construtor
        public Moto(string marca, string modelo, uint cilindrada) {
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        //Construtor Padrão
        public Moto() { 

        }

        //?
        public string GetMarca() {
            return Marca;
        }

        public void SetMarca(string marca) { 
            Marca = marca;
        }

        public string GetModelo() { 
            return Modelo;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public uint GetCilindrada() { 
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada) { 
            
            //1 Opção
            //if (cilindrada > 0) {
            //    Cilindrada = cilindrada;
            //}

            //2 Opção
            //Math.Abs transforma um valor que caso seja negativo em positivo
            //Cilindrada = Math.Abs(cilindrada);

            //3 Opção
            Cilindrada = cilindrada;

        }
    }

    internal class GetSet
    {
        public static void Executar() {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
           moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());

        }
    }
}
