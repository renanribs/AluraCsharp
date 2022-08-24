using Aula2.operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    public class Operacoes
    {
        public Soma Soma { get; private set; }
        public Subtracao Subtracao { get; private set; }
        public Divisao Divisao { get; private set; }
        public Multiplicacao Multiplicacao { get; private set; }
        public Operacoes() {
            this.Soma = new Soma();
            this.Subtracao = new Subtracao();
            this.Divisao = new Divisao();
            this.Multiplicacao = new Multiplicacao();
        }   
    }
}
