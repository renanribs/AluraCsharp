using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2.operacoes
{
    public class Divisao
    {
        public double Calcular(double numeroUm, double numeroDois)
        {
           if (numeroUm == 0) { return 0; }else { return numeroUm / numeroDois; }
        }
    }
}
