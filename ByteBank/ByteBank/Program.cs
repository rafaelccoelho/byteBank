using ByteBank.Funcionarios;
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
            GerenciadorBonificacao gereciador = new GerenciadorBonificacao();
            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "118.732.118-90";
            carlos.Salario = 2000;
            gereciador.Registrar(carlos);

            Diretor roberta = new Diretor();

            roberta.Nome = "Roberta";
            roberta.CPF = "431.732.118-55";
            roberta.Salario = 5000;
            gereciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificação: " + gereciador.GetTotalBonificacao());


            Console.ReadLine();
        }
    }
}
