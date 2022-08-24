using byteBank_ADM.Funcionarios;
using byteBank_ADM.Utilitario;

Console.WriteLine("Boas vindas, ByteBank Adm!");
Console.WriteLine();

CalcularBonificacao();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    Designer pedro = new Designer("123");
    pedro.Nome = "Pedro";

    Diretor paula = new Diretor("123");
    paula.Nome = "Paula";

    Auxiliar igor = new Auxiliar("1234");
    igor.Nome = "Igor";

    GerenteDeContas camila = new GerenteDeContas("123");
    camila.Nome = "Camila";

    gerenciador.Registrar(pedro);  
    gerenciador.Registrar(paula);  
    gerenciador.Registrar(igor);  
    gerenciador.Registrar(camila);  

}

