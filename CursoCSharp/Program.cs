using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"VariaveisEConstantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternário - Fundamentos", OperadorTernario.Executar},

                //Estrutura de Controle
                {"Estrutura Foreach - Estruturas de Contole", EstruturaForEach.Executar},
                {"Usando Continue - Estruturas de Contole", UsandoContinue.Executar},

                //Classes e Métodos
                { "Membros - Classes e Metodos", Membros.Executar},
                { "Construtores - Classes e Metodos", Construtores.Executar},
                { "Métodos Com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                { "DesafioAtributo - Classes e Metodos", DesafioAtributo.Executar},
                { "Params - Classes e Metodos", Params.Executar},
                { "Parâmetros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                { "Get Set - Classes e Metodos", GetSet.Executar},
                { "Propriedades - Classes e Metodos", Props.Executar},
                { "Readonly - Classes e Metodos", Readonly.Executar},
                { "Enum - Classes e Métodos", ExemploEnum.Executar},
                { "Struct - Classes e Métodos", ExemploStruct.Executar},
                { "Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar},
                { "Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                { "Parâmetros por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                { "Parâmetros Padrão - Classes e Métodos", ParametroPadrao.Executar},
                

                //Colecoes
                { "Array - Coleções", Colecoes.Array.Executar},
                { "List - Coleções", ColecoesList.Executar},
                { "ArrayList - Coleções", ColecoesArrayList.Executar},
                { "Set - Coleções",ColecoesSet.Executar},
                { "Queue - Coleções",ColecoesQueue.Executar},
                { "Stack - Coleções",ColecoesStack.Executar},
                { "Dictionary - Coleções",ColecoesDictionary.Executar},

                //OO
                { "Herança - OO",Heranca.Executar},
                { "Construtor This - OO",ConstrutorThis.Executar},
                { "Encapsulamento - OO",OO.Encapsulamento.Executar},


            });



            central.SelecionarEExecutar();
        }
    }
}