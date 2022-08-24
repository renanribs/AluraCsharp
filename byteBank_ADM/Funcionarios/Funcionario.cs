using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        //0 - funcionário
        //1 - diretor
        //2 - designer
        //N - ...
        public static int totalDeFuncionarios { get; set; }

        public string Nome { get;  set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public virtual double getBonificacao()
        {
                return Salario * 0.1; 
        }

       
        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            totalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            this.Salario = Salario * 1.1;
        }

    }
}
