﻿using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        public Diretor(double salario, string cpf) : base(salario, cpf)
        {
            Console.WriteLine("Criando Diretor...");
        }

        public override double GetBonificacao()
        {
            
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

  
    }
}
