using byteBank_ADM.Funcionarios;
using byteBank_ADM.Utilitario;

Console.WriteLine("Boas vindas, ByteBank Adm!");
Console.WriteLine();

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario renan = new Funcionario();
renan.Nome = "Renan Ribeiro";
renan.Cpf = "12345678";
renan.Salario = 2500;
Console.WriteLine($"Nome: {renan.Nome}");
Console.WriteLine($"CPF: {renan.Cpf}");
Console.WriteLine($"Salario: {renan.Salario}");
Console.WriteLine($"Bonificacao {renan.getBonificacao()}");
Console.WriteLine();

Diretor vanessa = new Diretor();
vanessa.Nome = "Vanessa Maluf";
vanessa.Cpf = "123456";
vanessa.Salario = 5000;
Console.WriteLine($"Nome: {vanessa.Nome}");
Console.WriteLine($"CPF: {vanessa.Cpf}");
Console.WriteLine($"Salario: {vanessa.Salario}");
Console.WriteLine($"Bonificacao {vanessa.getBonificacao()}");

gerenciador.Registrar(renan);
gerenciador.Registrar(vanessa);

Console.WriteLine($"Total de bonificações: {gerenciador.getBonificacao()}");