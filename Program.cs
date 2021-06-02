using ByteBank.Sistemas;
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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            
            

            Diretor roberta = new Diretor(5000, "312.645.876-89");
            roberta.Nome = "Roberta";
                       

            Console.WriteLine(roberta.Nome);
            Console.WriteLine("Salario de Roberta: " + roberta.Salario);
            Console.WriteLine("Bonificacao de Roberta: " + roberta.GetBonificacao());

            roberta.AumentarSalario();

            Console.WriteLine("Novo salario de Roberta: " + roberta.Salario);
            Console.WriteLine("Bonificacao de Roberta: " + roberta.GetBonificacao());

            Console.WriteLine("Nova bonificacao de Roberta: " + roberta.GetBonificacao());
            gerenciador.Registrar(roberta);

            Console.WriteLine("Total de bonificacao paga");
            Console.WriteLine(gerenciador.GetTotalBonificacao());

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Console.WriteLine("######### AUTENTICACAO DE FUNCIONARIOS AUTENTICAVEIS E PARCEIRO COMERCIAL");
            Console.WriteLine();
            Console.WriteLine();

            GerenteDeConta marcela = new GerenteDeConta("123456-12");
            Diretor juliana = new Diretor(10000, "123.345.123-12");
            ParceiroComercial roberto = new ParceiroComercial();

            marcela.Senha = "123";
            juliana.Senha = "asdf";
            roberto.Senha = "qwer";

            SistemaInterno sistemaInterno = new SistemaInterno();
            sistemaInterno.Logar(marcela, marcela.Senha);
            sistemaInterno.Logar(juliana, juliana.Senha);
            sistemaInterno.Logar(roberto, roberto.Senha);












            Console.ReadLine();
        }
    }
}
