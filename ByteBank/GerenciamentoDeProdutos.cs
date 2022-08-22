using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciamentoDeProdutos
    {
        class Aluno
        {


            private int matricula;
            public string Nome { get; set; }
            public string Email { get; set; }
            public bool Status { get; set; }
            public int TipoCurso { get; set; }


            public int Matricula
            {
                get
                {
                    return matricula;
                }
                set
                {
                    if (matricula <= 0)
                    {
                        Console.WriteLine("Número de matricula invalido!");
                    } else
                    {
                        matricula = value;
                    }
                }
            }
        }
    }
}
