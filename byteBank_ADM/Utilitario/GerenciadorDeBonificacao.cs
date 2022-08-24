using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using byteBank_ADM.Funcionarios;

namespace byteBank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();

        }

        public double getBonificacao()
        { 
            return this.totalBonificacao; 
        }
    }
}
