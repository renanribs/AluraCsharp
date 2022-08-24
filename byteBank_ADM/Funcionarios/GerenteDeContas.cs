﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    public class GerenteDeContas:Funcionario
    {
        public GerenteDeContas(string cpf) :base(cpf, 4000)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
        public override double getBonificacao()
        {
            return Salario * 0.20;
        }
    }
}
