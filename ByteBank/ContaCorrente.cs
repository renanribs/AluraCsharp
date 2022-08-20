using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;
        
        public bool Sacar(double valor)
        {
            if(saldo < valor)
            {
                return false;
            } else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public void Depositar (double valor)
        {
            saldo = saldo + valor;
        }
    }
}
