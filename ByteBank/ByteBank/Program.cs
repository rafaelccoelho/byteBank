﻿using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();

            Console.ReadLine();
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Auxiliar joao = new Auxiliar("118.736.445-55");
            joao.Nome = "Joao";
            gerenciadorBonificacao.Registrar(joao);

            Designer maria = new Designer("888.444.444-88");
            maria.Nome = "Maria";
            gerenciadorBonificacao.Registrar(maria);

            Diretor carlos = new Diretor("741.523.456-99");
            carlos.Nome = "Carlos";
            gerenciadorBonificacao.Registrar(carlos);

            GerenteDeConta luana = new GerenteDeConta("787.123.456-78");
            luana.Nome = "Luana";
            gerenciadorBonificacao.Registrar(luana);

            GerenteDeConta rafael = new GerenteDeConta("222.555.456-78");
            rafael.Nome = "Rafael";
            gerenciadorBonificacao.Registrar(rafael);


            Console.WriteLine("Total de Bonificações: " + gerenciadorBonificacao.GetTotalBonificacao());



        }
    }
}
