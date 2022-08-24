using byteBank_ADM.Funcionarios;
using byteBank_ADM.Utilitario;

Console.WriteLine("Boas vindas, ByteBank Adm!");
Console.WriteLine();

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario renan = new Funcionario("12345678", 2500);
renan.Nome = "Renan Ribeiro";

Console.WriteLine($"Nome: {renan.Nome}");
Console.WriteLine($"CPF: {renan.Cpf}");
Console.WriteLine($"Salario: {renan.Salario}");
Console.WriteLine($"Bonificacao {renan.getBonificacao()}");
Console.WriteLine();
Console.WriteLine($"Total de funcionarios: {Funcionario.totalDeFuncionarios}");
Console.WriteLine();
Diretor vanessa = new Diretor("123456", 5000);
vanessa.Nome = "Vanessa Maluf";

Console.WriteLine($"Nome: {vanessa.Nome}");
Console.WriteLine($"CPF: {vanessa.Cpf}");
Console.WriteLine($"Salario: {vanessa.Salario}");
Console.WriteLine($"Bonificacao {vanessa.getBonificacao()}");
Console.WriteLine($"Total de funcionarios: {Funcionario.totalDeFuncionarios}");
Console.WriteLine();
gerenciador.Registrar(renan);
gerenciador.Registrar(vanessa);
Console.WriteLine();
Console.WriteLine($"Total de bonificações: {gerenciador.getBonificacao()}");

renan.AumentarSalario();
Console.WriteLine($"Novo salario Renan: {renan.Salario}");
vanessa.AumentarSalario();
Console.WriteLine($"Novo salario Vanessa: {vanessa.Salario}");